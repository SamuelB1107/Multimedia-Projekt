// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Multimedia_Projekt : ModuleRules
{
	public Multimedia_Projekt(ReadOnlyTargetRules Target) : base(Target)
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
			"Multimedia_Projekt",
			"Multimedia_Projekt/Variant_Platforming",
			"Multimedia_Projekt/Variant_Platforming/Animation",
			"Multimedia_Projekt/Variant_Combat",
			"Multimedia_Projekt/Variant_Combat/AI",
			"Multimedia_Projekt/Variant_Combat/Animation",
			"Multimedia_Projekt/Variant_Combat/Gameplay",
			"Multimedia_Projekt/Variant_Combat/Interfaces",
			"Multimedia_Projekt/Variant_Combat/UI",
			"Multimedia_Projekt/Variant_SideScrolling",
			"Multimedia_Projekt/Variant_SideScrolling/AI",
			"Multimedia_Projekt/Variant_SideScrolling/Gameplay",
			"Multimedia_Projekt/Variant_SideScrolling/Interfaces",
			"Multimedia_Projekt/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
