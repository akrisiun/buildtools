cd src\
dotnet restore
cd ..

@REM @call run.cmd build-managed %*
msbuild BuildConsole.sln

@REM @exit /b %ERRORLEVEL%
@PAUSE