using NUnit.Framework;
using System.IO;
using System.Threading.Tasks;

namespace SnapshotMate.Tests.Integration
{
    [TestFixture]
    [Category("Integration")]
    public class IntegrationTests
    {
        // Important: These tests require a configured test machine with Office/Teams/Chrome/Edge.
        // Use Assume.That(...) to skip tests if environment not ready.

        [Test]
        public void I01_BasicFlow_FreeRectToSaveAndClipboard()
        {
            Assume.That(Env.IsAppAvailable(), "App not available in this environment");

            var overlay = IntegrationHelpers.TriggerHotkeyAndDrawRect();
            var annotated = IntegrationHelpers.ExportFromAnnotator(overlay, IntegrationPaths.OutputDir);

            Assert.IsTrue(File.Exists(annotated.FilePath));
            Assert.IsTrue(IntegrationHelpers.ClipboardContainsImage());
        }

        [Test]
        public void I03_CaptureEngine_UsesFallback_WhenDXGIFails()
        {
            var engine = IntegrationHelpers.CreateCaptureEngineWithMockAdapters(failPrimary:true);
            var window = IntegrationHelpers.GetTestWindow();
            var res = engine.CaptureWindow(window);
            Assert.IsTrue(res.Success || res.ErrorCode == ErrorCode.BITBLT_OK);
        }

        // Additional integration tests (I04..I18) are included as templates in IntegrationHelpers
    }
}
