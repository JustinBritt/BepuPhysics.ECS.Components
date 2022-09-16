namespace BepuPhysics.ECS.Components.InterfacesFactories.Collidables
{
    using BepuPhysics.ECS.Components.Structs.Collidables;

    public interface IMinimumSpeculativeMarginComponentFactory
    {
        MinimumSpeculativeMarginComponent Create(
            float value);
    }
}