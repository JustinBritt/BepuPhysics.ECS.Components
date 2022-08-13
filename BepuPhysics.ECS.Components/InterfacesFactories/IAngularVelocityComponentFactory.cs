namespace BepuPhysics.ECS.Components.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics.ECS.Components.Structs;

    public interface IAngularVelocityComponentFactory
    {
        AngularVelocityComponent Create(
            Vector3 value);
    }
}