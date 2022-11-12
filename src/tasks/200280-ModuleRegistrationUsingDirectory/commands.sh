cd ../../..

cd src/tasks/200270-SimplePrismModule

cd src/apps/200270-SimplePrismModule

dotnet new sln --name SimplePrismModule 

dotnet new wpf --name SimplePrismShell --framework net7.0

dotnet sln add ./SimplePrismShell/SimplePrismShell.csproj

dotnet build SimplePrismModule.sln

dotnet run --project ./SimplePrismShell/SimplePrismShell.csproj


dotnet add ./SimplePrismShell/SimplePrismShell.csproj package Prism.DryIoc --version 8.1.97

mkdir .\SimplePrismShell\Views

# Just a marker file so that Visual Studio 2022 will recognize fthe folder.
New-Item .\SimplePrismShell\Views\SomeMarkerFile.cs

mkdir .\SimplePrismShell\ViewModels

New-Item .\SimplePrismShell\ViewModels\SomeMarkerFile.cs

