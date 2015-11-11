using UnityEngine;
using System.Collections;

public class SFXVolume : SliderVolume 
{

	// Use this for initialization
	void Start () 
    {
        Initialize();
	}

    protected override void UpdateVolume(float volume)
    {
        foreach(ControllableAudioSource cas in ControllableAudioSource._audioSources)
        {
            cas.Volume = volume;
        }
    }
	// Update is called once per frame
	void Update () 
    {
        CheckVolume();
	}
}
