using System.Collections;
using System.Collections.Generic;
using Packages.Rider.Editor.UnitTesting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class InputManager : MonoBehaviour
{
    private Camera cam;
    public static Vector3 mousePosition;
    public static Vector3Int mouseGridPosition;
    public Tilemap tileMap;
    public float speed = 5;

    public delegate void LeftMouseClick();
    public static LeftMouseClick leftMouseClick;

    public delegate void RightMouseClick();
    public static RightMouseClick rightMouseClick;
    
    public delegate void MoveUp();
    public static MoveUp moveUp;
    
    public delegate void MoveLeft();
    public MoveLeft moveLeft;
    
    public delegate void MovedDown();
    public MovedDown moveDown;
    
    
    public delegate void MoveRight();
    public MoveRight moveRight;

    void MoveCameraUp()
    {
        cam.transform.position += new Vector3(0, 1) * (speed * Time.deltaTime);
    }

    void MoveCameraLeft()
    {
        cam.transform.position += new Vector3(-1, 0) * (speed * Time.deltaTime);
    }

    void MoveCameraRight()
    {
        cam.transform.position += new Vector3(1, 0) * (speed * Time.deltaTime);
    }

    void MoveCameraDown()
    {
        cam.transform.position += new Vector3(0, -1) * (speed * Time.deltaTime);
    }
    
    void Start()
    {
        cam = Camera.main;
        
        
        moveUp += MoveCameraUp;
        moveLeft += MoveCameraLeft;
        moveDown += MoveCameraDown;
        moveRight += MoveCameraRight;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        
        mouseGridPosition = tileMap.WorldToCell(InputManager.mousePosition);

        if (Input.GetMouseButtonDown(0) && leftMouseClick != null)
            leftMouseClick();
        if (Input.GetMouseButton(1) && rightMouseClick != null)
            rightMouseClick();
        if (Input.GetKey(KeyCode.W))
            moveUp();
        if (Input.GetKey(KeyCode.A))
            moveLeft();
        if (Input.GetKey(KeyCode.S))
            moveDown();
        if (Input.GetKey(KeyCode.D))
            moveRight();
    }
}
