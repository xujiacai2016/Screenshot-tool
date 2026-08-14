# Spike DXGI/BitBlt 测试计划

目标：在 3 台不同配置的测试机上，运行位于 spike/BitBltCapture 的捕获工具，记录 BitBlt 能否在目标环境下成功捕获屏幕或窗口。

前置条件：
- 测试机安装 .NET SDK (建议 7.0)
- 在测试机上有权限运行桌面捕获（非沙箱环境）

测试步骤（每台机器执行）：
1. 克隆仓库并切换到分支 feature/implement-task-1（或直接使用主分支）
2. 进入 spike/BitBltCapture 目录
3. 运行 dotnet run --output capture_full.png
4. 检查 capture_full.png 是否生成且可打开，截图内容是否正确
5. 针对具体应用窗口可传递窗口 title 进行捕获（若可用），记录结果
6. 把结果填写到 docs/spike/dxgi_compat_report.md

预期结果：
- 若 BitBlt 在目标机上成功生成 PNG 且图像内容正常，则标记 BitBlt 可用
- 若生成黑图、空白或失败，则记录失败样例并附日志

注意事项：
- 此测试为手工集成测试。若出现权限或驱动导致的问题，请记录具体信息以便后续分析。 

