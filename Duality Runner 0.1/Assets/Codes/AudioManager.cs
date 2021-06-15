using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class AudioManager : MonoBehaviour
{
    public Sounds[] sounds;
    int chooseMusic;
    void Awake() {
        foreach(Sounds s in sounds)
        {
          s.source = gameObject.AddComponent<AudioSource>();
          s.source.clip = s.clip;
          s.source.pitch = s.pitch;
          s.source.loop = s.loop;
          s.source.volume = s.volume;
        }
    }
    void Start() {
          
       
    }
    public void Play (string name)
    {  
      Sounds s = Array.Find(sounds, sound => sound.name == name);
      s.source.Play();
    }
   
}
