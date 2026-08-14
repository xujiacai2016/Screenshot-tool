using NUnit.Framework;

namespace SnapshotMate.Tests.UAT
{
    [TestFixture]
    [Category("UAT")]
    public class UatTests
    {
        // These tests are intended for manual/semi-automated execution.
        // Marked Explicit to avoid running in CI accidentally.

        [Test, Explicit]
        public void UAT01_QuickFreeRectCaptureAndAnnotate()
        {
            /*
             GIVEN: any desktop with content
             WHEN: user triggers hotkey -> draws rect -> release -> annotate -> save -> copy to clipboard -> paste in Teams
             THEN: pasted image contains annotations; saved file exists and opens
             */
            Assert.Pass("Manual: follow UAT checklist and record outcomes in experiment_results.csv");
        }

        [Test, Explicit]
        public void UAT04_HighDPI_DualMonitor()
        {
            Assert.Pass("Manual verification required: run on dual-monitor high DPI setup.");
        }
    }
}
