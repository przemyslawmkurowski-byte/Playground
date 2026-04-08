// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Playground : ModuleRules
{
	public Playground(ReadOnlyTargetRules Target) : base(Target)
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
			"Playground",
			"Playground/Variant_Platforming",
			"Playground/Variant_Platforming/Animation",
			"Playground/Variant_Combat",
			"Playground/Variant_Combat/AI",
			"Playground/Variant_Combat/Animation",
			"Playground/Variant_Combat/Gameplay",
			"Playground/Variant_Combat/Interfaces",
			"Playground/Variant_Combat/UI",
			"Playground/Variant_SideScrolling",
			"Playground/Variant_SideScrolling/AI",
			"Playground/Variant_SideScrolling/Gameplay",
			"Playground/Variant_SideScrolling/Interfaces",
			"Playground/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
