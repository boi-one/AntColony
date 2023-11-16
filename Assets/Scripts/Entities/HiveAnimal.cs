using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiveAnimal : Fauna
{
    public Vector3Int nestLocation;

    private IAntState currentState;
    public WanderingState wanderingState = new WanderingState();
    public CarryFoodState carryFoodState = new CarryFoodState();
    public FoundFoodState foundFoodState = new FoundFoodState();
    
    public HiveAnimal(GameObject body) : base(body)
    {
        this.body = body;
        currentState = wanderingState.ActiveState(this);
        //this.head.headObject = headObject;
        //this.rump.rumpObject = rumpObject;
        //this.leg.legObject = legObject;
    }
}
