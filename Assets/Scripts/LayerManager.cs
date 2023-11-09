using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using Unity.VisualScripting;
using UnityEngine;

public class LayerManager : MonoBehaviour
{
    public static int Z;
    public static LayerStates layer;
    private bool switchState = true;
    
    public static List<GameObject> grassLayer = new List<GameObject>();
    public static List<GameObject> groundLayer = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        layer = LayerStates.grass;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && Z > -1)
        {
            Z--;
            switchState = true;
            Debug.Log("layer " + Z);
            layer = LayerStates.ground;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && Z < 0)
        {
            Z++;
            switchState = true;
            Debug.Log("layer " + Z);
            layer = LayerStates.grass;
        }
        
        if (!switchState) return;
        
        switch (layer)
            {
                case LayerStates.grass: 
                    switchState = false;
                    foreach (GameObject grassObj in grassLayer)
                    {
                        grassObj.GetComponent<Renderer>().enabled = true;
                    }
                    foreach (GameObject groundObj in groundLayer)
                    {
                        groundObj.GetComponent<Renderer>().enabled = false;
                    }
                    break;
                case LayerStates.ground:
                    switchState = false;
                    foreach (GameObject groundObj in groundLayer)
                    {
                        groundObj.GetComponent<Renderer>().enabled = true;
                    }
                    foreach (GameObject grassObj in grassLayer)
                    {
                        grassObj.GetComponent<Renderer>().enabled = false;
                    }
                    break;
            }
        }
}
