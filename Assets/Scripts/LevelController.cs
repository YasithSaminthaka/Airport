using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AiroplaneCommand
{
    public class LevelController : LevelCommand
    {
        Levels levels;
        bool isStop;
        Player player;
        public static GameManager gameManager;
        public LevelController(Levels levels)
        {
            this.levels = levels;
        }
        public LevelController()
        {

        }
        public LevelController(Player player)
        {
            this.player = player;
        }
        public bool FinalStatus()
        {
            if(player.CollisionName.Equals("Finish"))
            {
                Debug.Log("Win");
                gameManager.SetStatus(true);
                return true;
            } else
            {
                gameManager.SetStatus(false);
                Debug.Log("Wrong");
                return false;
            }
        }
        

        public bool IsStop()
        {
            
            return isStop;
        }

        
    }
}
