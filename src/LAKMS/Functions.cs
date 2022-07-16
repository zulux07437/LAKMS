using System;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Diagnostics;
using System.Management;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using LAKMS.Properties;
using Microsoft.Win32;

namespace Functions
{
    /// <summary>
    /// Common Functions
    /// </summary>
    public static class Common
    {
        /// <summary>
        /// License Status Refresh
        /// </summary>
        /// <returns>If it fails, It returns the false of a bool.</returns>
        public static bool RefreshStatus()
        {
            return true;
        }

        /// <summary>
        /// Terminate Process without PID
        /// </summary>
        /// <param name="Name">Process Name</param>
        public static void TerminateProcess(string Name)
        {
            Process[] gpbn = Process.GetProcessesByName(Name);
            foreach (Process p in gpbn)
            {
                p.Kill();
                p.WaitForExit();
            }
        }
    }

    /// <summary>
    /// Get Functions
    /// </summary>
    public static class Get
    {
        /// <summary>
        /// Get KMSProductKey
        /// </summary>
        /// <param name="OSString">Caption of that OS. (For example: Microsoft Windows 10 Pro)</param>
        /// <returns>Returns KMSProductKey of a string. (For example: "W269N-WFGWX-YVC9B-4J6C9-T83GX")If it fails, It returns the "false" of a string.</returns>
        public static string GetKMSProductKey(string OSString)
        {
            /******************************
             * 
             * Windows 10 / Windows 11
             *
             ******************************/
            if (OSString.StartsWith("Microsoft Windows 10 ") || OSString.StartsWith("Microsoft Windows 11 "))
            {
                /***********************
                 * 
                 * Core Editions 
                 * 
                 ***********************/
                if (OSString.EndsWith("Pro") || OSString.EndsWith("Pro Insider Preview"))
                {
                    return "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                }
                else if (OSString.EndsWith("Education") || OSString.EndsWith("Education Insider Preview"))
                {
                    return "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
                }
                else if (OSString.EndsWith("Enterprise") || OSString.EndsWith("Enterprise Insider Preview"))
                {
                    return "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                }
                /**********************************
                 * 
                 * LTSB / LTSC
                 * 
                 **********************************/
                else if (OSString.EndsWith("LTSC 2019") || OSString.EndsWith("LTSC 2021"))
                {
                    return "M7XTQ-FN8P6-TTKYV-9D4CC-J462D";
                }
                else if (OSString.EndsWith("LTSB 2016"))
                {
                    return "DCPHK-NFMTC-H88MJ-PFHPY-QJ4BJ";
                }
                else if (OSString.EndsWith("2015 LTSB"))
                {
                    return "WNMTR-4C88C-JK8YV-HQ7T2-76DF9";
                }
            }

            /******************
             * 
             * Windows 8.1
             * 
             ******************/
            else if (OSString.StartsWith("Microsoft Windows 8.1 "))
            {
                /**********************
                 * 
                 * Core Editions
                 * 
                 **********************/
                if (OSString.EndsWith("Pro"))
                {
                    return "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9";
                }
                else if (OSString.EndsWith("Enterprise"))
                {
                    return "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7";
                }
            }

            /*****************
             * 
             * Windows 8
             * 
             *****************/
            else if (OSString.StartsWith("Microsoft Windows 8 "))
            {
                /*********************
                 * 
                 * Core Editions
                 * 
                 *********************/
                if (OSString.EndsWith("Pro"))
                {
                    return "NG4HW-VH26C-733KW-K6F98-J8CK4";
                }
                else if (OSString.EndsWith("Enterprise"))
                {
                    return "32JNW-9KQ84-P47T8-D8GGY-CWCK7";
                }
            }

            /*******************
             * 
             * Windows 7
             * 
             *******************/
            else if (OSString.StartsWith("Microsoft Windows 7 "))
            {
                /************************
                 * 
                 * Core Editions
                 * 
                 ************************/
                if (OSString.EndsWith("Professional "))
                {
                    return "FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4";
                }
                else if (OSString.EndsWith("Enterprise "))
                {
                    return "33PXH-7Y6KF-2VJC9-XBBR8-HVTHH";
                }
            }

            /**********************
             * 
             * Windows Vista
             * 
             **********************/
            else if (OSString.StartsWith("Microsoft Windows Vista "))
            {
                /*********************
                 * 
                 * Core Editions
                 * 
                 *********************/
                if (OSString.EndsWith("Business "))
                {
                    return "YFKBB-PQJJV-G996G-VWGXY-2V3X8";
                }
                else if (OSString.EndsWith("Enterprise "))
                {
                    return "VKK3X-68KWM-X2YGT-QR4M6-4BWMV";
                }
            }
            else
            {
                return "false";
            }
            return "";
        }

        /// <summary>
        /// Get GrobalIPAddress with string
        /// </summary>
        /// <returns>GrobalIPAddress</returns>
        public static async Task<string> GetGrobalIPAddress()
        {
            try
            {
                HttpClient hc = new HttpClient();
                string responce = await hc.GetStringAsync("https://api.ipify.org/");

                return responce;
            }
            catch
            {
                return "Unknown";
            }
        }

        /// <summary>
        /// Get PrivateIPAddress with string
        /// </summary>
        /// <returns>PrivateIPAddress</returns>
        public static string GetPrivateIPAddress()
        {
            string IPAddress = "Unknown";
            string ghn = Dns.GetHostName();
            IPAddress[] ghnList = Dns.GetHostAddresses(ghn);
            foreach (IPAddress ipa in ghnList)
            {
                IPAddress = ipa.ToString();
            }
            return IPAddress;
        }

        /// <summary>
        /// Get DigitalProductID
        /// </summary>
        /// <returns>DigitalProductID from the Registry</returns>
        public static byte[] GetDigitalProductID()
        {
            RegistryKey KeyCurrentVersion = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", false);
            byte[] DigitalProductID = KeyCurrentVersion.GetValue("DigitalProductId") as byte[];
            KeyCurrentVersion.Close();

            return DigitalProductID;
        }

        /// <summary>
        /// Get (NT)KernelVersion (For Windows 8 or higher, it returns Kernel Version 6.2)
        /// </summary>
        /// <returns>KernelVersion</returns>
        public static string GetKernelVersion()
        {
            OperatingSystem OS = Environment.OSVersion;
            string KernelVersion = OS.Version.Major + "." + OS.Version.Minor;

            return KernelVersion;
        }
    }

    /// <summary>
    /// Install Functions
    /// </summary>
    public static class Install
    {
        private static byte[] DLL = Resources.SppExtComObjHook; // SppExtComObjHook.dll
        private static string DLLPath = $@"{Environment.SystemDirectory}\SppExtComObjHook.dll"; // C:\Windows\System32\SppExtComObjHook.dll

        private static ManagementObjectSearcher mos = new ManagementObjectSearcher();
        private const string WHERE =
            "ApplicationID = \"55c92734-d682-4d71-983e-d6ec3f16059f\" AND " +
            "LicenseIsAddon = false AND " +
            "LicenseStatus <> 0";

        /// <summary>
        /// Load SppExtComObjHook.dll
        /// </summary>
        /// <returns>If it fails, it returns false of a bool.</returns>
        public static bool LoadDLL()
        {
            try
            {
                if (File.Exists(DLLPath) == false)
                {
                    Common.TerminateProcess("SppExtComObj");
                    File.WriteAllBytes(DLLPath, DLL);
                }

                using (RegistryKey KeySppExtComObj = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\SppExtComObj.exe"))
                {
                    KeySppExtComObj.SetValue("Debugger", "RunDll32.exe SppExtComObjHook.dll,PatcherMain", RegistryValueKind.String);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Unload SppExtComObjHook.dll
        /// </summary>
        /// <returns>If it fails, it returns false of a bool.</returns>
        public static bool UnloadDLL()
        {
            try
            {
                Common.TerminateProcess("SppExtComObj");
                File.Delete(DLLPath);
                using (RegistryKey KeyIFEO = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options"))
                {
                    KeyIFEO.DeleteSubKey("SppExtComObj.exe");
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Install KMS IP Address
        /// </summary>
        /// <param name="KMSIPAddress">KMS Server Address</param>
        public static bool InstallKMSInformation(string OSString, string KMSIPAddress)
        {
            try
            {
                mos = new ManagementObjectSearcher("SELECT VERSION FROM SoftwareLicensingService");
                foreach (ManagementObject mo in mos.Get())
                {
                    mo.InvokeMethod("SetKeyManagementServiceMachine", new object[] { KMSIPAddress });
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Install ProductKey
        /// </summary>
        /// <param name="ProductKey">KMS Client Product Key of that OS (For example: W269N-WFGWX-YVC9B-4J6C9-T83GX)</param>
        /// <returns>If it fails, it returns false of a bool.</returns>
        public static bool InstallProductKey(string ProductKey)
        {
            try
            {
                mos = new ManagementObjectSearcher("SELECT VERSION FROM SoftwareLicensingService");
                foreach (ManagementObject mo in mos.Get())
                {
                    mo.InvokeMethod("InstallProductKey", new object[] { ProductKey });
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Uninstall ProductKey
        /// </summary>
        /// <returns>If it fails, it returns false of a bool.</returns>
        public static bool UninstallProductKey()
        {
            try
            {
                mos = new ManagementObjectSearcher($"SELECT ID FROM SoftwareLicensingProduct WHERE {WHERE}");
                foreach (ManagementObject mo in mos.Get())
                {
                    mo.InvokeMethod("UninstallProductKey", new object[0]);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Activate KMS Information
        /// </summary>
        /// <returns>If it fails, it returns false of a bool.</returns>
        public static bool ActivateKMS()
        {
            try
            {
                mos = new ManagementObjectSearcher($"SELECT ID FROM SoftwareLicensingProduct WHERE {WHERE}");
                foreach (ManagementObject mo in mos.Get())
                {
                    mo.InvokeMethod("Activate", new object[0]);
                }

                mos = new ManagementObjectSearcher("SELECT VERSION FROM SoftwareLicensingService");
                foreach (ManagementObject mo in mos.Get())
                {
                    mo.InvokeMethod("RefreshLicenseStatus", new object[0]);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
