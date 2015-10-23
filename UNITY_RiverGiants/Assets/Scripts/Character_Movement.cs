using UnityEngine;
using System.Collections;

public class Character_Movement : MonoBehaviour
{
    public Transform joystiq;

    public GameObject joystiqgrp;

    public float jspeed = 0.1F;

    public float cspeed;

    Vector2 startPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            joystiqgrp.SetActive(true);
            // Get movement of the finger since last frame
            startPos = Input.GetTouch(0).position;

            joystiqgrp.transform.position = startPos;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 movePos = Input.GetTouch(0).position - startPos;

            joystiq.localPosition = Vector2.ClampMagnitude(movePos*jspeed, 120);

            float x = joystiq.localPosition.x / 100;

            float y = joystiq.localPosition.y / 100;

            transform.Translate(x * cspeed * Time.deltaTime, y * cspeed * Time.deltaTime,0);

            print(movePos);
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {

            joystiqgrp.SetActive(false);
        }
    }
}
