// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AdvancedTest0201 : ModuleRules
{
	public AdvancedTest0201(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });

		DynamicallyLoadedModuleNames.Add("OnlineSubsystemSteam");
	}
}
