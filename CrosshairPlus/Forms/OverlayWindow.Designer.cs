﻿
namespace CrosshairPlus.Forms
{
    partial class OverlayWindow
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
            this.SuspendLayout();
            // 
            // OverlayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OverlayWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Overlay Window";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OverlayWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OverlayWindow_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}