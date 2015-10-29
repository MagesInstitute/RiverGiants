using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DashBoard : MonoBehaviour 
{
    public Toggle[] toggles;
    public GameObject[] panels;

	// Use this for initialization
	void Start () 
    {
	
	}

    public void ToggleActive()
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }

        for(int i = 0; i < toggles.Length; i++)
        {
            print(toggles[i].isOn);
            if (toggles[i].isOn == true)
            {
                panels[i].SetActive(true);
                break;
            }
        }
    }
}
