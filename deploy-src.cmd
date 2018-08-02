rem remove releases
rd /s /q .\src\SevenZipFluent\bin\Release

rem build release
dotnet build -c Release .\SevenZipFluent.sln

rem push nuget
nuget push .\src\SevenZipFluent\bin\Release\*.nupkg -Source https://api.nuget.org/v3/index.json