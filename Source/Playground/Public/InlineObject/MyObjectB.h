// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "InlineObject/MyObjectBase.h"
#include "MyObjectB.generated.h"

/**
 * 
 */
UCLASS()
class PLAYGROUND_API UMyObjectB : public UMyObjectBase
{
	GENERATED_BODY()
	
public:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	FName Codename;
	
};
