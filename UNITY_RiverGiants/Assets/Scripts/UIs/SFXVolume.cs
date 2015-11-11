using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SFXVolume : SliderVolume
{
    public string SFX;
    AudioSource sfxSource;
    // Use this for initialization
    void Start()
    {
        Initialize();
        GameObject go = GameObject.Find(SFX);
        if (go != null)
        {
            sfxSource = go.GetComponent<AudioSource>();
            UpdateVolume(VolumeLevel);
        }
    }

    protected override void UpdateVolume(float volume)
    {
        sfxSource.volume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        CheckVolume();
    }
}
