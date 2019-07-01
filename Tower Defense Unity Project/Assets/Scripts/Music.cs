using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Music : MonoBehaviour {

    GameObject[] enemies;

    void Start () {
        //Set up for the level 1 and 2 differences
        if (SceneManager.GetSceneByName("Level01") == SceneManager.GetActiveScene())
        {
            AkSoundEngine.SetState("LevelVol", "Level1");
            AkSoundEngine.PostEvent("Level2_Stop", gameObject);
            AkSoundEngine.PostEvent("Level1_2D", gameObject);
        }
        if (SceneManager.GetSceneByName("Level02") == SceneManager.GetActiveScene())
        {
            AkSoundEngine.SetState("LevelVol", "Level2");
            AkSoundEngine.PostEvent("Level1_Stop", gameObject);
            AkSoundEngine.PostEvent("Level2_2D", gameObject);
        }

        AkSoundEngine.SetRTPCValue("StandardVol", 0.0f);
        AkSoundEngine.SetRTPCValue("MissileVol", 0.0f);
        AkSoundEngine.SetRTPCValue("LaserVol", 0.0f);
    }

    void Update()
    {
        //Finding the total amount of enemies on screen
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        AkSoundEngine.SetRTPCValue("Num_Enemies", enemies.Length);
    }
}
