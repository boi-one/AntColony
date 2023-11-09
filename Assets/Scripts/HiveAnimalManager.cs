using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HiveAnimalManager : MonoBehaviour
{
    private Queen hiveQueen;
    public GameObject queenBody;
    public QueenState queenState;
    private Vector3 targetPosition;
    private Tilemap grassTilemap;

    public int amountOfAnts;
    public static List<Ant> allAnts = new List<Ant>();
    
    
    
    void ChooseNestPosition()
    {
        grassTilemap.SetTile(InputManager.mouseGridPosition, Resources.Load<Tile>("Sprites/TilemepPalettes/map_3"));
        InputManager.rightMouseClick -= ChooseNestPosition;
    }
    void GoToTargetPosition()
    {
        targetPosition = new Vector3(InputManager.mousePosition.x, InputManager.mousePosition.y, 0);
        Vector2 direction = (hiveQueen.body.transform.position - targetPosition).normalized;
        hiveQueen.body.transform.up = -direction;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate the queen
        hiveQueen = new Queen(Instantiate(queenBody));
        Debug.Log("should be instantiated");
        LayerManager.grassLayer.Add(hiveQueen.body);
        HiveManager.allAnts.Add(hiveQueen);
        grassTilemap = GetComponent<GenerateTerrain>().grassTileMap;

        InputManager.leftMouseClick += GoToTargetPosition;
        InputManager.rightMouseClick += ChooseNestPosition;
        
        //Instantiate the ants
        for (int i = 0; i < amountOfAnts; i++)
            new Ant(Instantiate(queenBody));
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Ant ant in allAnts)
        {
            ant.Wander();
        }
        if (queenState == QueenState.lookingForNestingLocation && (hiveQueen.body.transform.position - targetPosition).magnitude > 0.1f)
        {
            hiveQueen.body.transform.position += (targetPosition - hiveQueen.body.transform.position).normalized * (2 * Time.deltaTime);
        }
        
    }
}
