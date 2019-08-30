using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string MASTER_VOLLUME_KEY = "master volume";
    const string DIFFICULTY_KEY = "difficulty";

    const float MAX_VOLUME = 1f;
    const float MIN_VOLUME = 0f;

    const int MAX_DIFFICULTY = 2;
    const int MIN_DIFFICULTY = 0;

    public static void SetMasterVolume(float volume)
    {
        if(volume>=MIN_VOLUME && volume <= MAX_VOLUME)
        {
            PlayerPrefs.SetFloat(MASTER_VOLLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume is out of range");
        }
        
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLLUME_KEY);
    }

    public static void SetDifficulty(float difficulty)
    {
        if (difficulty >= MIN_DIFFICULTY && difficulty <= MAX_DIFFICULTY)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Difficulty is out of range");
        }

    }

    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }

}
