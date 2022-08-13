namespace BepuPhysics.ECS.Components.InterfacesFactories
{
    using BepuPhysics.ECS.Components.Structs;

    public interface IMassComponentFactory
    {
        MassComponent Create(
            float value);
    }
}