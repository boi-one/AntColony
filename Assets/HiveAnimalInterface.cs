using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface HiveAnimalInterface
{
    //HiveAnimal owner
    //{
    //    get;
    //    set;
    //}
    
    void Wander(HiveAnimal owner)
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
}
