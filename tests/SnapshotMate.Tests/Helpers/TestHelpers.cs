using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace SnapshotMate.Tests
{
    // Minimal helper placeholders.
    // Replace with real logic or mocks in tests.

    public static class TestHelpers
    {
        public static Rect ConvertToPhysicalPixels(Rect r, double dpiScale)
        {
            // Simple rounding policy: Math.Round
            return new Rect(
                (int)Math.Round(r.X * dpiScale),
                (int)Math.Round(r.Y * dpiScale),
                (int)Math.Round(r.Width * dpiScale),
                (int)Math.Round(r.Height * dpiScale)
            );
        }

        public static int ComputeStride(int visibleHeight, int overlap)
        {
            var stride = visibleHeight - overlap;
            if (stride <= 0) throw new ArgumentException("invalid overlap >= visibleHeight");
            return stride;
        }

        public static (bool Success, ErrorCode ErrorCode, string SuggestedFallbackPath, string Path) ValidateAndPrepareSavePath(string path)
        {
            // Placeholder: simulate read-only for paths containing "readonly"
            if (path.Contains("readonly")) return (false, ErrorCode.PATH_NOT_WRITABLE, Path.GetTempPath(), path);
            Directory.CreateDirectory(Path.GetDirectoryName(path) ?? Path.GetTempPath());
            return (true, ErrorCode.OK, null, path);
        }

        public static int HotkeyHandler_CountExecutions(DateTime[] eventTimes, int debounceMs)
        {
            int executed = 0;
            DateTime? last = null;
            foreach (var t in eventTimes)
            {
                if (last == null || (t - last.Value).TotalMilliseconds > debounceMs)
                {
                    executed++;
                    last = t;
                }
            }
            return executed;
        }

        public static CaptureResult CaptureEngine_CaptureWindow(ICaptureAdapter adapter, WindowDescriptor window)
        {
            try
            {
                return adapter.Capture(window);
            }
            catch
            {
                return new CaptureResult { Success = false, ErrorCode = ErrorCode.CAPTURE_DXGI_ERROR };
            }
        }
    }
}
