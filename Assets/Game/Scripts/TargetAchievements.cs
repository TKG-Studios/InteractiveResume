using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
public class TargetAchievements : MonoBehaviour
{
    public GameObject[] targets;
    private GameObject progressTarget;


    private void OnEnable()
    {
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i].GetComponent<Health>().OnDeath += UnlockAcheivement;
         
        } 
      
    }

    private void OnDisable()
    {
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i].GetComponent<Health>().OnDeath -= UnlockAcheivement;
        }

    }



    public void UnlockAcheivement()
    {
        MMAchievementManager.UnlockAchievement("TargetHit");
        MMAchievementManager.AddProgress("AllTargetsHit", 1);
    }

}
