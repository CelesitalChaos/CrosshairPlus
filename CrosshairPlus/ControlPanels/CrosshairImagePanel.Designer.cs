
namespace CrosshairPlus.ControlPanels
{
    partial class CrosshairImagePanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrosshairImagePanel));
            this.P_Main = new System.Windows.Forms.Panel();
            this.GB_Size = new System.Windows.Forms.GroupBox();
            this.L_Width = new System.Windows.Forms.Label();
            this.L_Height = new System.Windows.Forms.Label();
            this.NUD_Height = new System.Windows.Forms.NumericUpDown();
            this.NUD_Width = new System.Windows.Forms.NumericUpDown();
            this.LPath = new System.Windows.Forms.Label();
            this.TB_Path = new System.Windows.Forms.TextBox();
            this.B_Open = new System.Windows.Forms.Button();
            this.PB_CrosshairImage = new System.Windows.Forms.PictureBox();
            this.TT_Main = new System.Windows.Forms.ToolTip(this.components);
            this.P_Main.SuspendLayout();
            this.GB_Size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CrosshairImage)).BeginInit();
            this.SuspendLayout();
            // 
            // P_Main
            // 
            this.P_Main.AutoScroll = true;
            this.P_Main.Controls.Add(this.GB_Size);
            this.P_Main.Controls.Add(this.LPath);
            this.P_Main.Controls.Add(this.TB_Path);
            this.P_Main.Controls.Add(this.B_Open);
            this.P_Main.Controls.Add(this.PB_CrosshairImage);
            this.P_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Main.Location = new System.Drawing.Point(0, 0);
            this.P_Main.Name = "P_Main";
            this.P_Main.Size = new System.Drawing.Size(213, 270);
            this.P_Main.TabIndex = 0;
            // 
            // GB_Size
            // 
            this.GB_Size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Size.Controls.Add(this.L_Width);
            this.GB_Size.Controls.Add(this.L_Height);
            this.GB_Size.Controls.Add(this.NUD_Height);
            this.GB_Size.Controls.Add(this.NUD_Width);
            this.GB_Size.Location = new System.Drawing.Point(10, 48);
            this.GB_Size.Name = "GB_Size";
            this.GB_Size.Size = new System.Drawing.Size(194, 84);
            this.GB_Size.TabIndex = 19;
            this.GB_Size.TabStop = false;
            this.GB_Size.Text = "Size";
            // 
            // L_Width
            // 
            this.L_Width.AutoSize = true;
            this.L_Width.Location = new System.Drawing.Point(6, 53);
            this.L_Width.Name = "L_Width";
            this.L_Width.Size = new System.Drawing.Size(42, 15);
            this.L_Width.TabIndex = 17;
            this.L_Width.Text = "Width:";
            // 
            // L_Height
            // 
            this.L_Height.AutoSize = true;
            this.L_Height.Location = new System.Drawing.Point(6, 25);
            this.L_Height.Name = "L_Height";
            this.L_Height.Size = new System.Drawing.Size(46, 15);
            this.L_Height.TabIndex = 18;
            this.L_Height.Text = "Height:";
            // 
            // NUD_Height
            // 
            this.NUD_Height.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Height.Location = new System.Drawing.Point(58, 22);
            this.NUD_Height.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUD_Height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Height.Name = "NUD_Height";
            this.NUD_Height.ReadOnly = true;
            this.NUD_Height.Size = new System.Drawing.Size(130, 23);
            this.NUD_Height.TabIndex = 16;
            this.NUD_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Height.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // NUD_Width
            // 
            this.NUD_Width.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_Width.Location = new System.Drawing.Point(58, 51);
            this.NUD_Width.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NUD_Width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Width.Name = "NUD_Width";
            this.NUD_Width.ReadOnly = true;
            this.NUD_Width.Size = new System.Drawing.Size(130, 23);
            this.NUD_Width.TabIndex = 15;
            this.NUD_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Width.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // LPath
            // 
            this.LPath.AutoSize = true;
            this.LPath.Location = new System.Drawing.Point(47, 4);
            this.LPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LPath.Name = "LPath";
            this.LPath.Size = new System.Drawing.Size(34, 15);
            this.LPath.TabIndex = 13;
            this.LPath.Text = "Path:";
            // 
            // TB_Path
            // 
            this.TB_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Path.Location = new System.Drawing.Point(47, 19);
            this.TB_Path.Margin = new System.Windows.Forms.Padding(2);
            this.TB_Path.Name = "TB_Path";
            this.TB_Path.ReadOnly = true;
            this.TB_Path.Size = new System.Drawing.Size(129, 23);
            this.TB_Path.TabIndex = 14;
            this.TB_Path.Text = "Default-32x32.png";
            // 
            // B_Open
            // 
            this.B_Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Open.BackColor = System.Drawing.Color.Transparent;
            this.B_Open.BackgroundImage = global::CrosshairPlus.Properties.Resources.BrowseFolder;
            this.B_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Open.Location = new System.Drawing.Point(180, 18);
            this.B_Open.Margin = new System.Windows.Forms.Padding(2);
            this.B_Open.Name = "B_Open";
            this.B_Open.Size = new System.Drawing.Size(24, 23);
            this.B_Open.TabIndex = 12;
            this.TT_Main.SetToolTip(this.B_Open, "Open Image File...");
            this.B_Open.UseVisualStyleBackColor = false;
            this.B_Open.Click += new System.EventHandler(this.B_Open_Click);
            // 
            // PB_CrosshairImage
            // 
            this.PB_CrosshairImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_CrosshairImage.Image = ((System.Drawing.Image)(resources.GetObject("PB_CrosshairImage.Image")));
            this.PB_CrosshairImage.Location = new System.Drawing.Point(10, 10);
            this.PB_CrosshairImage.Name = "PB_CrosshairImage";
            this.PB_CrosshairImage.Size = new System.Drawing.Size(32, 32);
            this.PB_CrosshairImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_CrosshairImage.TabIndex = 0;
            this.PB_CrosshairImage.TabStop = false;
            // 
            // CrosshairImagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.P_Main);
            this.Name = "CrosshairImagePanel";
            this.Size = new System.Drawing.Size(213, 270);
            this.P_Main.ResumeLayout(false);
            this.P_Main.PerformLayout();
            this.GB_Size.ResumeLayout(false);
            this.GB_Size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CrosshairImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_Main;
        private System.Windows.Forms.Button B_Open;
        private System.Windows.Forms.Label LPath;
        private System.Windows.Forms.TextBox TBPath;
        private System.Windows.Forms.ToolTip TT_Main;
        private System.Windows.Forms.GroupBox GB_Size;
        private System.Windows.Forms.Label L_Width;
        private System.Windows.Forms.Label L_Height;
        public System.Windows.Forms.PictureBox PB_CrosshairImage;
        public System.Windows.Forms.TextBox TB_Path;
        public System.Windows.Forms.NumericUpDown NUD_Height;
        public System.Windows.Forms.NumericUpDown NUD_Width;
    }
}
