using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HiveAnimal : Fauna, HiveAnimalInterface
{
    public HiveAnimal(GameObject body) : base(body)
    {
        this.body = body;
        //this.head.headObject = headObject;
        //this.rump.rumpObject = rumpObject;
        //this.leg.legObject = legObject;
    }
}
