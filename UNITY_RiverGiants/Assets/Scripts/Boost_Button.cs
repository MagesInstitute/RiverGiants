using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Boost_Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool holdDown = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        print("q");
        holdDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        print("w");
        holdDown = false;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
