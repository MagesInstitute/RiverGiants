using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MusicVolume : SliderVolume 
{
    public string BackgroundMusic;
    AudioSource musicSource;
	// Use this for initialization
	void Start () 
    {
        Initialize();
        GameObject go = GameObject.Find(BackgroundMusic);
        if(go!=null)
        {
            musicSource = go.GetComponent<AudioSource>();
            UpdateVolume(VolumeLevel);
        }
	}

    protected override void UpdateVolume(float volume)
    {
        musicSource.volume = volume;
    }

	// Update is called once per frame
	void Update () 
    {
        CheckVolume ();
	}
}
