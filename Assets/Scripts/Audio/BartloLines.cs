using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BartloLines : MonoBehaviour
{
    public AudioSource bartloGhost;
    public AudioClip[] audioClips;
    public AudioClip bartloGhostClip;

    public int clipSelect;
    public float randTime;
    public bool clipPlay;

    void Start()
    {
        clipPlay = false;
    }

    void SoundReset()
    {
        clipSelect = Random.Range(0, audioClips.Length);
        bartloGhostClip = audioClips[clipSelect];
        bartloGhost.PlayOneShot(bartloGhostClip);
        randTime = Random.Range(5, 10);
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

