using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : Ant
{
    public QueenState queenState;

    public Queen(GameObject body) : base(body)
    {
        Debug.Log("instantiate queen");
    }
    
    
}
