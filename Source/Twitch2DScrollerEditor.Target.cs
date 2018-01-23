// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Twitch2DScrollerEditorTarget : TargetRules
{
	public Twitch2DScrollerEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Twitch2DScroller" } );
	}
}
