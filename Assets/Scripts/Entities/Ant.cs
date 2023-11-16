using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : HiveAnimal
{
    protected int antSpeed = 5;

    public Ant(GameObject body) : base(body)
    {
        HiveAnimalManager.allAnts.Add(this);
    }
}
