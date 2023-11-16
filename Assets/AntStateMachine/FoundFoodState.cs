using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundFoodState : IAntState
{
    public IAntState ActiveState(HiveAnimal hiveAnimal)
    {
        return hiveAnimal.carryFoodState;
    }
}