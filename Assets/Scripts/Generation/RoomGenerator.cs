//Should be attached to door in hallway

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerator : MonoBehaviour
{
    public Mesh floor;
    public Mesh wall;
    public Mesh ceiling;

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
    

    Mesh[] meshes;
    Vector3[] vertices;
    int[] triangles;

    void Start()
    {
        
        width = Random.Range(3,10);
        depth = Random.Range(3,10);
        height = Random.Range(10,15);
        createRoom(width, height, depth);
    }

    void createRoom(float w, float h, float d){
        floor = createShape(w, d);
        UpdateMesh();
        
        ceiling = createShape(d, h);
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

}
