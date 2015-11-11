using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MasterVolume : SliderVolume 
{

	// Use this for initialization
	void Start () 
    {
        Initialize();
    }
	
    protected override void UpdateVolume(float volume)
{
    AudioListener.volume = volume;
}
    

	// Update is called once per frame
	void Update () 
    {
        CheckVolume();
	}
}