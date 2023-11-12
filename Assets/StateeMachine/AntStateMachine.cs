using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AntStateMachine
{
    public HiveAnimal owner
    {
        get;
        set;
    }
    void Wandering();

    void FoundEnemy();

    void FoundFood();

    void CarryFood();

    void GoingToFoodSource();
}
