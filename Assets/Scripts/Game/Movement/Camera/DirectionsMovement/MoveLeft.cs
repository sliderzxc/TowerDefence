using Utils;

namespace Game.Movement.Camera.DirectionsMovement
{
    public class MoveLeft : MovementDirection
    {
        public MoveLeft() : base(Direction.Left)
        {
        }

        public override void Accept(IMovementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}