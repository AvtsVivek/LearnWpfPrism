# Basic Prism App with Modules

- Introduces Prism Modules

- This builds from Previouis example.
- In this example, the module registration happens by ConfigurationModuleCatalog in App.xaml.cs
- 


```cs
protected override IModuleCatalog CreateModuleCatalog()
{
    return new ConfigurationModuleCatalog();
}
```

Now add the following code to the ModuleA.csproj file, to copy the moduleA.dll 


```xml
<Target Name="PostBuild" AfterTargets="PostBuildEvent">
  <Exec Command="xcopy &quot;$(TargetDir)$(TargetName)*$(TargetExt)&quot; &quot;$(SolutionDir)\SimplePrismShell\bin\Debug\net7.0-windows\&quot; /Y /S" />
</Target>
```

- Now create a app config file with the following content.

```xml
<configuration>
	<configSections>
		<section name="modules" type="Prism.Modularity.ModulesConfigurationSection, Prism.Wpf" />
	</configSections>
	<startup>
	</startup>
	<modules>
		<module assemblyFile="ModuleA.dll" moduleType="ModuleA.ModuleAModule, ModuleA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null" moduleName="ModuleAModule" startupLoaded="True" />
	</modules>
</configuration>
```

- Now run the app. Notive that the break points in the module shon above were hit.
