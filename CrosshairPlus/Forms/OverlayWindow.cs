#region Namespaces

using System;
using System.Drawing;
using System.Windows.Forms;
using CrosshairPlus.PInvoke;

#endregion

namespace CrosshairPlus.Forms
{
    public partial class OverlayWindow : Form
    {
        public OverlayWindow()
        {
            InitializeComponent();

            // Making it transparent
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void OverlayWindow_Load(object sender, EventArgs e)
        {
            BackColor = Color.Wheat;
            TransparencyKey = Color.Wheat;

            // Making it un-click able
            var initialStyle = User32.GetWindowLong(Handle, -20);
            User32.SetWindowLong(Handle, -20, initialStyle | 0x80000 | 0x20);
        }

        private void OverlayWindow_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}