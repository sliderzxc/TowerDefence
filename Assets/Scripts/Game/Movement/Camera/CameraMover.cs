using Game.Movement.Camera.DirectionsMovement;
using UnityEngine;

namespace Game.Movement.Camera
{
    public class CameraMover : MonoBehaviour
    {
        [SerializeField] private GameObject camera;
        [SerializeField] private Canvas canvas;

        private void FixedUpdate()
        {
            CheckIsButtonOfMovementPressed();   
        }

        private void CheckIsButtonOfMovementPressed()
        {
            if (Input.GetKey(KeyCode.W))
            {
                new MoveForward().Accept(new MovementVisitor(camera, canvas));
            }

            if (Input.GetKey(KeyCode.A))
            {
                new MoveLeft().Accept(new MovementVisitor(camera, canvas));
            }

            if (Input.GetKey(KeyCode.S))
            {
                new MoveBack().Accept(new MovementVisitor(camera, canvas));
            }

            if (Input.GetKey(KeyCode.D))
            {
                new MoveRight().Accept(new MovementVisitor(camera, canvas));
            }
        }
    }
}