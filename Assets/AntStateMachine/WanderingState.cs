using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingState : IAntState
{
    public IAntState ActiveState(HiveAnimal hiveAnimal)
    {
        if (LookingForFood(hiveAnimal))
            return hiveAnimal.foundFoodState;
        return hiveAnimal.wanderingState;
    }
    
    public bool LookingForFood(HiveAnimal owner)
    {
        Vector3 targetPosition = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3));
        if((targetPosition - owner.body.transform.position).magnitude > .1f)
            owner.body.transform.position += (targetPosition - owner.body.transform.position).normalized * (owner.movementSpeed * Time.deltaTime);
        return true;
    }
}
