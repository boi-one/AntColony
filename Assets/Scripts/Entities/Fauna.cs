using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Fauna : Food
{
    public Head head = new Head();
    public Rump rump = new Rump();
    public Leg leg = new Leg();
    public int legAmount;
    protected List<Leg> legs = new List<Leg>();
    public int movementSpeed;

    public GameObject body;

    public Fauna(GameObject body)
    {
        this.body = body;
        //head.headObject = headObject;
        //rump.rumpObject = rumpObject;
        //for (int leg = 0; leg < legAmount; leg++)
        //{
        //    legs.Add(new Leg());
        //    legs[leg].legObject = legObject;
        //}   
    }
}
