// %COPYWRITE%

using UnrealBuildTool;

public class MyPlugin : ModuleRules
{
	public  MyPlugin(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicDependencyModuleNames.AddRange(new [] { "Core" });
		PrivateDependencyModuleNames.AddRange(new [] { "CoreUObject", "Engine" });
	}
}
