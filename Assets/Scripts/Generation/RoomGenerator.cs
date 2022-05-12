//Should be attached to door in hallway

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour
{
    public GameObject floor;
    public GameObject ceiling;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

    public GameObject[] objects;

    public GameObject key;
    public GameObject door;
    public GameObject cabinet;
    public GameObject chair;
    public GameObject table;
    public GameObject cart;
    public GameObject teacherDesk;
    public GameObject poster;
    public GameObject whiteboard;
    public GameObject ceilingLight;
    public GameObject lightSwitch;
    public GameObject trashCan;
    public GameObject recycleBin1;
    public GameObject recycleBin2;

    public GameObject logicSwitch;
    public GameObject pressurePlate;
    public GameObject ghostSensor;
    public GameObject magnetBox;

   
    public float width;
    public float depth;
    public float height;
    public int rows;
    public int columns;

    void Start()
    {
        rows = Random.Range(3,6);
        columns = Random.Range(3,6);
        height = Random.Range(13,18);
        width = rows*10;
        depth = columns*10;
        roomSizing();
        
        placeObject(recycleBin1,1,columns,-8,-1);
        placeObject(recycleBin2,1,columns,-7,-1);
        placeObject(trashCan,1,columns,-6,-1);
        placeObject(cabinet,1,1,-9,-1);
        placeObject(cart,rows-2,columns-2,0,0);
        for(int j=1; j<columns; j++){
            for (int i=1; i<=rows; i++){
                placeObject(table,i,j,-5,-5);
            }
        }
    }

    public void roomSizing(){
        // Scales and places floor, ceiling, walls
        Vector3 size= new Vector3(width,1,depth);
        floor.transform.localScale = size;
        ceiling.transform.localScale = size;
        ceiling.transform.position = new Vector3(ceiling.transform.position.x,height,ceiling.transform.position.z);
        wall1.transform.position = new Vector3(wall1.transform.position.x, height/2,-depth/2);
        wall1.transform.localScale = new Vector3(width,1,height);
        wall3.transform.position = new Vector3(wall3.transform.position.x, height/2,depth/2);
        wall3.transform.localScale = new Vector3(width,1,height);
        wall2.transform.position = new Vector3(width/2, height/2,wall2.transform.position.z);
        wall2.transform.localScale = new Vector3(depth,1,height);
        wall4.transform.position = new Vector3(-width/2, height/2,wall4.transform.position.z);
        wall4.transform.localScale = new Vector3(depth,1,height);
    }
    
    public void placeObject(GameObject obid, int row, int col, float rowSub, float colSub){
        float x = (-width/2+((width/rows)*row))+rowSub;
        float z = (-depth/2+((depth/columns)*col))+colSub;
        GameObject go = Instantiate(obid, new Vector3(x,0,z), Quaternion.Euler(-90,0,0)) as GameObject;
        go.transform.parent = GameObject.Find("Structures").transform;
        go.transform.localScale = new Vector3(1,1,1);
    }
}