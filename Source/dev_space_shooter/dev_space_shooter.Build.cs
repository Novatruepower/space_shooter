// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class dev_space_shooter : ModuleRules
{
	public dev_space_shooter(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"dev_space_shooter",
			"dev_space_shooter/Variant_Platforming",
			"dev_space_shooter/Variant_Platforming/Animation",
			"dev_space_shooter/Variant_Combat",
			"dev_space_shooter/Variant_Combat/AI",
			"dev_space_shooter/Variant_Combat/Animation",
			"dev_space_shooter/Variant_Combat/Gameplay",
			"dev_space_shooter/Variant_Combat/Interfaces",
			"dev_space_shooter/Variant_Combat/UI",
			"dev_space_shooter/Variant_SideScrolling",
			"dev_space_shooter/Variant_SideScrolling/AI",
			"dev_space_shooter/Variant_SideScrolling/Gameplay",
			"dev_space_shooter/Variant_SideScrolling/Interfaces",
			"dev_space_shooter/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
