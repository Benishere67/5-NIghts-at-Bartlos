using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceControl : MonoBehaviour
{
    public AudioSource ambience;
    public AudioClip[] audioClips;
    public AudioClip ambienceClip;

    public int clipSelect;
    public float randTime;

    void SoundReset()
    {
        clipSelect = Random.Range(0, audioClips.Length);
        ambienceClip = audioClips[clipSelect];
        ambience.PlayOneShot(ambienceClip);
        randTime = Random.Range(1, 5);
    }

    /*void Wait()
    {
        yield WaitForSeconds(randTime);
    }

    void Update()
    {
        yield StartCoroutine("Wait");
    } */
}
