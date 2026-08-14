using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

// Minimal BitBlt/Screen capture tool for Spike testing (Task 1)
// Usage: dotnet run --output ./capture.png

class Program
{
    static int Main(string[] args)
    {
        try
        {
            var output = "capture_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
            for (int i = 0; i < args.Length - 1; i++)
            {
                if (args[i] == "--output") { output = args[i + 1]; }
            }

            // Determine virtual screen bounds
            var left = SystemInformation.VirtualScreen.Left;
            var top = SystemInformation.VirtualScreen.Top;
            var width = SystemInformation.VirtualScreen.Width;
            var height = SystemInformation.VirtualScreen.Height;

            using (var bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb))
            {
                using (var g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(left, top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
                }

                var dir = Path.GetDirectoryName(output);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) Directory.CreateDirectory(dir);
                bmp.Save(output, ImageFormat.Png);
            }

            Console.WriteLine("Capture saved to: " + Path.GetFullPath(output));
            return 0;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Capture failed: " + ex.Message);
            Console.Error.WriteLine(ex.ToString());
            return 2;
        }
    }
}
