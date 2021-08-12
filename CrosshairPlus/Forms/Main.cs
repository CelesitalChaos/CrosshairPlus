#region Namespaces

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using CrosshairPlus.Models;
using CrosshairPlus.PInvoke;

#endregion

namespace CrosshairPlus.Forms
{
    /// <summary>
    ///     The main form.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Main : Form
    {
        //private readonly Keys _hookKey;
        private readonly OverlayWindow _overlayWindow;

        public Main()
        {
            InitializeComponent();

            TSSL_Version.Text = $@"Version: {Application.ProductVersion}";

            // Create overlay window
            _overlayWindow = new OverlayWindow();

            // Hook keyboard
            var keyboardHook = new KeyboardHook();
            keyboardHook.KeyDown += OnHookKeyDown;

            GB_Hook.Text = @"Application";
        }

        public void ShowHelp()
        {
            var messageText =
                "If the crosshair does not initially appear in-game, try running your game in Borderless or Fullscreen Windowed mode.";

            MessageBox.Show(messageText, Application.ProductName, MessageBoxButtons.OK);
        }

        private void OnHookKeyDown(object sender, HookEventArgs e)
        {
            Debug.WriteLine("The Key: " + e.Key);

            var keysConverter = new KeysConverter();
            var invariantString = keysConverter.ConvertFromInvariantString(P_CrosshairOptions.CB_Hotkey.Text);

            if (invariantString != null)
            {
                var key = (Keys) invariantString;

                // Makes sure a key is set
                if (key != Keys.None)
                {
                    if (e.Key == key) ToggleHook();
                }
                else
                {
                    Console.WriteLine(@"No special hot-key has been set or registered.");
                }
            }
        }


        private void ToggleHook()
        {
            B_HookToggle.PerformClick();
        }


        private void RefreshProcesses()
        {
            PCB_Window.RefreshProcesses();
            GBWindow.Text = $@"Window ({PCB_Window.Items.Count})";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshProcesses();
        }


        /// <summary>
        ///     Handles the SelectedIndexChanged event of the PCMList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void PCMList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load window icon
            PB_WindowImage.Image = PCB_Window.SelectedProcessItem.Icon;
            P_ProcessWindowInformation.LoadProcessInformation(PCB_Window.SelectedProcessItem);
        }

        /// <summary>
        ///     Handles the Click event of the B_HookToggle control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void B_HookToggle_Click(object sender, EventArgs e)
        {
            // FIX: Overlay window toggle from being pressed twice at start.
            _overlayWindow.Show();
            _overlayWindow.Hide();

            switch (B_HookToggle.Text)
            {
                case @"Hook":
                {
                    B_HookToggle.Text = @"Un-Hook";
                    P_CrosshairInformation.Enabled = false;
                    P_CrosshairImage.Enabled = false;
                    PCB_Window.Enabled = false;
                    P_CrosshairOptions.Enabled = false;

                    if (PCB_Window.SelectedIndex > -1)
                    {
                        T_WindowTracker.Start();

                        _overlayWindow.Show();

                        // Draw on the overlay window

                        // Create graphics
                        var crosshairGraphics = _overlayWindow.CreateGraphics();

                        // Get the center of the overlay form
                        var centerHeight = _overlayWindow.Size.Height / 2.0f +
                                           (float) SystemInformation.CaptionHeight / 2;
                        var centerWidth = _overlayWindow.Size.Width / 2.0f;

                        // Switch to determine drawing crosshair or image

                        if (P_CrosshairOptions.CB_RenderModes.Text == RenderMode.Default.ToString())
                        {
                            // Adjust crosshair size
                            var crosshairSize = Convert.ToInt32(P_CrosshairInformation.NUD_Length.Value);

                            var thickness = Convert.ToInt32(P_CrosshairInformation.NUD_Width.Value);
                            // Draw crosshair inside graphics

                            // Create crosshair pen stroke
                            var centerBrush = new SolidBrush(Color.FromName(P_CrosshairInformation.CCB_Center.Text));
                            var lineBrush = new Pen(Color.FromName(P_CrosshairInformation.CCB_Line.Text), thickness);

                            // Draw center dot
                            var centerDotSize = Convert.ToInt32(P_CrosshairInformation.NUD_Size.Value);
                            crosshairGraphics.FillEllipse(centerBrush,
                                new Rectangle((int) centerWidth - centerDotSize / 2,
                                    (int) centerHeight - centerDotSize / 2, centerDotSize, centerDotSize));

                            var lineSpacing = Convert.ToInt32(P_CrosshairInformation.NUD_Spacing.Value);

                            // Top line
                            crosshairGraphics.DrawLine(lineBrush,
                                new Point((int) centerWidth, (int) centerHeight - lineSpacing),
                                new Point((int) centerWidth, (int) centerHeight - lineSpacing - crosshairSize));

                            // Bottom line
                            crosshairGraphics.DrawLine(lineBrush,
                                new Point((int) centerWidth, (int) centerHeight + lineSpacing),
                                new Point((int) centerWidth, (int) centerHeight + lineSpacing + crosshairSize));

                            // Left line
                            crosshairGraphics.DrawLine(lineBrush,
                                new Point((int) centerWidth - lineSpacing, (int) centerHeight),
                                new Point((int) centerWidth - lineSpacing - crosshairSize, (int) centerHeight));

                            // Right line
                            crosshairGraphics.DrawLine(lineBrush,
                                new Point((int) centerWidth + lineSpacing, (int) centerHeight),
                                new Point((int) centerWidth + lineSpacing + crosshairSize, (int) centerHeight));
                        }
                        else if (P_CrosshairOptions.CB_RenderModes.Text == RenderMode.Image.ToString())
                        {
                            // Draw crosshair image using custom size
                            crosshairGraphics.DrawImage(P_CrosshairImage.PB_CrosshairImage.Image,
                                new PointF(centerWidth - (float) P_CrosshairImage.PB_CrosshairImage.Image.Width / 2,
                                    centerHeight - (float) P_CrosshairImage.PB_CrosshairImage.Image.Height / 2));
                        }


                        _overlayWindow.Opacity = Convert.ToDouble(P_CrosshairInformation.NUD_Opacity.Value / 10);
                        _overlayWindow.Show();
                        TSSL_Status.Text = @"Status: Enabled";
                    }
                    else
                    {
                        Console.WriteLine(@"Choose an item.");
                    }

                    break;
                }
                default:
                    B_HookToggle.Text = @"Hook";
                    TSSL_Status.Text = @"Status: Disabled";

                    _overlayWindow.Hide();
                    T_WindowTracker.Stop();

                    P_CrosshairInformation.Enabled = true;
                    P_CrosshairImage.Enabled = true;
                    PCB_Window.Enabled = true;
                    P_CrosshairOptions.Enabled = true;
                    break;
            }
        }

        /// <summary>
        ///     Updates the window tracking.
        /// </summary>
        private void UpdateWindowTracking()
        {
            // Center overlay window width and height with the location
            _overlayWindow.Location = PCB_Window.SelectedProcessItem.WindowRectangle.Location;

            // Update the size to the process window handle
            _overlayWindow.Size = PCB_Window.SelectedProcessItem.WindowRectangle.Size;
        }

        /// <summary>
        ///     Handles the Tick event of the TWindowTracker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void TWindowTracker_Tick(object sender, EventArgs e)
        {
            // If process closed stop tracking
            if (PCB_Window.SelectedProcessItem.Process.HasExited) B_HookToggle.PerformClick();

            // Refresh crosshair position
            UpdateWindowTracking();
        }
    }
}