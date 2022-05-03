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
    public float[] rows;
    public GameObject key;
    public GameObject door;
    public GameObject cabinet;
    public GameObject chair;
    public GameObject table;
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
    

    void Start()
    {
        width = Random.Range(3,6)*10;
        depth = Random.Range(3,6)*10;
        height = Random.Range(13,18);
        //for(int i=0; i<width/10; i++){
        //    rows[i] = -width + ((2*width/(width/10)*i));
       // }
        roomSizing();
        placeObject(trashCan,-.138f);
        placeObject(table,3.7f);
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
    
    public void placeObject(GameObject obid, float y){
        float x = Random.Range(-width/2,width/2);
        float z = Random.Range(-depth/2,depth/2);
        GameObject go = Instantiate(obid, new Vector3(x,y,z), Quaternion.Euler(-90,0,0)) as GameObject;
        go.transform.parent = GameObject.Find("Structures").transform;
        go.transform.localScale = new Vector3(1,1,1);
    }
}