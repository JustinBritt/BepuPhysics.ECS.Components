namespace BepuPhysics.ECS.Components.Structs
{
    using System.Numerics;

    public struct AngularVelocityComponent
    {
        public AngularVelocityComponent(
            Vector3 value)
        {
            this.Value = value;
        }

        public Vector3 Value { get; }
    }
}