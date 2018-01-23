// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Twitch2DScrollerTarget : TargetRules
{
	public Twitch2DScrollerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Twitch2DScroller" } );
	}
}
