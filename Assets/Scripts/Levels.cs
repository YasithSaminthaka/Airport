using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AiroplaneCommand
{
    public class Levels : MonoBehaviour
    {
        LevelCommand levelCommand;
        private string tagName;public string TagName { get { return tagName; } }
        private void OnCollisionEnter(Collision collision)
        {
            
            tagName = collision.gameObject.tag;
        }
        private void OnCollisionExit(Collision collision)
        {
            tagName = "";
        }
    }
}

