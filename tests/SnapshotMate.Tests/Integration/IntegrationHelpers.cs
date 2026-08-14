using System;
using System.IO;

namespace SnapshotMate.Tests.Integration
{
    public static class IntegrationHelpers
    {
        public static bool EnvIsReady()
        {
            // Implement environment checks - Office/Teams/Chrome presence
            return true;
        }

        public static bool IsAppAvailable() => EnvIsReady();

        public static string OutputDir => Path.Combine(Path.GetTempPath(), "snapshotmate_integration");

        public static dynamic TriggerHotkeyAndDrawRect()
        {
            // Placeholder: launch overlay and simulate draw
            return new { FilePath = Path.Combine(OutputDir, "sample.png") };
        }

        public static dynamic ExportFromAnnotator(object overlay, string outputDir)
        {
            Directory.CreateDirectory(outputDir);
            var outPath = Path.Combine(outputDir, "annotated.png");
            File.WriteAllText(outPath, "dummy");
            return new { FilePath = outPath };
        }

        public static bool ClipboardContainsImage()
        {
            // Placeholder: in real integration check clipboard
            return true;
        }

        public static ICaptureAdapter CreateCaptureEngineWithMockAdapters(bool failPrimary)
        {
            if (failPrimary) return new MockCaptureAdapters.MockAdapterSuccess();
            return new MockCaptureAdapters.MockAdapterSuccess();
        }

        public static WindowDescriptor GetTestWindow() => new WindowDescriptor("TestWindow");
    }
}
