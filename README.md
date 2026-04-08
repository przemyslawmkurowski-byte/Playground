This repo serve no specific project. I use it to check some smaller things that do not justify creating full repo.

## Experiment one - inlining object into Data Asset, akin of InputMappingContext's trigger

In host class, add:

UPROPERTY(EditAnywhere, Instanced, BlueprintReadWrite)
TArray<TObjectPtr<UGuessObject>>

Guess class should have specifiers:
UCLASS(Abstract, Blueprintable, EditInlineNew, CollapseCategories)

and thats it.
