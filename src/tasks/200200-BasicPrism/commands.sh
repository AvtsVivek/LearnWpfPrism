cd ../../..

cd src/tasks/200200-BasicPrism

cd src/apps/200200-BasicPrism

dotnet new sln --name BasicPrism 

dotnet new wpf --name BasicPrism --framework net7.0

Copy-Item ./BasicPrism/* . -Recurse

# Now that we have copied all of the items inside of the folder, we can delete all of the items inside of it and the folder itself.
Remove-Item ./BasicPrism -Recurse

dotnet sln add BasicPrism.csproj

dotnet build BasicPrism.sln
# or
dotnet build BasicPrism.csproj

dotnet run BasicPrism.csproj

# Now stop the app and then add the necessary nuget packages to make it a Prism app

dotnet add package Prism.DryIoc --version 8.1.97

mkdir Views

# Just a marker file so that Visual Studio 2022 will recognize fthe folder.
New-Item .\Views\SomeMarkerFile.cs

mkdir ViewModels

New-Item .\ViewModels\SomeMarkerFile.cs
