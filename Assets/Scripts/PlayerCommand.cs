using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AiroplaneCommand
{
    public interface PlayerCommand 
    {
        public void Up(bool value);
        public void Down(bool value);
        public void RotateLeft(bool value);
        public void RotateRight(bool value);

    }
}

