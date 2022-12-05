using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    [SerializeField] private GameObject[] levelObject;
    StartController startController;
    void Start()
    {
        startController = new StartController();
       // startController.SetLevels();
         bool[] level = startController.Levels;
        int i = 0;
        foreach(bool levels in level)
        {
            levelObject[i].SetActive(levels);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
