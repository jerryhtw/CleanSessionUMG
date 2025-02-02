// Copyright Epic Games, Inc. All Rights Reserved.

#include "AdvancedTest0201GameMode.h"
#include "AdvancedTest0201Character.h"
#include "UObject/ConstructorHelpers.h"

AAdvancedTest0201GameMode::AAdvancedTest0201GameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
