# Spike BitBlt Capture Tool

这是用于 DXGI/BitBlt Spike 的最小可用控制台工具，放在 spike/BitBltCapture。工具使用 Graphics.CopyFromScreen（基于 GDI）进行全屏捕获并保存为 PNG。

如何使用：
1. 在 Windows 测试机上打开命令行并进入 spike/BitBltCapture 目录
2. 运行： dotnet run --output ./capture.png
3. 检查是否生成 capture.png 并验证截图内容

注意：
- 该工具仅作为 Spike 使用，旨在验证 BitBlt（GDI）在目标环境的可用性。它不是最终产品的 CaptureEngine 实现。
- 不要在沙箱或受限环境运行（可能无法访问屏幕像素）。
