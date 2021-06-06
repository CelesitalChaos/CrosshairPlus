
namespace CrosshairPlus.ControlPanels
{
    partial class CrosshairOptionsPanel
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
            this.P_Main = new System.Windows.Forms.Panel();
            this.L_Render = new System.Windows.Forms.Label();
            this.CB_RenderModes = new System.Windows.Forms.ComboBox();
            this.L_HookKey = new System.Windows.Forms.Label();
            this.CB_Hotkey = new System.Windows.Forms.ComboBox();
            this.P_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_Main
            // 
            this.P_Main.AutoScroll = true;
            this.P_Main.Controls.Add(this.L_HookKey);
            this.P_Main.Controls.Add(this.CB_Hotkey);
            this.P_Main.Controls.Add(this.L_Render);
            this.P_Main.Controls.Add(this.CB_RenderModes);
            this.P_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_Main.Location = new System.Drawing.Point(0, 0);
            this.P_Main.Name = "P_Main";
            this.P_Main.Size = new System.Drawing.Size(285, 217);
            this.P_Main.TabIndex = 0;
            // 
            // L_Render
            // 
            this.L_Render.AutoSize = true;
            this.L_Render.Location = new System.Drawing.Point(14, 12);
            this.L_Render.Name = "L_Render";
            this.L_Render.Size = new System.Drawing.Size(71, 25);
            this.L_Render.TabIndex = 2;
            this.L_Render.Text = "Render:";
            // 
            // CB_RenderModes
            // 
            this.CB_RenderModes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_RenderModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_RenderModes.FormattingEnabled = true;
            this.CB_RenderModes.Location = new System.Drawing.Point(101, 9);
            this.CB_RenderModes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_RenderModes.Name = "CB_RenderModes";
            this.CB_RenderModes.Size = new System.Drawing.Size(172, 33);
            this.CB_RenderModes.TabIndex = 1;
            // 
            // L_HookKey
            // 
            this.L_HookKey.AutoSize = true;
            this.L_HookKey.Location = new System.Drawing.Point(14, 55);
            this.L_HookKey.Name = "L_HookKey";
            this.L_HookKey.Size = new System.Drawing.Size(73, 25);
            this.L_HookKey.TabIndex = 4;
            this.L_HookKey.Text = "Hotkey:";
            // 
            // CB_Hotkey
            // 
            this.CB_Hotkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Hotkey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Hotkey.FormattingEnabled = true;
            this.CB_Hotkey.Location = new System.Drawing.Point(101, 52);
            this.CB_Hotkey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_Hotkey.Name = "CB_Hotkey";
            this.CB_Hotkey.Size = new System.Drawing.Size(172, 33);
            this.CB_Hotkey.TabIndex = 3;
            // 
            // CrosshairOptionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.P_Main);
            this.Name = "CrosshairOptionsPanel";
            this.Size = new System.Drawing.Size(285, 217);
            this.Load += new System.EventHandler(this.CrosshairOptionsPanel_Load);
            this.P_Main.ResumeLayout(false);
            this.P_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_Main;
        private System.Windows.Forms.Label L_Render;
        public System.Windows.Forms.ComboBox CB_RenderModes;
        private System.Windows.Forms.Label L_HookKey;
        public System.Windows.Forms.ComboBox CB_Hotkey;
    }
}
