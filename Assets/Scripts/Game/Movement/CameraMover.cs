using UnityEngine;
using Utils;

namespace Game.Movement
{
    public class CameraMover : MonoBehaviour
    {
        [SerializeField] private GameObject camera;
        [SerializeField] private Canvas canvas;
        private int moveDistance = 5;
        
        private void FixedUpdate()
        {
            CheckIsButtonOfMovementPressed();   
        }

        private void CheckIsButtonOfMovementPressed()
        {
            if (Input.GetKey(KeyCode.W))
            {
                MoveCamera(Direction.Forward);
            }

            if (Input.GetKey(KeyCode.A))
            {
                MoveCamera(Direction.Left);
            }

            if (Input.GetKey(KeyCode.S))
            {
                MoveCamera(Direction.Back);
            }

            if (Input.GetKey(KeyCode.D))
            {
                MoveCamera(Direction.Right);
            }
        }

        private void MoveCamera(Direction direction)
        {
            switch (direction)
            {
                case Direction.Forward:
                    Movement.MoveForward(camera, canvas); 
                    break;
                
                case Direction.Left:
                    Movement.MoveLeft(camera, canvas);
                    break;
                
                case Direction.Right:
                    Movement.MoveRight(camera, canvas);
                    break;
                
                case Direction.Back:
                    Movement.MoveBack(camera, canvas);
                    break;
            }
        }
    }
}