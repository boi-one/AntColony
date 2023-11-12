using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiveAnimal : Fauna, HiveAnimalInterface
{
    public Vector3Int nestLocation;
    public HiveAnimal owner { get; set; }
    public HiveAnimalStates hiveAnimalState = HiveAnimalStates.wander;

    public HiveAnimal(GameObject body) : base(body)
    {
        this.body = body;

        //this.head.headObject = headObject;
        //this.rump.rumpObject = rumpObject;
        //this.leg.legObject = legObject;
    }
}
