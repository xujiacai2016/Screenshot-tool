SnapshotMate.Tests — NUnit Test Project Skeleton
===============================================

How to use
1. Save the files under a folder named `SnapshotMate.Tests`.
2. Ensure .NET SDK 7.0 (or 6.0) is installed.
3. From the project directory:
   - dotnet restore
   - dotnet test

Notes
- Many tests are templates and contain placeholders (TestHelpers, IntegrationHelpers, etc.)
  Replace placeholder helpers with actual implementations or mocks tied to your product code.
- Integration tests require target applications (Office/Teams/Chrome) on the test machine.
- UAT tests are marked [Explicit] and intended for manual execution.

If you want, I can:
- package these files into a ZIP for download;
- push them to a GitHub repo if you provide owner/repo + permission;
- or expand mocks to include basic FlaUI automation skeletons for integration.
