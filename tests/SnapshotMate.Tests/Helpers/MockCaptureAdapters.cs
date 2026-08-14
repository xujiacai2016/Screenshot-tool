using System;

namespace SnapshotMate.Tests.MockCaptureAdapters
{
    public class MockAdapterThrowing : ICaptureAdapter
    {
        public CaptureResult Capture(WindowDescriptor window)
        {
            throw new InvalidOperationException("simulated adapter failure");
        }
    }

    public class MockAdapterSuccess : ICaptureAdapter
    {
        public CaptureResult Capture(WindowDescriptor window)
        {
            return new CaptureResult { Success = true, ErrorCode = ErrorCode.OK, FilePath = "mock.png" };
        }
    }
}
