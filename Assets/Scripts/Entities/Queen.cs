using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Queen : Ant
{
    public QueenState queenState;

    public void ChooseNestPosition()
    {
        Tilemap tilemap = body.GetComponent<HiveAnimalManager>().grassTilemap;
        nestLocation = InputManager.mouseGridPosition;
        tilemap.SetTile(InputManager.mouseGridPosition, Resources.Load<Tile>("Sprites/TilemepPalettes/map_3"));
        InputManager.rightMouseClick -= ChooseNestPosition;
    }

    public void EnterNest()
    {
        body.transform.position += (nestLocation - body.transform.position).normalized * (2 * Time.deltaTime);
    }
    
    public Queen(GameObject body) : base(body)
    {
        Debug.Log("instantiate queen");
    }
    
    
}
