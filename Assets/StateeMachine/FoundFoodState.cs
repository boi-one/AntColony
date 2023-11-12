using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundFoodState : AntStateMachine
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
        Debug.Log("FOUND FOOD");
    }

    public void FoundEnemy()
    {

    }

    public void CarryFood()
    {

    }

    public void GoingToFoodSource()
    { 
        
    }
}