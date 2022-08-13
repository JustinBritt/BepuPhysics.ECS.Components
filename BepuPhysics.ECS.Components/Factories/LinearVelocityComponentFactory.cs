namespace BepuPhysics.ECS.Components.Factories
{
    using System.Numerics;

    using BepuPhysics.ECS.Components.InterfacesFactories;
    using BepuPhysics.ECS.Components.Structs;

    internal sealed class LinearVelocityComponentFactory : ILinearVelocityComponentFactory
    {
        public LinearVelocityComponentFactory()
        {
        }

        public LinearVelocityComponent Create(
            Vector3 value)
        {
            LinearVelocityComponent component = default;

            try
            {
                component = new LinearVelocityComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}