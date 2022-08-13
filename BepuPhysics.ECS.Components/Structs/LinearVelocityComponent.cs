namespace BepuPhysics.ECS.Components.Structs
{
    using System.Numerics;

    public struct LinearVelocityComponent
    {
        public LinearVelocityComponent(
            Vector3 value)
        {
            this.Value = value;
        }

        public Vector3 Value { get; }
    }
}