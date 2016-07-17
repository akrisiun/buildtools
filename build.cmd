cd src\
dotnet restore
cd ..

@call run.cmd build-managed %*

@REM @exit /b %ERRORLEVEL%
@PAUSE