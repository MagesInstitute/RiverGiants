using UnityEngine;
using System.Collections;

public class Splash1 : MonoBehaviour
{

    public float timer;

    void Update()
    {
        if (timer < 0.0f)
        {
            Application.LoadLevel("Splash 2");
        }
        timer -= Time.deltaTime;
    }

}
