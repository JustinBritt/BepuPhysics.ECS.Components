namespace BepuPhysics.ECS.Components.Factories
{
    using BepuPhysics.ECS.Components.InterfacesFactories;
    using BepuPhysics.ECS.Components.Structs;

    internal sealed class SleepThresholdComponentFactory : ISleepThresholdComponentFactory
    {
        public SleepThresholdComponentFactory()
        {
        }

        public SleepThresholdComponent Create(
            float value)
        {
            SleepThresholdComponent component = default;

            try
            {
                component = new SleepThresholdComponent(
                    value);
            }
            finally
            {
            }

            return component;
        }
    }
}