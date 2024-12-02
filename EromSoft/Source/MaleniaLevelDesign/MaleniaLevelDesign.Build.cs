// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MaleniaLevelDesign : ModuleRules
{
	public MaleniaLevelDesign(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
