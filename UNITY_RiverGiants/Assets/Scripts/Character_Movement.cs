using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Character_Movement : MonoBehaviour
{
    public Transform joystiq;

    public GameObject joystiqgrp;

    public float jspeed = 0.1F;

    public float speed;

    private float cspeed;

    public float boostMult;

    float x;

    float y;

    bool boost;

    Quaternion newRotation;

    Vector2 startPos;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter (Collider col)
    {
        switch (col.tag)
        {
            case "Food":
                print("Yummy");
                break;

            case "Poison":
                print("You have been poisoned");
                break;

            default:
                print("Ouch");
                break;
        }
    }

    public void Boost()
    {
        boost = true;
        StartCoroutine(BoostUp_());
    }

    public void StopBoost()
    {
        boost = false;
        speed = 20;
        StartCoroutine(BoostDown_());
    }

    IEnumerator BoostUp_()
    {
        for (float i = 0; i <= 1 && boost; i += Time.deltaTime) 
        {

            cspeed = speed + (boostMult * i);
            yield return null;
        }
    }

    IEnumerator BoostDown_()
    {
        for (float i = 0; i <= 1 && boost==false; i += Time.deltaTime)
        {

            cspeed = speed + (boostMult * -i);
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            joystiqgrp.SetActive(true);
            // Get movement of the finger since last frame
            startPos = Input.GetTouch(0).position;

            cspeed = 10;

            joystiqgrp.transform.position = startPos;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 movePos = Input.GetTouch(0).position - startPos;

            joystiq.localPosition = Vector2.ClampMagnitude(movePos*jspeed, 120);

            x = joystiq.localPosition.x;

            y = joystiq.localPosition.y;
            
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            joystiqgrp.SetActive(false);
        }

        if (Input.touchCount == 0)
        {
            cspeed = 0;
        }

        transform.Translate(x/100 * cspeed * Time.deltaTime, y/100 * cspeed * Time.deltaTime, 0, Camera.main.transform);
        newRotation = Quaternion.LookRotation(new Vector3(x,y,0));
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * cspeed);
    }
}
