using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Tilemaps;

public class GenerateTerrain : MonoBehaviour
{
    public int discoverRange = 4;
    public Tilemap grassTileMap;
    public Tilemap groundTileMap;
    private Vector3 currentPosition;
    private Vector3Int currentTilePosition;
    void Start()
    {
        LayerManager.grassLayer.Add(grassTileMap.gameObject);
        LayerManager.groundLayer.Add(groundTileMap.gameObject);
    }

    private void generateGrassTerrain()
    {
        if (LayerManager.Z < 0) return;

        foreach (Ant ant in HiveManager.allAnts)
        {
            currentPosition = ant.body.GetComponent<Transform>().position;
            currentTilePosition = grassTileMap.WorldToCell(currentPosition);
            for (int x = -discoverRange; x < discoverRange; x++)
            {
                for (int y = -discoverRange; y < discoverRange; y++)
                {
                    if (!grassTileMap.GetTile(new Vector3Int(currentTilePosition.x + x, currentTilePosition.y + y)))
                    {
                        grassTileMap.SetTile(new Vector3Int(currentTilePosition.x + x, currentTilePosition.y + y), Resources.Load<Tile>("Sprites/TilemepPalettes/map_0"));
                    }
                }
                if (!grassTileMap.GetTile(new Vector3Int(currentTilePosition.x + x, currentTilePosition.y)))
                {
                    grassTileMap.SetTile(new Vector3Int(currentTilePosition.x + x, currentTilePosition.y), Resources.Load<Tile>("Sprites/TilemepPalettes/map_0"));
                }
            
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        generateGrassTerrain();
    }
}
