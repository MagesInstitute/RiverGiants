using UnityEngine;
using System.Collections;

public class SilentFollower : MonoBehaviour
{
    public Transform Target;
    public float Speed = 1.0f;

    // Update is called once per frame
    void Update ()
    {
        float factor = Speed * Time.deltaTime;

        Vector3 currentPos = this.transform.position;
        Vector3 targetPos = Target.position;
        Vector3 delta = targetPos - currentPos;
        delta *= factor;
        delta.z = 0;

        Vector3 newPos = currentPos + delta;
        this.transform.position = newPos;
    }
}
