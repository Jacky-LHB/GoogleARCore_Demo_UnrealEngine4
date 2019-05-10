// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class GoogleARCore_DemoTarget : TargetRules
{
	public GoogleARCore_DemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "GoogleARCore_Demo" } );
	}
}
