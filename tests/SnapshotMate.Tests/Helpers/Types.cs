using System;

namespace SnapshotMate.Tests
{
    // Lightweight domain types used by tests as placeholders.
    public record Rect(int X, int Y, int Width, int Height);
    public record Point(int X, int Y);
    public record WindowDescriptor(string Name);
    public record CaptureResult { public bool Success { get; init; } public ErrorCode ErrorCode { get; init; } public string FilePath { get; init; } }
    public enum ErrorCode { OK=0, CAPTURE_DXGI_ERROR=1, BITBLT_FAIL=2, UIA_NOT_AVAILABLE=3, STABILITY_FAIL=4, IO_ERROR=5, PATH_NOT_WRITABLE=6, OOM=7, TOO_MANY_SEGMENTS=8 }
    public interface ICaptureAdapter { CaptureResult Capture(WindowDescriptor window); }
}
