using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace SnapshotMate.Tests.UnitTests
{
    [TestFixture]
    public class CoreUnitTests
    {
        // NOTE: These tests are templates (Arrange / Act / Assert).
        // Replace helper method stubs with real implementations or mocks.

        [Test]
        public void U01_ConvertToPhysicalPixels_ScalesCorrectly()
        {
            // GIVEN
            var dpiScale = 1.5;
            var rect = new Rect(100, 100, 800, 600);

            // WHEN
            var physical = TestHelpers.ConvertToPhysicalPixels(rect, dpiScale);

            // THEN
            Assert.AreEqual(150, physical.X);
            Assert.AreEqual(150, physical.Y);
            Assert.AreEqual(1200, physical.Width);
            Assert.AreEqual(900, physical.Height);
        }

        [Test]
        public void U06_ComputeStride_ZeroOrNegative_Throws()
        {
            // GIVEN/WHEN/THEN
            Assert.Throws<ArgumentException>(() => TestHelpers.ComputeStride(500, 500));
        }

        [Test]
        public void U12_ValidateAndPrepareSavePath_ReturnsErrorForReadOnly()
        {
            var path = TempPathHelper.GetReadOnlyPath();
            var res = TestHelpers.ValidateAndPrepareSavePath(path);
            Assert.IsFalse(res.Success);
            Assert.AreEqual(ErrorCode.PATH_NOT_WRITABLE, res.ErrorCode);
            Assert.IsNotNull(res.SuggestedFallbackPath);
        }

        [Test]
        public void U15_HotkeyHandler_Debounces()
        {
            var now = DateTime.UtcNow;
            var times = new DateTime[] {
                now,
                now.AddMilliseconds(50),
                now.AddMilliseconds(100)
            };

            var executed = TestHelpers.HotkeyHandler_CountExecutions(times, debounceMs: 200);
            Assert.AreEqual(1, executed);
        }

        [Test]
        public void U19_CaptureEngine_HandlesAdapterException()
        {
            var adapter = new MockCaptureAdapters.MockAdapterThrowing();
            var window = new WindowDescriptor("fake-window");
            var result = TestHelpers.CaptureEngine_CaptureWindow(adapter, window);
            Assert.IsFalse(result.Success);
            Assert.AreEqual(ErrorCode.CAPTURE_DXGI_ERROR, result.ErrorCode);
        }

        // Add additional unit test templates (U02..U20) as needed following same pattern
    }
}
