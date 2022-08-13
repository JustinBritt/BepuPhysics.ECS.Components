namespace BepuPhysics.ECS.Components.InterfacesFactories
{
    using BepuPhysics.ECS.Components.Structs;

    public interface ISleepThresholdComponentFactory
    {
        SleepThresholdComponent Create(
            float value);
    }
}