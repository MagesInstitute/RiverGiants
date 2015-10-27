using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    //Public Static Variable
    public static int eatingScore = 0; //Total Score for the Food
    public static int comboCount = 1; //Combo Count (Maximum x5)
    public static bool triggerCombo = false; //Detection if Combo is activated (Public because TriggerScript can use it to launch Animation for Combo)

    //Static Variable
    static bool newFood = false; //If Combo is activate, set to true each time eating food to refresh the timer
    static float triggerTime = 1; //Trigger time to activate Combo
    static float comboTime = 3; //Time to timeout Combo
    static int foodCount = 0; //Food Count before activating Combo

    void Update()
    {
        if((foodCount > 0) && (!triggerCombo))
        {
            triggerTime -= Time.deltaTime;
            if((triggerTime < 0) && (foodCount < 3))
            {
                triggerTime = 1;
                foodCount = 0;
                Debug.Log("Trigger Combo Reset");
            }
            else if(foodCount >= 3)
            {
                triggerCombo = true;
                Debug.Log("Combo started");
            }
        }

        if(triggerCombo)
        {
            if (newFood)
            {
                comboTime = 3;
                newFood = false;
                Debug.Log("Obtained new Food, Combo Timer Refresh to " + comboTime);
            }

            comboTime -= Time.deltaTime;
            if(comboTime < 0)
            {
                comboTime = 3;
                comboCount = 1;
                triggerCombo = false;
                Debug.Log("Combo has ended!");
            }
        }
    }

    public static void Refresh()
    {
        eatingScore = 0;
        comboCount = 1;
        triggerCombo = false;
        triggerTime = 1;
        comboTime = 3;
        foodCount = 0;
    }

    public static void AddScore(int value)
    {
        if (!triggerCombo)
            foodCount++;
        else
        {
            newFood = true;

            if (comboCount < 5)
                comboCount++;
            else if (comboCount >= 5)
                comboCount = 5;
        }

        eatingScore += (value * comboCount);
        Debug.Log("Current Score: " + eatingScore);
        
        /*if (foodCount < 3)
        {
            StopCoroutine("TimerMinor");

            foodCount++;

           StartCoroutine("TimerMinor");
        }
        else if((foodCount >= 3) || (triggerCombo))
        {
            StopCoroutine("TimerCombo");

            triggerCombo = true;
            if (comboCount >= 5)
                comboCount = 5;
            else
                comboCount++;

           StartCoroutine("TimerCombo");
        }

        eatingScore += (value * comboCount);*/
    }

    /*static IEnumerator TimerMinor()
    {
        foodCount = 0;
        yield return new WaitForSeconds(triggerTime);
    }

    static IEnumerator TimerCombo()
    {
        comboCount = 1;
        triggerCombo = false;
        yield return new WaitForSeconds(comboTime);
    }*/
}
