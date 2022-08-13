namespace BepuPhysics.ECS.Components.InterfacesFactories
{
    using System.Numerics;

    using BepuPhysics.ECS.Components.Structs;

    public interface IPositionComponentFactory
    {
        PositionComponent Create(
            Vector3 value);
    }
}