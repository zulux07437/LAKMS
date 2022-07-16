using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Management;
using Functions;

namespace LAKMS
{
    public partial class LAKMS : Form
    {
        private ManagementClass OS = new ManagementClass("Win32_OperatingSystem");
        private static string OSString = ""; // Windows 10 Home
        private static string KMSProductKey = ""; // XXXXX-XXXXX-XXXXX-XXXXXX-XXXXX
        private static byte[] DigitalProductID = null;
        private static string thisVersion = $"v{Application.ProductVersion} Alpha by zulux07437";
        private static bool IsNotCompatible = false;
        private static bool AutoKMSMode = false;

        private KMSEmulator.KMSServerSettings KMSSettings = new KMSEmulator.KMSServerSettings
        {
            KillProcessOnPort = true,
            GenerateRandomKMSPID = true,
            DefaultKMSHWID = "364F463A8863D35F"
        };

        /****************
         * 
         * Main Forms
         * 
         ****************/
        public LAKMS()
        {
            InitializeComponent();
        }

        private void LAKMS_Load(object sender, EventArgs e)
        {
            if (AutoKMSMode == true)
            {

            }
            StatusStrip_Label.Text = thisVersion;
            AppendLog("LAKMS Loading succeeded.", 0);
        }

        private void LinkLabel_GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel_GitHub.LinkVisited = true;
            Process.Start(@"https://github.com/zulux07437/LAKMS");
        }

        /************************
         * 
         * LocalActivate Tab
         * 
         ************************/
        private void Button_GetInfo_Click(object sender, EventArgs e)
        {
            ManagementObjectCollection moc = OS.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                TextBox_OS.Text = $"{mo["Caption"]}";
                TextBox_Version.Text = $"{mo["Version"]}";

                OSString = $"{mo["Caption"]}";
            }


            KMSProductKey = Get.GetKMSProductKey(OSString);
            if (KMSProductKey != "false") // If GetKMSProductKey is successful.
            {
                TextBox_KMSProductKey.Text = KMSProductKey;
                DigitalProductID = Get.GetDigitalProductID();
                Button_Activate.Enabled = true;
            }
        }

        private void Button_Activate_Click(object sender, EventArgs e)
        {
            try
            {
                // Change ProgressBar Style
                ChangeProgress();

                // Start KMS Emulator
                KMSEmulator.KMSServer.Start(null, KMSSettings);


                /***
                 * 
                 * Load SppExtComObjHook.dll
                 * 
                 ***/
                if (Install.LoadDLL() == true) // If succeeded to load.
                {
                    AppendLog("Succeeded to Load DLL.", 0); // 0 = Success, 1 = Error, 2 = Message.
                }
                else // If failed to load.
                {
                    throw new Exception("Failed to load the SppExtComObjHook.dll.");
                }

                /***
                 * 
                 * Uninstall ProductKey
                 * 
                 ***/

                if (Install.UninstallProductKey() == true)
                {
                    AppendLog("Succeeded to Uninstall ProductKey.", 0);
                }
                else
                {
                    throw new Exception("Failed to Uninstall ProductKey.");
                }

                /***
                 * 
                 * Install ProductKey
                 * 
                 ***/

                if (Install.InstallProductKey(TextBox_KMSProductKey.Text) == true)
                {
                    AppendLog("Succeeded to Install ProductKey.", 0);
                }
                else
                {
                    throw new Exception("Failed to Install ProductKey.");
                }

                /***
                 * 
                 * Install KMS Information
                 * 
                 ***/
                if (Install.InstallKMSInformation(OSString, "10.3.0.1") == true)
                {
                    AppendLog("Succeeded to Install KMS Information.", 0);
                }
                else
                {
                    throw new Exception("Failed to Install KMS Information.");
                }

                /***
                 * 
                 * Activate KMS
                 * 
                 ***/
                if (Install.ActivateKMS() == true)
                {
                    AppendLog("Succeeded to Activate KMS.", 0);
                }
                else
                {
                    throw new Exception("Failed to Activate KMS.");
                }



                // Stop KMS Emulator
                KMSEmulator.KMSServer.Stop();

                if (Install.UnloadDLL() == true)
                {
                    AppendLog("Succeeded to Unload DLL.", 0);
                }
                else
                {
                    throw new Exception("Failed to unload the SppExtComObjHook.dll.");
                }

                // Change ProgressBar Style
                ChangeProgress();


                MessageBox.Show("Auto KMS Activation is Succeeded. Please Restart PC or Refresh License Status.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                KMSEmulator.KMSServer.Stop();
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppendLog(ex.Message, 1);
                ChangeProgress();
            }
        }

        /*****************
         * 
         * Server Tab
         * 
         *****************/
        private async void Button_StartKMSServer_Click(object sender, EventArgs e)
        {
            StatusStrip_ProgressBar.Style = ProgressBarStyle.Marquee;
            try
            {
                TextBox_GrobalIPAddress.Text = await Get.GetGrobalIPAddress();
                AppendLog("Get Grobal IP Address", 0);

                TextBox_PrivateIPAddress.Text = Get.GetPrivateIPAddress();
                AppendLog("Get Private IP Address", 0);

                KMSEmulator.KMSServer.Start(null, KMSSettings);
                AppendLog("KMS Server Start", 0);

                KMSEmulator.KMSServer.Stop();
            }
            catch
            {
                AppendLog("Start KMS Server Failed.", 1);
            }

            StatusStrip_ProgressBar.Style = ProgressBarStyle.Blocks;
        }

        /**********************
         * 
         * Settings Tab
         * 
         **********************/


        /*********************
         * 
         * About Tab
         * 
         *********************/
        private void Button_ChangeLogs_Click(object sender, EventArgs e)
        {
            ChangeLogs cl = new ChangeLogs();
            cl.ShowDialog();
        }

        private void CheckBox_ManuallySelect_Click(object sender, EventArgs e)
        {
            if (CheckBox_ManuallySelect.Checked == true)
            {
                TextBox_KMSProductKey.ReadOnly = false;
            }
            else if (CheckBox_ManuallySelect.Checked == false)
            {
                TextBox_KMSProductKey.ReadOnly = true;
            }
        }



        /***************
         * 
         * Methods
         * 
         ***************/
        /// <summary>
        /// 0 = Success, 1 = Error, 2 = Message.
        /// </summary>
        /// <param name="Text">LogText</param>
        /// <param name="LogStatus">LogStatus</param>
        public void AppendLog(string Text, int LogStatus)
        {
            if (Properties.Settings.Default.Log == true)
            {
                DateTime DateTime = DateTime.Now;
                if (LogStatus == 0)
                {
                    TextBox_Log.AppendText($"{DateTime} [SUCCESS] {Text}\r\n");
                }
                else if (LogStatus == 1)
                {
                    TextBox_Log.AppendText($"{DateTime} [ERROR] {Text}\r\n");
                }
                else if (LogStatus == 2)
                {
                    TextBox_Log.AppendText($"{DateTime} [MESSAGE] {Text}\r\n");
                }
                else
                {
                    TextBox_Log.AppendText($"{DateTime} [UNKNOWN] {Text}\r\n");
                }
            }
        }

        private void ChangeProgress()
        {
            if (StatusStrip_ProgressBar.Style == ProgressBarStyle.Blocks)
            {
                StatusStrip_ProgressBar.Style = ProgressBarStyle.Marquee;
            }
            else if (StatusStrip_ProgressBar.Style == ProgressBarStyle.Marquee)
            {
                StatusStrip_ProgressBar.Style = ProgressBarStyle.Blocks;
            }
        }

        private void CheckBox_Log_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Log.Checked == true)
            {
                Properties.Settings.Default.Log = true;
            }
            else if (CheckBox_Log.Checked == false)
            {
                Properties.Settings.Default.Log = false;
            }
        }
    }
}
