using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AiroplaneCommand
{
    public interface LevelCommand
    {
        public bool IsStop();
        public bool FinalStatus();
    }
}

