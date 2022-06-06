using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class Difficulty 
{
    // Start is called before the first frame update
    static float secondsToMaxDifficulty = 60f;

    public static float GetDifficultyPercent()
    {
        return Mathf.Clamp01(Time.time / secondsToMaxDifficulty);
    }

}
