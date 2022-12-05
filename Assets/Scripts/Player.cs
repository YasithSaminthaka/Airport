using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AiroplaneCommand
{
    public class Player : MonoBehaviour
    {
        public bool IsLeftRotateon = false;
        public bool IsRightRotateOn = false;
        public bool isStart = false;
        public bool IsUp = false;
        public bool IsDown = false;
        [SerializeField] private float RotateSpeed;
        public float speed;
        public GameObject target;
        [Header("Player Speed")]
        public float MaxSpeed = 30f;
        public Transform startPosition;
        bool Isaccelaration;
        bool IsDeaccelaration;
        public bool isKinemeticActive = true;
        private string collisionName;public string CollisionName { get { return collisionName; } }

        public LevelCommand levelCommand;
        private bool isLast;
        private bool nextOrReplay;public bool NextOrReplay { get { return nextOrReplay; }  }
        private void Start()
        {
            levelCommand = new LevelController(GetComponent<Player>());
        }
        private void Update()
        {
            if(IsLeftRotateon)
            {
                Rotate(RotateSpeed);
            } 
            else if(IsRightRotateOn)
            {
                Rotate(-RotateSpeed);
            }
            if(IsUp)
            {
                Up(3);
            }
            
            if(isStart)
            {
                if(speed<MaxSpeed )
                {
                    speed = speed + 0.05f;
                }                           
                Run();
            } else
            {
                GetComponent<Rigidbody>().isKinematic = false;
                
                if(speed>0 )
                {
                    speed = speed - 0.05f;
                    Run();
                }
                else
                {
                    if(isLast)
                    {
                        nextOrReplay = levelCommand.FinalStatus();
                        isLast = false;

                        
                    }
                }
            }   
        }
        public void Run()
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
            
        }
        public void SetStartPosition()
        {
            transform.position = startPosition.position;
        }
        public void Rotate(float value)
        {
             transform.GetChild(0).transform.Rotate(0, 0, value * Time.deltaTime);
        }
        public void Up(float value)
        {
            if (speed >= MaxSpeed)
            {
                GetComponent<Rigidbody>().isKinematic = true;
                transform.Translate(0, value * Time.deltaTime, 0);
            }     
        }
        public void Down(bool value)
        {
            if(isStart)
            {
                GetComponent<Rigidbody>().isKinematic = value;
            } else
            {
                GetComponent<Rigidbody>().isKinematic = false;
            }
                
        }
        private void OnCollisionEnter(Collision collision)
        {


                Debug.Log("Collision name : " + collision.gameObject.tag);

                collisionName = collision.gameObject.tag;
                if (speed >= MaxSpeed)
                {
                    isStart = false;
                    transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, 0);

                }
            
        }
        private void OnCollisionExit(Collision collision)
        {
            collisionName = "";
            isLast = true;
        }
        

    }
}

