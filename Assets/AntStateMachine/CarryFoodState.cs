using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryFoodState : IAntState
{
    public IAntState ActiveState(HiveAnimal hiveAnimal)
    {
        return hiveAnimal.wanderingState;
    }
    
    public void Wandering()
    {

    }

    public void FoundFood()
    {
        
    }

    public void FoundEnemy()
    {

    }

    public void CarryFood()
    {
        Debug.Log("CARRY FOOD");
    }

    public void GoingToFoodSource()
    { 
        
    }
}