using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounder : MonoBehaviour
{
    public enum Sfx
    {
        Jump,
        Land,
        Hit,
        Reset,
    }
    public AudioClip[] clips;
    AudioSource audio;
    
    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }
    public void PlaySound(Sfx sfx)
    {
        audio.clip = clips[(int)sfx];
        audio.Play();
    }

   
}
