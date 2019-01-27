﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlaySound : MonoBehaviour {

    [Header("Sound:")]
    public string clipName;

    public void PlayAudio() {
        print("lol");
        GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load(clipName));
    }
}
