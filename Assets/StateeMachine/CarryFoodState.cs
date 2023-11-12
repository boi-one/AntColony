using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryFoodState : AntStateMachine
{
    public HiveAnimal owner
    {
        get;
        set;
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