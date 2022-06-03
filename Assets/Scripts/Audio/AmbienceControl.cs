using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceControl : MonoBehaviour
{
    public AudioSource ambience;
    public AudioClip[] audioClips;
    public AudioClip ambienceClip;
    public GameObject AmbientSound;
    
    public Vector3 ambienceStart;
    public Vector3 tpLocation;

    public int clipSelect;
    public float randTime;
    public bool clipPlay;

    public float tpX;
    public float tpZ;

    void Start()
    {
        clipPlay = false;
        AmbientSound.transform.position = ambienceStart;
    }

    void SoundReset()
    {
        clipSelect = Random.Range(0, audioClips.Length);
        ambienceClip = audioClips[clipSelect];
        ambience.PlayOneShot(ambienceClip);
        randTime = Random.Range(15, 30);
        
        tpX = Random.Range(-200, 200);
        tpZ = Random.Range(-150, 150);
        tpLocation = new Vector3(tpX, 80, tpZ);
        AmbientSound.transform.position = tpLocation;
    }


    void Update()
    {
        randTime -= 1 * Time.deltaTime;

        if (randTime <= 0) {
            clipPlay = true;
        }

        if (clipPlay == true) {
            SoundReset();
            clipPlay = false;
        }    
    } 
}
