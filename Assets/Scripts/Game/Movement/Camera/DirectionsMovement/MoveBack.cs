using Utils;

namespace Game.Movement.Camera.DirectionsMovement
{
    public class MoveBack : MovementDirection
    {
        public MoveBack() : base(Direction.Back)
        {
        }

        public override void Accept(IMovementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}