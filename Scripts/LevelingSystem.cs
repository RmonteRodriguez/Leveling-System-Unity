//Code written by Remote Dev
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelingSystem : MonoBehaviour
{
    //Leveling System Variables
    public float initialValue = 100f;
    public float multiplyValue = 1.02f;
    public float addValue = 10f;
    public float rawExperience;
    public float currentExperience;
    public float addExperience;

    public int currentLevel;

    //UI
    public Text currentExperienceText;
    public Text currentLevelText;
    public Text currentCurveText;

    // Start is called before the first frame update
    void Start()
    {
        rawExperience = initialValue;
        currentLevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //These three lines of code are for UI
        currentExperienceText.text = (int)currentExperience + " XP";
        currentLevelText.text = "Level: " + currentLevel;
        currentCurveText.text = (int)rawExperience + "XP Needed";

        //Levels the object this script is attached to up
        if (currentExperience >= rawExperience)
        {
            LevelUp();
        }
    }

    //This function calculates the curve
    public void CalculateCurve()
    {
        rawExperience = (rawExperience * multiplyValue) + addValue;
    }

    //This function added experience to the object this script is attached to
    public void AddExperience()
    {
        currentExperience = currentExperience + addExperience;
    }

    //This function levels the object this script is attached to up
    public void LevelUp()
    {
        currentExperience = 0;
        currentLevel++;
        CalculateCurve();
    }
}
