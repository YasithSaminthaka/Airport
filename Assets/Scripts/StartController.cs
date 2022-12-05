using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartController : MonoBehaviour
{
    int levelLength = 10;
   
    private bool[] levels;public bool[] Levels { get { GetBuyLevels(); return levels; }}

    private void UnlockLevels(int level)
    {
        PlayerPrefs.SetInt("level" + level, 3); //3 = unlock level
        PlayerPrefs.Save();
    }
    public bool[] GetBuyLevels()   
    {
        levels = new bool[levelLength];
        UnlockLevels(0);
        for(int i =0;i<levelLength;i++)
        {
            if(PlayerPrefs.GetInt("level" + i) == 3)
            {
                levels[i] = true;
            } else
            {
                levels[i] = false;
            }
            
        }
        return levels;
    }
}
