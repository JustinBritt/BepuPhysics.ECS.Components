namespace BepuPhysics.ECS.Components.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics.ECS.Components.Structs;

    public interface ILinearVelocityComponentFactory
    {
        LinearVelocityComponent Create(
            Vector3 value);
    }
}