namespace BepuPhysics.ECS.Components.Factories
{
    using System.Numerics;

    using BepuPhysics.ECS.Components.InterfacesFactories;
    using BepuPhysics.ECS.Components.Structs;

    internal class AngularVelocityComponentFactory : IAngularVelocityComponentFactory
    {
        public AngularVelocityComponentFactory()
        {
        }

        public AngularVelocityComponent Create(
            Vector3 value)
        {
            AngularVelocityComponent component = default;

            try
            {
                component = new AngularVelocityComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}