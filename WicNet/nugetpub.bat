rmdir nupkg /Q /S
SET NUGET_ENABLE_LEGACY_CSPROJ_PACK=true
nuget pack -Build -OutputDirectory nupkg -properties Configuration=Release
nuget push nupkg\*.nupkg -Source https://api.nuget.org/v3/index.json