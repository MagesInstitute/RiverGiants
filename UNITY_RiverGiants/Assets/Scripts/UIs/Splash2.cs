using UnityEngine;
using System.Collections;

public class Splash2 : MonoBehaviour
{

    public float timer;

    void Update()
    {
        if (timer < 0.0f)
        {
            Application.LoadLevel("UI");
        }
        timer -= Time.deltaTime;
    }

}
