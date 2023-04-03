using Game.Movement.Camera.DirectionsMovement;

namespace Game.Movement.Camera
{
    public interface IMovementVisitor
    {
        void Visit(MoveLeft movement);
        void Visit(MoveRight movement);
        void Visit(MoveBack movement);
        void Visit(MoveForward movement);
    }
}