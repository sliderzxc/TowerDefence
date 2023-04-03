using Utils;

namespace Game.Movement.Camera
{
    public abstract class MovementDirection
    {
        public Direction Direction { get; }

        protected MovementDirection(Direction direction)
        {
            Direction = direction;
        }

        public abstract void Accept(IMovementVisitor visitor);
    }
}