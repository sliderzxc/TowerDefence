using Utils;

namespace Game.Movement.Camera.DirectionsMovement
{
    public class MoveRight : MovementDirection
    {
        public MoveRight() : base(Direction.Right)
        {
        }

        public override void Accept(IMovementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}