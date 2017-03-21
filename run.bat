@ECHO OFF

IF "%CONFIGURATION%"=="" SET CONFIGURATION=Debug

star --resourcedir="%~dp0src\BrainTreeWrapper\wwwroot" "%~dp0src/BrainTreeWrapper/bin/%CONFIGURATION%/BrainTreeWrapper.exe"