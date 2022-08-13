namespace BepuPhysics.ECS.Components.Factories
{
    using BepuPhysics.ECS.Components.InterfacesFactories;
    using BepuPhysics.ECS.Components.Structs;

    internal sealed class MassComponentFactory : IMassComponentFactory
    {
        public MassComponentFactory()
        {
        }

        public MassComponent Create(
            float value)
        {
            MassComponent component = default;

            try
            {
                component = new MassComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}