
namespace CrosshairPlus.ControlPanels
{
    partial class ProcessInformationPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LPath = new System.Windows.Forms.Label();
            this.TBPath = new System.Windows.Forms.TextBox();
            this.TBPID = new System.Windows.Forms.TextBox();
            this.LPID = new System.Windows.Forms.Label();
            this.TBProcessName = new System.Windows.Forms.TextBox();
            this.LProcessName = new System.Windows.Forms.Label();
            this.B_Open = new System.Windows.Forms.Button();
            this.TBWindowTitle = new System.Windows.Forms.TextBox();
            this.LWindowTitle = new System.Windows.Forms.Label();
            this.P_Main = new System.Windows.Forms.Panel();
            this.P_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // LPath
            // 
            this.LPath.AutoSize = true;
            this.LPath.Location = new System.Drawing.Point(0, 11);
            this.LPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LPath.Name = "LPath";
            this.LPath.Size = new System.Drawing.Size(34, 15);
            this.LPath.TabIndex = 0;
            this.LPath.Text = "Path:";
            // 
            // TBPath
            // 
            this.TBPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBPath.Location = new System.Drawing.Point(95, 8);
            this.TBPath.Margin = new System.Windows.Forms.Padding(2);
            this.TBPath.Name = "TBPath";
            this.TBPath.ReadOnly = true;
            this.TBPath.Size = new System.Drawing.Size(141, 23);
            this.TBPath.TabIndex = 1;
            // 
            // TBPID
            // 
            this.TBPID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBPID.Location = new System.Drawing.Point(95, 35);
            this.TBPID.Margin = new System.Windows.Forms.Padding(2);
            this.TBPID.Name = "TBPID";
            this.TBPID.ReadOnly = true;
            this.TBPID.Size = new System.Drawing.Size(169, 23);
            this.TBPID.TabIndex = 3;
            // 
            // LPID
            // 
            this.LPID.AutoSize = true;
            this.LPID.Location = new System.Drawing.Point(0, 36);
            this.LPID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LPID.Name = "LPID";
            this.LPID.Size = new System.Drawing.Size(28, 15);
            this.LPID.TabIndex = 2;
            this.LPID.Text = "PID:";
            // 
            // TBProcessName
            // 
            this.TBProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBProcessName.Location = new System.Drawing.Point(95, 62);
            this.TBProcessName.Margin = new System.Windows.Forms.Padding(2);
            this.TBProcessName.Name = "TBProcessName";
            this.TBProcessName.ReadOnly = true;
            this.TBProcessName.Size = new System.Drawing.Size(169, 23);
            this.TBProcessName.TabIndex = 5;
            // 
            // LProcessName
            // 
            this.LProcessName.AutoSize = true;
            this.LProcessName.Location = new System.Drawing.Point(0, 63);
            this.LProcessName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LProcessName.Name = "LProcessName";
            this.LProcessName.Size = new System.Drawing.Size(85, 15);
            this.LProcessName.TabIndex = 4;
            this.LProcessName.Text = "Process Name:";
            // 
            // B_Open
            // 
            this.B_Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Open.BackColor = System.Drawing.Color.Transparent;
            this.B_Open.BackgroundImage = global::CrosshairPlus.Properties.Resources.OpenFolder;
            this.B_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Open.Location = new System.Drawing.Point(240, 8);
            this.B_Open.Margin = new System.Windows.Forms.Padding(2);
            this.B_Open.Name = "B_Open";
            this.B_Open.Size = new System.Drawing.Size(24, 23);
            this.B_Open.TabIndex = 11;
            this.B_Open.UseVisualStyleBackColor = false;
            this.B_Open.Click += new System.EventHandler(this.B_Open_Click);
            // 
            // TBWindowTitle
            // 
            this.TBWindowTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBWindowTitle.Location = new System.Drawing.Point(95, 89);
            this.TBWindowTitle.Margin = new System.Windows.Forms.Padding(2);
            this.TBWindowTitle.Name = "TBWindowTitle";
            this.TBWindowTitle.ReadOnly = true;
            this.TBWindowTitle.Size = new System.Drawing.Size(169, 23);
            this.TBWindowTitle.TabIndex = 10;
            // 
            // LWindowTitle
            // 
            this.LWindowTitle.AutoSize = true;
            this.LWindowTitle.Location = new System.Drawing.Point(0, 90);
            this.LWindowTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LWindowTitle.Name = "LWindowTitle";
            this.LWindowTitle.Size = new System.Drawing.Size(79, 15);
            this.LWindowTitle.TabIndex = 7;
            this.LWindowTitle.Text = "Window Title:";
            // 
            // P_Main
            // 
            this.P_Main.AutoScroll = true;
            this.P_Main.Controls.Add(this.LPath);
            this.P_Main.Controls.Add(this.B_Open);
            this.P_Main.Controls.Add(this.LPID);
            this.P_Main.Controls.Add(this.TBWindowTitle);
            this.P_Main.Controls.Add(this.TBPath);
            this.P_Main.Controls.Add(this.TBPID);
            this.P_Main.Controls.Add(this.TBProcessName);
            this.P_Main.Controls.Add(this.LWindowTitle);
            this.P_Main.Controls.Add(this.LProcessName);
            this.P_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Main.Location = new System.Drawing.Point(0, 0);
            this.P_Main.Name = "P_Main";
            this.P_Main.Size = new System.Drawing.Size(272, 258);
            this.P_Main.TabIndex = 12;
            // 
            // ProcessInformationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.P_Main);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProcessInformationPanel";
            this.Size = new System.Drawing.Size(272, 258);
            this.P_Main.ResumeLayout(false);
            this.P_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LPath;
        private System.Windows.Forms.TextBox TBPath;
        private System.Windows.Forms.TextBox TBPID;
        private System.Windows.Forms.Label LPID;
        private System.Windows.Forms.TextBox TBProcessName;
        private System.Windows.Forms.Label LProcessName;
        private System.Windows.Forms.TextBox TBWindowTitle;
        private System.Windows.Forms.Label LWindowTitle;
        private System.Windows.Forms.Button B_Open;
        private System.Windows.Forms.Panel P_Main;
    }
}
