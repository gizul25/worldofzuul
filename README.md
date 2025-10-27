# Setup

## Arch Linux

```sh
sudo pacman -S dotnet-sdk-8.0
# Verify installation
dotnet --list-sdks
```

One way to build project:

```sh
dotnet publish
./Aqueous/bin/Debug/net6.0/Aqueous
```

Or run immediately:

```sh
cd Aqueous
dotnet run
```

Finally build a release version:

```sh
dotnet publish -c Release
./Aqueous/bin/Release/net6.0/Aqueous
```

Or self-contained release version (supposedly self-contained but requires .NET eitherways):

```sh
dotnet publish -c Release -r linux-x64 --self-contained
./Aqueous/bin/Release/net6.0/linux-x64/publish/Aqueous
```
