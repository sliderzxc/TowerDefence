using UnityEngine;

namespace Game.Movement
{
    public class Movement
    {
        private static int moveDistance = 5;
        
        public static void MoveLeft(GameObject camera, Canvas canvas)
        {
            var cameraPosition = camera.transform.position;
            var canvasTransformPosition = canvas.transform.position;
            Vector3 position = new Vector3(cameraPosition.x - moveDistance, cameraPosition.y, cameraPosition.z);
            Vector3 canvasPosition = new Vector3(canvasTransformPosition.x - moveDistance, canvasTransformPosition.y, canvasTransformPosition.z);
            camera.transform.position = position;
            canvas.transform.position = canvasPosition;
        }
        
        public static void MoveRight(GameObject camera, Canvas canvas)
        {
            var cameraPosition = camera.transform.position;
            var canvasTransformPosition = canvas.transform.position;
            Vector3 position = new Vector3(cameraPosition.x + moveDistance, cameraPosition.y, cameraPosition.z);
            Vector3 canvasPosition = new Vector3(canvasTransformPosition.x + moveDistance, canvasTransformPosition.y, canvasTransformPosition.z);
            camera.transform.position = position;
            canvas.transform.position = canvasPosition;
        }
        
        public static void MoveBack(GameObject camera, Canvas canvas)
        {
            var cameraTransformPosition = camera.transform.position;
            var canvasTransformPosition = canvas.transform.position;
            Vector3 cameraPosition = new Vector3(cameraTransformPosition.x, cameraTransformPosition.y, cameraTransformPosition.z - moveDistance);
            Vector3 canvasPosition = new Vector3(canvasTransformPosition.x, canvasTransformPosition.y, canvasTransformPosition.z - moveDistance);
            camera.transform.position = cameraPosition;
            canvas.transform.position = canvasPosition;
        }
        
        public static void MoveForward(GameObject camera, Canvas canvas)
        {
            var cameraTransformPosition = camera.transform.position;
            var canvasTransformPosition = canvas.transform.position;
            Vector3 cameraPosition = new Vector3(cameraTransformPosition.x, cameraTransformPosition.y, cameraTransformPosition.z + moveDistance);
            Vector3 canvasPosition = new Vector3(canvasTransformPosition.x, canvasTransformPosition.y, canvasTransformPosition.z + moveDistance);
            camera.transform.position = cameraPosition;
            canvas.transform.position = canvasPosition;
        }
    }
}