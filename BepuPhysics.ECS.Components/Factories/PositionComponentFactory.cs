namespace BepuPhysics.ECS.Components.Factories
{
    using System.Numerics;

    using BepuPhysics.ECS.Components.InterfacesFactories;
    using BepuPhysics.ECS.Components.Structs;

    internal sealed class PositionComponentFactory : IPositionComponentFactory
    {
        public PositionComponentFactory()
        {
        }

        public PositionComponent Create(
            Vector3 value)
        {
            PositionComponent component = default;

            try
            {
                component = new PositionComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}