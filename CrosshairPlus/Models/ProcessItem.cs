#region Namespaces

using System;
using System.Diagnostics;
using System.Drawing;
using CrosshairPlus.PInvoke;

#endregion

namespace CrosshairPlus.Models
{
    /// <summary>
    ///     The process item.
    /// </summary>
    public class ProcessItem
    {
        public ProcessItem(Process process)
        {
            Process = null;
            if (process != null)
            {
                Process = process;
                ProcessId = process.Id.ToString();
                ProcessName = process.ProcessName;
                WindowTitle = process.MainWindowTitle;

                try
                {
                    Location = Process.MainModule?.FileName;                
                }
                catch (Exception e)
                {
                    if (e is System.ComponentModel.Win32Exception)
                    {
                        Console.WriteLine(nameof(System.ComponentModel.Win32Exception) + " - " +  e.Message);
                    }
                    else
                    {
                        Console.WriteLine(e);
                    }                                       
                }

                if (string.IsNullOrEmpty(Location))
                {
                    Location = Process.StartInfo.FileName;
                }
            }
        }

        public Process Process { get; }
        public string Location { get; }
        public string ProcessId { get; }
        public string ProcessName { get; }
        public string WindowTitle { get; }

        public Rectangle WindowRectangle
        {
            get
            {
                var rect = new Rectangle();

                if (!string.IsNullOrEmpty(WindowTitle))
                {
                    var handle = User32.GetWindowHandle(WindowTitle);
                    var windowPosition = User32.GetWindowRect(handle);

                    rect = new Rectangle(new Point(windowPosition.X, windowPosition.Y),
                        new Size(windowPosition.Width, windowPosition.Height));
                }

                return rect;
            }
        }


        public Image Icon
        {
            get
            {
                Image processIcon = new Bitmap(1, 1);

                if (!string.IsNullOrEmpty(Location))
                    try
                    {
                        var ico = System.Drawing.Icon.ExtractAssociatedIcon(Location);
                        if (ico != null) processIcon = ico.ToBitmap();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                return processIcon;
            }
        }
    }
}