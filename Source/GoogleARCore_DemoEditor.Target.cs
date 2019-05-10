// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class GoogleARCore_DemoEditorTarget : TargetRules
{
	public GoogleARCore_DemoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "GoogleARCore_Demo" } );
	}
}
