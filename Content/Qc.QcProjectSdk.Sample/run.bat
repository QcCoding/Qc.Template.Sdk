taskkill /F /T /FI "WINDOWTITLE eq Qc.QcProjectSdk.Sample" /IM dotnet.exe
start "Qc.QcProjectSdk.Sample" dotnet run
exit