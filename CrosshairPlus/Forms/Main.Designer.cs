
using CrosshairPlus.ControlPanels;
using CrosshairPlus.Controls;

namespace CrosshairPlus.Forms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.GBWindow = new System.Windows.Forms.GroupBox();
            this.PCB_Window = new CrosshairPlus.Controls.ProcessComboBox();
            this.PB_WindowImage = new System.Windows.Forms.PictureBox();
            this.P_ProcessWindowInformation = new CrosshairPlus.ControlPanels.ProcessInformationPanel();
            this.TT_Main = new System.Windows.Forms.ToolTip(this.components);
            this.SS_Main = new System.Windows.Forms.StatusStrip();
            this.TSSL_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSL_Spring0 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSL_Version = new System.Windows.Forms.ToolStripStatusLabel();
            this.B_HookToggle = new System.Windows.Forms.Button();
            this.T_WindowTracker = new System.Windows.Forms.Timer(this.components);
            this.TB_Main = new System.Windows.Forms.TabControl();
            this.TP_ProcessInformation = new System.Windows.Forms.TabPage();
            this.TP_Crosshair = new System.Windows.Forms.TabPage();
            this.P_CrosshairInformation = new CrosshairPlus.ControlPanels.CrosshairInformationPanel();
            this.TP_Image = new System.Windows.Forms.TabPage();
            this.P_CrosshairImage = new CrosshairPlus.ControlPanels.CrosshairImagePanel();
            this.TP_Options = new System.Windows.Forms.TabPage();
            this.P_CrosshairOptions = new CrosshairPlus.ControlPanels.CrosshairOptionsPanel();
            this.GB_Hook = new System.Windows.Forms.GroupBox();
            this.GBWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_WindowImage)).BeginInit();
            this.SS_Main.SuspendLayout();
            this.TB_Main.SuspendLayout();
            this.TP_ProcessInformation.SuspendLayout();
            this.TP_Crosshair.SuspendLayout();
            this.TP_Image.SuspendLayout();
            this.TP_Options.SuspendLayout();
            this.GB_Hook.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBWindow
            // 
            this.GBWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBWindow.Controls.Add(this.PCB_Window);
            this.GBWindow.Controls.Add(this.PB_WindowImage);
            this.GBWindow.Location = new System.Drawing.Point(17, 18);
            this.GBWindow.Name = "GBWindow";
            this.GBWindow.Size = new System.Drawing.Size(444, 83);
            this.GBWindow.TabIndex = 3;
            this.GBWindow.TabStop = false;
            this.GBWindow.Text = "Window";
            // 
            // PCB_Window
            // 
            this.PCB_Window.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PCB_Window.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.PCB_Window.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PCB_Window.FormattingEnabled = true;
            this.PCB_Window.ImagesVisible = true;
            this.PCB_Window.Items.AddRange(new object[] {
            "Microsoft Text Input Application",
            "Settings",
            "Calculator",
            "Microsoft Store",
            "Weather",
            "Calculator",
            "Ubisoft Connect",
            ".net - Visual Studio project build as an executable AND a DLL - Stack Overflow - " +
                "Brave",
            "Crosshair+ - Microsoft Visual Studio",
            "Microsoft Text Input Application",
            "Settings",
            "Calculator",
            "Microsoft Store",
            "Weather",
            "Calculator",
            "Ubisoft Connect",
            ".net - Visual Studio project build as an executable AND a DLL - Stack Overflow - " +
                "Brave",
            "Crosshair+ - Microsoft Visual Studio",
            "Microsoft Text Input Application",
            "Crosshair+ - Microsoft Visual Studio",
            "CelesitalChaos/CrosshairPlus: Render a crosshair on your target game window. - Br" +
                "ave",
            "Microsoft Store",
            "Microsoft Store",
            "Settings",
            "Weather",
            "Calculator",
            "Microsoft Text Input Application",
            "Crosshair+ - Microsoft Visual Studio",
            "CelesitalChaos/CrosshairPlus: Render a crosshair on your target game window. - Br" +
                "ave",
            "Microsoft Store",
            "Microsoft Store",
            "Settings",
            "Weather",
            "Calculator",
            "Microsoft Text Input Application",
            "Settings",
            "Calculator",
            "Steam",
            "Microsoft Store",
            "Weather",
            "Calculator",
            "qBittorrent v4.3.5",
            "pinvoke.net: Search Results - Brave",
            "Crosshair+ - Microsoft Visual Studio",
            "Microsoft Text Input Application",
            "Settings",
            "Calculator",
            "Steam",
            "Microsoft Store",
            "Weather",
            "Calculator",
            "qBittorrent v4.3.5",
            "pinvoke.net: Search Results - Brave",
            "Microsoft Text Input Application",
            "Settings",
            "Calculator",
            "Steam",
            "Microsoft Store",
            "Weather",
            "Calculator",
            "qBittorrent v4.3.5",
            "IcoFX",
            "c# - Setting the filter to an OpenFileDialog to allow the typical image formats? " +
                "- Stack Overflow - Brave",
            "Microsoft Text Input Application",
            "Settings",
            "Calculator",
            "Steam",
            "Microsoft Store",
            "Weather",
            "Calculator",
            "qBittorrent v4.3.5",
            "IcoFX",
            "c# - Setting the filter to an OpenFileDialog to allow the typical image formats? " +
                "- Stack Overflow - Brave",
            "Microsoft Text Input Application",
            "Settings",
            "Calculator",
            "Steam",
            "Microsoft Store",
            "Weather",
            "Calculator",
            "qBittorrent v4.3.5",
            "Crosshair+ - Microsoft Visual Studio",
            "Microsoft Text Input Application",
            "Settings",
            "Calculator",
            "Steam",
            "Microsoft Store",
            "Weather",
            "Calculator",
            "qBittorrent v4.3.5",
            "Crosshair+ - Microsoft Visual Studio",
            "Microsoft Text Input Application",
            "Settings",
            "Calculator",
            "Steam",
            "Microsoft Store",
            "Weather",
            "Calculator",
            "qBittorrent v4.3.5",
            "Crosshair+ - Microsoft Visual Studio",
            "Microsoft Text Input Application",
            "Settings",
            "Calculator",
            "Steam",
            "Microsoft Store",
            "Weather",
            "Calculator",
            "qBittorrent v4.3.5",
            "Crosshair+ - Microsoft Visual Studio",
            "Microsoft Text Input Application",
            "Weather",
            "Settings",
            "Microsoft Store",
            "Calculator",
            "Project Ideas.txt - Notepad",
            "Weather",
            "A global Keyboard Hook that works in WPF and is also high CPU load proof. Credits" +
                ": http://blogs.vertigo.com/personal/ralph/Blog/Lists/Posts/Post.aspx?ID=8 · GitH" +
                "ub - Brave",
            "Microsoft Text Input Application",
            "Weather",
            "Settings",
            "Microsoft Store",
            "Calculator",
            "Project Ideas.txt - Notepad",
            "Weather",
            "Color Picker Combo Box - CodeProject - Brave",
            "Microsoft Text Input Application",
            "Weather",
            "Settings",
            "Microsoft Store",
            "Calculator",
            "Project Ideas.txt - Notepad",
            "Weather",
            "Color Picker Combo Box - CodeProject - Brave",
            "Microsoft Text Input Application",
            "Weather",
            "Settings",
            "Microsoft Store",
            "Calculator",
            "Project Ideas.txt - Notepad",
            "Weather",
            "Microsoft Text Input Application",
            "Weather",
            "Settings",
            "Microsoft Store",
            "Calculator",
            "Project Ideas.txt - Notepad",
            "Weather",
            "Microsoft Text Input Application",
            "Weather",
            "Settings",
            "Microsoft Store",
            "Calculator",
            "Project Ideas.txt - Notepad",
            "Weather",
            "Microsoft Text Input Application",
            "Weather",
            "Settings",
            "Microsoft Store",
            "Calculator",
            "Project Ideas.txt - Notepad",
            "Weather",
            "Microsoft Text Input Application",
            "Calculator",
            "Settings",
            "Microsoft Store",
            "Calculator",
            "Project Ideas.txt - Notepad",
            "Crosshair+ - Microsoft Visual Studio",
            "Microsoft Text Input Application",
            "Weather",
            "Settings",
            "Microsoft Store",
            "Calculator",
            "Crosshair+ - Microsoft Visual Studio",
            "Crosshair+ - Microsoft Visual Studio (Not Responding)",
            "Microsoft Text Input Application",
            "Settings",
            "Calculator",
            "Microsoft Store",
            "Calculator",
            "Gears 5",
            "Crosshair+ - Microsoft Visual Studio",
            "Settings",
            "Calculator",
            "Microsoft Store",
            "Microsoft Text Input Application",
            "DuckDuckGo — Privacy, simplified. - Brave",
            "Untitled - Notepad",
            "Calculator",
            "Settings",
            "Calculator",
            "Microsoft Store",
            "Microsoft Text Input Application",
            "DuckDuckGo — Privacy, simplified. - Brave",
            "Untitled - Notepad",
            "Calculator",
            "Settings",
            "Calculator",
            "Microsoft Store",
            "Microsoft Text Input Application",
            "DuckDuckGo — Privacy, simplified. - Brave",
            "Untitled - Notepad",
            "Calculator",
            "Settings",
            "Calculator",
            "Microsoft Store",
            "Microsoft Text Input Application",
            "DuckDuckGo — Privacy, simplified. - Brave",
            "Untitled - Notepad",
            "Calculator",
            "Microsoft Store",
            "Microsoft Store",
            "pinvoke.net: FindWindow (user32) - Brave",
            "Microsoft Text Input Application",
            "Windows Shell Experience Host",
            "Settings",
            "Microsoft Text Input Application",
            "vstudio commit github - Google Search - Brave",
            "Microsoft Store",
            "Settings",
            "Crosshair+ - Microsoft Visual Studio",
            "UniversalCrosshair - Microsoft Visual Studio",
            "Settings",
            "Microsoft Text Input Application",
            "Profiles | ReSharper - Brave",
            "Microsoft Store",
            "UniversalCrosshair - Microsoft Visual Studio",
            "Settings",
            "Settings",
            "Microsoft Text Input Application",
            "Profiles | ReSharper - Brave",
            "Microsoft Store",
            "UniversalCrosshair - Microsoft Visual Studio",
            "Settings",
            "Settings",
            "Microsoft Text Input Application",
            "Profiles | ReSharper - Brave",
            "Microsoft Store",
            "UniversalCrosshair - Microsoft Visual Studio",
            "Settings",
            "Settings",
            "Microsoft Text Input Application",
            "# DirectX Custom Crosshair Tutorial - YouTube - Brave",
            "Microsoft Store",
            "UniversalCrosshair - Microsoft Visual Studio",
            "Settings",
            "Settings",
            "Microsoft Text Input Application",
            "# DirectX Custom Crosshair Tutorial - YouTube - Brave",
            "Microsoft Store",
            "UniversalCrosshair - Microsoft Visual Studio",
            "Settings",
            "Settings",
            "Microsoft Text Input Application",
            "iconfiy - Google Search - Brave",
            "Microsoft Store",
            "UniversalCrosshair - Microsoft Visual Studio",
            "Settings",
            "Settings",
            "Microsoft Text Input Application",
            "iconfiy - Google Search - Brave",
            "Microsoft Store",
            "UniversalCrosshair - Microsoft Visual Studio",
            "Settings",
            "Settings",
            "Microsoft Text Input Application",
            "c# - Open a folder using Process.Start - Stack Overflow - Brave",
            "Microsoft Store",
            "UniversalCrosshair - Microsoft Visual Studio",
            "Settings",
            "Crosshair+",
            "Settings",
            "Microsoft Text Input Application",
            "C# .net get process location by name - Google Search - Brave",
            "Microsoft Store",
            "UniversalCrosshair - Microsoft Visual Studio",
            "Settings",
            "Settings",
            "Microsoft Text Input Application",
            "C# .net get process location by name - Google Search - Brave",
            "Microsoft Store",
            "UniversalCrosshair - Microsoft Visual Studio",
            "Settings",
            "Settings",
            "Microsoft Text Input Application",
            "C# .net get process location by name - Google Search - Brave",
            "Microsoft Store",
            "UniversalCrosshair - Microsoft Visual Studio",
            "Settings"});
            this.PCB_Window.Location = new System.Drawing.Point(44, 30);
            this.PCB_Window.Name = "PCB_Window";
            this.PCB_Window.Size = new System.Drawing.Size(393, 32);
            this.PCB_Window.TabIndex = 4;
            this.PCB_Window.SelectedIndexChanged += new System.EventHandler(this.PCMList_SelectedIndexChanged);
            // 
            // PB_WindowImage
            // 
            this.PB_WindowImage.Location = new System.Drawing.Point(6, 30);
            this.PB_WindowImage.Name = "PB_WindowImage";
            this.PB_WindowImage.Size = new System.Drawing.Size(33, 40);
            this.PB_WindowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_WindowImage.TabIndex = 3;
            this.PB_WindowImage.TabStop = false;
            // 
            // P_ProcessWindowInformation
            // 
            this.P_ProcessWindowInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_ProcessWindowInformation.Location = new System.Drawing.Point(4, 5);
            this.P_ProcessWindowInformation.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.P_ProcessWindowInformation.Name = "P_ProcessWindowInformation";
            this.P_ProcessWindowInformation.Size = new System.Drawing.Size(427, 329);
            this.P_ProcessWindowInformation.TabIndex = 6;
            // 
            // SS_Main
            // 
            this.SS_Main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.SS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_Status,
            this.TSSL_Spring0,
            this.TSSL_Version});
            this.SS_Main.Location = new System.Drawing.Point(0, 603);
            this.SS_Main.Name = "SS_Main";
            this.SS_Main.Size = new System.Drawing.Size(477, 32);
            this.SS_Main.SizingGrip = false;
            this.SS_Main.TabIndex = 4;
            this.SS_Main.Text = "statusStrip1";
            // 
            // TSSL_Status
            // 
            this.TSSL_Status.Name = "TSSL_Status";
            this.TSSL_Status.Size = new System.Drawing.Size(138, 25);
            this.TSSL_Status.Text = "Status: Disabled";
            // 
            // TSSL_Spring0
            // 
            this.TSSL_Spring0.Name = "TSSL_Spring0";
            this.TSSL_Spring0.Size = new System.Drawing.Size(189, 25);
            this.TSSL_Spring0.Spring = true;
            // 
            // TSSL_Version
            // 
            this.TSSL_Version.Name = "TSSL_Version";
            this.TSSL_Version.Size = new System.Drawing.Size(135, 25);
            this.TSSL_Version.Text = "Version: #.#.#.#";
            // 
            // B_HookToggle
            // 
            this.B_HookToggle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B_HookToggle.Location = new System.Drawing.Point(7, 35);
            this.B_HookToggle.Name = "B_HookToggle";
            this.B_HookToggle.Size = new System.Drawing.Size(429, 38);
            this.B_HookToggle.TabIndex = 5;
            this.B_HookToggle.Text = "Hook";
            this.B_HookToggle.UseVisualStyleBackColor = true;
            this.B_HookToggle.Click += new System.EventHandler(this.B_HookToggle_Click);
            // 
            // T_WindowTracker
            // 
            this.T_WindowTracker.Interval = 30;
            this.T_WindowTracker.Tick += new System.EventHandler(this.TWindowTracker_Tick);
            // 
            // TB_Main
            // 
            this.TB_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Main.Controls.Add(this.TP_ProcessInformation);
            this.TB_Main.Controls.Add(this.TP_Crosshair);
            this.TB_Main.Controls.Add(this.TP_Image);
            this.TB_Main.Controls.Add(this.TP_Options);
            this.TB_Main.Location = new System.Drawing.Point(17, 217);
            this.TB_Main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB_Main.Name = "TB_Main";
            this.TB_Main.SelectedIndex = 0;
            this.TB_Main.Size = new System.Drawing.Size(443, 377);
            this.TB_Main.TabIndex = 6;
            // 
            // TP_ProcessInformation
            // 
            this.TP_ProcessInformation.Controls.Add(this.P_ProcessWindowInformation);
            this.TP_ProcessInformation.Location = new System.Drawing.Point(4, 34);
            this.TP_ProcessInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TP_ProcessInformation.Name = "TP_ProcessInformation";
            this.TP_ProcessInformation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TP_ProcessInformation.Size = new System.Drawing.Size(435, 339);
            this.TP_ProcessInformation.TabIndex = 0;
            this.TP_ProcessInformation.Text = "Information";
            this.TP_ProcessInformation.UseVisualStyleBackColor = true;
            // 
            // TP_Crosshair
            // 
            this.TP_Crosshair.Controls.Add(this.P_CrosshairInformation);
            this.TP_Crosshair.Location = new System.Drawing.Point(4, 34);
            this.TP_Crosshair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TP_Crosshair.Name = "TP_Crosshair";
            this.TP_Crosshair.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TP_Crosshair.Size = new System.Drawing.Size(435, 339);
            this.TP_Crosshair.TabIndex = 1;
            this.TP_Crosshair.Text = "Crosshair";
            this.TP_Crosshair.UseVisualStyleBackColor = true;
            // 
            // P_CrosshairInformation
            // 
            this.P_CrosshairInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_CrosshairInformation.Location = new System.Drawing.Point(4, 5);
            this.P_CrosshairInformation.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.P_CrosshairInformation.Name = "P_CrosshairInformation";
            this.P_CrosshairInformation.Size = new System.Drawing.Size(427, 329);
            this.P_CrosshairInformation.TabIndex = 0;
            // 
            // TP_Image
            // 
            this.TP_Image.Controls.Add(this.P_CrosshairImage);
            this.TP_Image.Location = new System.Drawing.Point(4, 34);
            this.TP_Image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TP_Image.Name = "TP_Image";
            this.TP_Image.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TP_Image.Size = new System.Drawing.Size(435, 339);
            this.TP_Image.TabIndex = 2;
            this.TP_Image.Text = "Image";
            this.TP_Image.UseVisualStyleBackColor = true;
            // 
            // P_CrosshairImage
            // 
            this.P_CrosshairImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_CrosshairImage.Location = new System.Drawing.Point(4, 5);
            this.P_CrosshairImage.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.P_CrosshairImage.Name = "P_CrosshairImage";
            this.P_CrosshairImage.Size = new System.Drawing.Size(427, 329);
            this.P_CrosshairImage.TabIndex = 0;
            // 
            // TP_Options
            // 
            this.TP_Options.Controls.Add(this.P_CrosshairOptions);
            this.TP_Options.Location = new System.Drawing.Point(4, 34);
            this.TP_Options.Name = "TP_Options";
            this.TP_Options.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Options.Size = new System.Drawing.Size(435, 339);
            this.TP_Options.TabIndex = 3;
            this.TP_Options.Text = "Options";
            this.TP_Options.UseVisualStyleBackColor = true;
            // 
            // P_CrosshairOptions
            // 
            this.P_CrosshairOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_CrosshairOptions.Location = new System.Drawing.Point(3, 3);
            this.P_CrosshairOptions.Name = "P_CrosshairOptions";
            this.P_CrosshairOptions.Size = new System.Drawing.Size(429, 333);
            this.P_CrosshairOptions.TabIndex = 0;
            // 
            // GB_Hook
            // 
            this.GB_Hook.Controls.Add(this.B_HookToggle);
            this.GB_Hook.Location = new System.Drawing.Point(17, 110);
            this.GB_Hook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GB_Hook.Name = "GB_Hook";
            this.GB_Hook.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GB_Hook.Size = new System.Drawing.Size(444, 97);
            this.GB_Hook.TabIndex = 7;
            this.GB_Hook.TabStop = false;
            this.GB_Hook.Text = "Application";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 635);
            this.Controls.Add(this.GB_Hook);
            this.Controls.Add(this.TB_Main);
            this.Controls.Add(this.SS_Main);
            this.Controls.Add(this.GBWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Crosshair+";
            this.Load += new System.EventHandler(this.Main_Load);
            this.GBWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_WindowImage)).EndInit();
            this.SS_Main.ResumeLayout(false);
            this.SS_Main.PerformLayout();
            this.TB_Main.ResumeLayout(false);
            this.TP_ProcessInformation.ResumeLayout(false);
            this.TP_Crosshair.ResumeLayout(false);
            this.TP_Image.ResumeLayout(false);
            this.TP_Options.ResumeLayout(false);
            this.GB_Hook.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GBWindow;
        private System.Windows.Forms.PictureBox PB_WindowImage;
        private Controls.ProcessComboBox PCB_Window;
        private System.Windows.Forms.ToolTip TT_Main;
        private ProcessInformationPanel P_ProcessWindowInformation;
        private System.Windows.Forms.StatusStrip SS_Main;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Version;
        private System.Windows.Forms.Button B_HookToggle;
        private System.Windows.Forms.Timer T_WindowTracker;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Status;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Spring0;
        private System.Windows.Forms.TabControl TB_Main;
        private System.Windows.Forms.TabPage TP_ProcessInformation;
        private System.Windows.Forms.TabPage TP_Crosshair;
        private System.Windows.Forms.GroupBox GB_Hook;
        private System.Windows.Forms.TabPage TP_Image;
        private CrosshairImagePanel P_CrosshairImage;
        private CrosshairInformationPanel P_CrosshairInformation;
        private System.Windows.Forms.TabPage TP_Options;
        private CrosshairOptionsPanel P_CrosshairOptions;
    }
}

