cd src\Microsoft.DotNet.VersionTools
dotnet restore
dotnet build

cd ..\Microsoft.DotNet.Build.Tasks
dotnet restore
dotnet build

cd ..\..\
@PAUSE