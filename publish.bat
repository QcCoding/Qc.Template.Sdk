nuget pack Qc.Template.Sdk.nuspec -OutputDirectory ./Output
cd ./Output
dotnet nuget push *.nupkg -k %NugetToken% -s https://api.nuget.org/v3/index.json
pause