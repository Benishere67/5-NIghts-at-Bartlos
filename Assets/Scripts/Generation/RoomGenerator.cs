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

    public GameObject logicSwitch;
    public GameObject pressurePlate;
    public GameObject ghostSensor;
    public GameObject magnetBox;

    public float width;
    public float depth;
    public float height;
    

    public Mesh[] meshes;
    public Vector3[] vertices;
    public int[] triangles;

    void Start()
    {
        width = Random.Range(30,60);
        depth = Random.Range(30,60);
        height = Random.Range(13,18);
        Vector3 size= new Vector3(width,1,depth);
        floor.transform.localScale = size;
        ceiling.transform.localScale = size;
        wall1.transform.position = new Vector3(wall1.transform.position.x, wall1.transform.position.y,-depth/2);
        wall1.transform.localScale = new Vector3(width,1,height);
        wall3.transform.position = new Vector3(wall3.transform.position.x, wall3.transform.position.y,depth/2);
        wall3.transform.localScale = new Vector3(width,1,height);
        wall2.transform.position = new Vector3(width/2, wall2.transform.position.y,wall2.transform.position.z);
        wall2.transform.localScale = new Vector3(width,1,height);
        wall4.transform.position = new Vector3(-width/2, wall4.transform.position.y,wall4.transform.position.z);
        wall4.transform.localScale = new Vector3(width,1,height);
    }
}
/*
    void createRoom(float w, float h, float d){
        floor = createShape(w, d);
        UpdateMesh();

    }
   
    Mesh createShape(float x, float y){
        meshes[0] = new Mesh();
        GetComponent<MeshFilter>().mesh = meshes[0];
        vertices = new Vector3[]
        {
            new Vector3(0,0,0),
            new Vector3(0,0,y),
            new Vector3(x,0,0),
            new Vector3(x,0,y)
        };
        triangles = new int[]
        {
            0, 1, 2,
            1, 3, 2
        };
        Debug.Log(x + " by " + y);
        return(meshes[0]);
    }
    void UpdateMesh(){
        meshes[0].Clear();
        meshes[0].vertices=vertices;
        meshes[0].triangles=triangles;
        meshes[0].RecalculateNormals();
    }
*/

