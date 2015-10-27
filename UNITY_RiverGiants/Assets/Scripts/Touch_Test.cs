using UnityEngine;
using System.Collections;

public class Touch_Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Stationary)
        {
            print("stuff");
        }
    }
}
