using UnityEngine;
using System.Collections;

public class FoodInstantiator : MonoBehaviour
{
    bool canSpawn = false;
    float countdownTime;

    public GameObject spawnPrefab;
    public float maxCountDownTime = 10;
    public int maxSpawn = 5;
    public int minSpawnTime = 5;
    public int maxSpawnTime = 10;

    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("SpawnFood", 0.5f, Random.Range(minSpawnTime, maxSpawnTime));
	}
	
    void SpawnFood()
    {
        if (!canSpawn)
        {
            int childCount = transform.childCount;

            for (int i = 0; i < maxSpawn - childCount; i++)
            {
                GameObject fishChild = Instantiate(spawnPrefab, this.transform.position + new Vector3(Random.Range(-5, 10), Random.Range(-5,10),0), Quaternion.identity) as GameObject;
                fishChild.transform.parent = this.transform;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SilentFollower")
            canSpawn = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "SilentFollower")
            canSpawn = false;
    }

}
