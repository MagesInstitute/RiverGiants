using UnityEngine;
using System.Collections;

public class Character_Follow : MonoBehaviour {

    public GameObject Player;

    float speed;

    Vector3 pos;

    Vector3 initpos;

	// Use this for initialization
	void Start ()
    {
        initpos = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        pos = initpos + Player.transform.position;
        transform.position = pos;
	}
}
