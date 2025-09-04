# Setup

## Arch Linux

```sh
sudo pacman -S dotnet-sdk-6.0
# Verify installation
dotnet --list-sdks
```

One way to build project:

```sh
dotnet publish
./WorldOfZuul/bin/Debug/net6.0/WorldOfZuul
```

Or run immediately:

```sh
dotnet run --project WorldOfZuul/WorldOfZuul.csproj
```

Finally build a release version:

```sh
dotnet publish -c Release
./WorldOfZuul/bin/Release/net6.0/WorldOfZuul
```

Or self-contained release version (supposedly self-contained but requires .NET eitherways):

```sh
dotnet publish -c Release -r linux-x64 --self-contained
./WorldOfZuul/bin/Release/net6.0/linux-x64/publish/WorldOfZuul
```
