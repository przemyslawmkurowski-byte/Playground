// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Engine/DataAsset.h"
#include "MyObjectBase.h"
#include "MyDataAsset.generated.h"

/**
 * 
 */
UCLASS(Blueprintable)
class PLAYGROUND_API UMyDataAsset : public UDataAsset
{
	GENERATED_BODY()
	
public:
	UPROPERTY(EditAnywhere, Instanced, BlueprintReadWrite, Category = "Input")
	TArray<TObjectPtr<UMyObjectBase>> Objects;
	
};
