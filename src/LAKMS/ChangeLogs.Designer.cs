namespace LAKMS
{
    partial class ChangeLogs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_OK = new System.Windows.Forms.Button();
            this.TextBox_ChangeLogs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(329, 358);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 1;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // TextBox_ChangeLogs
            // 
            this.TextBox_ChangeLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBox_ChangeLogs.Location = new System.Drawing.Point(0, 0);
            this.TextBox_ChangeLogs.Multiline = true;
            this.TextBox_ChangeLogs.Name = "TextBox_ChangeLogs";
            this.TextBox_ChangeLogs.ReadOnly = true;
            this.TextBox_ChangeLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_ChangeLogs.Size = new System.Drawing.Size(416, 352);
            this.TextBox_ChangeLogs.TabIndex = 0;
            this.TextBox_ChangeLogs.Text = "LAKMS\r\n\r\n---v1.0.0.0 Alpha---\r\nFirst Release.\r\nThis build does not have enough Su" +
    "pport of Vista, 7. Probably it is works on 7, but not on Vista.\r\nThis build is s" +
    "o so unstable.";
            this.TextBox_ChangeLogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangeLogs
            // 
            this.AcceptButton = this.Button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 393);
            this.Controls.Add(this.TextBox_ChangeLogs);
            this.Controls.Add(this.Button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeLogs";
            this.ShowIcon = false;
            this.Text = "ChangeLogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.TextBox TextBox_ChangeLogs;
    }
}