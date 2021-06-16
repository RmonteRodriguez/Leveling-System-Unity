//Code written by Remote Dev
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingExtras : MonoBehaviour
{
    public LevelingSystem levelingSystem;

    private Transform UIXPBar;

    // Start is called before the first frame update
    void Start()
    {
        UIXPBar = GameObject.Find("XPBar").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float t_xp_ratio = levelingSystem.currentExperience / levelingSystem.rawExperience;
        UIXPBar.localScale = new Vector3(t_xp_ratio, 1, 1);
    }

    public void ExternalXPGive()
    {
        levelingSystem.currentExperience = levelingSystem.currentExperience + 10;
    }

    public void InternalXPGive()
    {
        levelingSystem.AddExperience();
    }
}
