# DXGI / BitBlt Spike Report Template

目的：验证 Desktop Duplication (DXGI)、BitBlt、PrintWindow 在目标测试机上的可用性、失败模式，以及建议的回退策略。

说明：本报告为模板。QA 在不同测试机上运行 spike 工具（位于 spike/BitBltCapture）并填写以下部分。

1. 测试环境
- 机器标识: 
- Windows 版本: 
- GPU 型号 / 驱动: 
- 分辨率与 DPI: 

2. 测试步骤
- 步骤 1: 在测试机上运行 spike 工具：
  - 打开 powershell
  - cd 到仓库/spike/BitBltCapture
  - dotnet run --output ./capture.png
- 步骤 2: 用常见目标应用打开窗口（Word、Teams、Chrome 等），重复运行工具并记录截图结果

3. 测试结果记录（为每台机器重复）
- 场景 (全屏 / 指定窗口):
- 成功: 是/否
- 生成文件路径:
- 观察到的问题（黑屏/偏移/异常）:
- 日志（若有）附上：

4. 建议的回退顺序与说明
- 如果 BitBlt 成功则记录为 BitBlt 可用
- 如果 BitBlt 不可用，记录原因并尝试 PrintWindow/其他方法

5. 附件
- 捕获的 PNG 文件
- 若有录像，请附上


