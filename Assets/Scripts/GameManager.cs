using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AiroplaneCommand
{
    public class GameManager : MonoBehaviour
    {
        [Header("Game Data")]
        private int gameLevel;
        
        public Player player;
        PlayerCommand playerCommand;
        LevelCommand levelCommand;

        public GameObject nextGameObject;
        public GameObject replayGameObject;
        void Start()
        {
            gameLevel = 0;
            playerCommand = new PlayerController(player);

            LevelController.gameManager = GetComponent<GameManager>();
        }
        
        // Update is called once per frame
        void Update()
        {
            
        }
        public void RottateLeft(bool value)
        {
            
            playerCommand.RotateLeft(value);
        }
        public void RotateRight(bool value)
        {
            playerCommand.RotateRight(value);
        }
        public void Up(bool value)
        {
            playerCommand.Up(value);
        }
        public void Down(bool value)
        {
            playerCommand.Down(value);
        }
        public void Next()
        {

        }
        public void SetStatus(bool value)
        {
            if(value)
            {
                nextGameObject.SetActive(true);
            } else
            {
                replayGameObject.SetActive(true);
            }
        }
    }
}

