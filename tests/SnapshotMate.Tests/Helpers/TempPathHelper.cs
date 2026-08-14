using System;
using System.IO;
using System.Text;

namespace SnapshotMate.Tests
{
    public static class TempPathHelper
    {
        public static string GetWritableTempPath()
        {
            var dir = Path.Combine(Path.GetTempPath(), "snapshotmate_tests", Guid.NewGuid().ToString());
            Directory.CreateDirectory(dir);
            return Path.Combine(dir, "out.png");
        }

        public static string GetReadOnlyPath()
        {
            // simulate by returning path string that TestHelpers treats as readonly
            var dir = Path.Combine(Path.GetTempPath(), "readonly_dir");
            return Path.Combine(dir, "file.png");
        }

        public static string GetTempFile()
        {
            var p = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".json");
            return p;
        }

        public static string GetReadOnlyDir()
        {
            return Path.Combine(Path.GetTempPath(), "readonly_dir");
        }
    }
}
