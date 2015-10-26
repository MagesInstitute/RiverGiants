using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    public static float health = 100f;
	public static float size = 1f;
	public static float maxSize = 5f;
	public static float stamina = 100f;
	
	public static void OnHitFood(float value)
	{
		size += value;
		if(size >= maxSize)
			Debug.Log("Size already exceed/reached maxSize");
	}
	
	public static void OnHitObstacles(float value)
	{
		health -= value;
		if(health <= 0)
			Debug.Log("Health is below 0");
	}
	
}
