using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ControllableAudioSource : MonoBehaviour 
{
    AudioSource audioSource;
    public static List<ControllableAudioSource> _audioSources = new List<ControllableAudioSource>();
	// Use this for initialization
	void Start () 
    {
        audioSource = this.GetComponent<AudioSource>();
        _audioSources.Add(this);
	}
	public float Volume
    {
        set { audioSource.volume = value; }
        get { return audioSource.volume; }
    }
     void OnDestroy()
    {
        _audioSources.Remove(this);
    }
	// Update is called once per frame
	void Update () 
    {

	}
}
