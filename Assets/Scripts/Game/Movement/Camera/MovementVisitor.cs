using Game.Movement.Camera.DirectionsMovement;
using UnityEngine;

namespace Game.Movement.Camera
{
    public class MovementVisitor : IMovementVisitor
    {
        private GameObject camera;
        private Canvas canvas;
        private int moveDistance = 5;
    
        public MovementVisitor(GameObject camera, Canvas canvas)
        {
            this.camera = camera;
            this.canvas = canvas;
        }
    
        public void Visit(MoveForward moveForward)
        {
            var cameraTransformPosition = camera.transform.position;
            var canvasTransformPosition = canvas.transform.position;
            Vector3 cameraPosition = new Vector3(cameraTransformPosition.x, cameraTransformPosition.y, cameraTransformPosition.z + moveDistance);
            Vector3 canvasPosition = new Vector3(canvasTransformPosition.x, canvasTransformPosition.y, canvasTransformPosition.z + moveDistance);
            camera.transform.position = cameraPosition;
            canvas.transform.position = canvasPosition;
        }

        public void Visit(MoveLeft moveLeft)
        {
            var cameraPosition = camera.transform.position;
            var canvasTransformPosition = canvas.transform.position;
            Vector3 position = new Vector3(cameraPosition.x - moveDistance, cameraPosition.y, cameraPosition.z);
            Vector3 canvasPosition = new Vector3(canvasTransformPosition.x - moveDistance, canvasTransformPosition.y, canvasTransformPosition.z);
            camera.transform.position = position;
            canvas.transform.position = canvasPosition;
        }

        public void Visit(MoveRight moveRight)
        {
            var cameraPosition = camera.transform.position;
            var canvasTransformPosition = canvas.transform.position;
            Vector3 position = new Vector3(cameraPosition.x + moveDistance, cameraPosition.y, cameraPosition.z);
            Vector3 canvasPosition = new Vector3(canvasTransformPosition.x + moveDistance, canvasTransformPosition.y, canvasTransformPosition.z);
            camera.transform.position = position;
            canvas.transform.position = canvasPosition;
        }

        public void Visit(MoveBack moveBack)
        {
            var cameraTransformPosition = camera.transform.position;
            var canvasTransformPosition = canvas.transform.position;
            Vector3 cameraPosition = new Vector3(cameraTransformPosition.x, cameraTransformPosition.y, cameraTransformPosition.z - moveDistance);
            Vector3 canvasPosition = new Vector3(canvasTransformPosition.x, canvasTransformPosition.y, canvasTransformPosition.z - moveDistance);
            camera.transform.position = cameraPosition;
            canvas.transform.position = canvasPosition;
        }
    }
}