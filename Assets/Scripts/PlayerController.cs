using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AiroplaneCommand
{
    public class PlayerController : PlayerCommand
    {
        Player player;
        private GameObject platformTag;
        private string finishTag;
 
        public PlayerController(Player player)
        {
            this.player = player;
        }

        public void Down(bool value)
        {
            player.Down(value);
        }

        public void GameStart()
        {
            player.isStart = true;
            player.SetStartPosition();
        }

        public void NextLevel()
        {
            player.isStart = true;
            player.SetStartPosition();
        }

        public void Replay()
        {
            player.isStart = true;
            player.SetStartPosition();
        }

        public void RotateLeft(bool value)
        {
            player.IsLeftRotateon = value;         
        }

        public void RotateRight(bool value)
        {
            player.IsRightRotateOn = value;
        }

        public void Up(bool value)
        {
            player.IsUp = value;
        }

    }
}

