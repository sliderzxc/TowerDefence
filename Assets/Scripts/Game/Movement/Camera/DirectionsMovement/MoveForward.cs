using Utils;

namespace Game.Movement.Camera.DirectionsMovement
{
    public class MoveForward : MovementDirection
    {
        public MoveForward() : base(Direction.Forward)
        {
        }

        public override void Accept(IMovementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}