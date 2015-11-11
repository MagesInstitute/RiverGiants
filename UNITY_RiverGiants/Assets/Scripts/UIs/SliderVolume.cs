using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public abstract class SliderVolume : MonoBehaviour 
{

    public float VolumeLevel = 1;
    Slider slider;
    // Use this for initialization
    protected void Initialize ()
    {
        slider = this.GetComponent<Slider>();
        slider.value = VolumeLevel;
    }

    // Update is called once per frame
    protected bool CheckVolume ()
    {
        if (slider.value != VolumeLevel)
        {
            VolumeLevel = slider.value;
            UpdateVolume(VolumeLevel);
            return true;
        }
        return false;
    }
    protected abstract void UpdateVolume(float volume);
}
