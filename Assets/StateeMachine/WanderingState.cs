using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingState : AntStateMachine
{
    public HiveAnimal owner
    {
        get;
        set;
    }
    public void Wandering()
    {
        Vector3 targetPosition = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3));
        if((targetPosition - owner.body.transform.position).magnitude < .1f)
            owner.body.transform.position += (targetPosition - owner.body.transform.position).normalized * (owner.movementSpeed * Time.deltaTime);
    }

    public void FoundFood()
    {
        
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
