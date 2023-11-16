using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface HiveAnimalInterface
{
    HiveAnimal owner
    {
        get;
        set;
    }
    
    void Wander()
    {
        
        Vector3 targetPosition = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3));
        if((targetPosition - owner.body.transform.position).magnitude < .1f)
            owner.body.transform.position += (targetPosition - owner.body.transform.position).normalized * (owner.movementSpeed * Time.deltaTime);
    }

    void FoundFood()
    {
        
    }

    void FoundEnemy()
    {
        
    }

    void EnterNest()
    {
        //if (owner.hiveAnimalState != HiveAnimalStates.toNest || (owner.body.transform.position - owner.nestLocation).magnitude > 0.1f) return;

        LayerManager.grassLayer.Remove(owner.body);
        LayerManager.groundLayer.Add(owner.body);
    }
}
