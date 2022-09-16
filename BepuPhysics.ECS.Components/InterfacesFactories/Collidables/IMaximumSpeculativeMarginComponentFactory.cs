namespace BepuPhysics.ECS.Components.InterfacesFactories.Collidables
{
    using BepuPhysics.ECS.Components.Structs.Collidables;

    public interface IMaximumSpeculativeMarginComponentFactory
    {
        MaximumSpeculativeMarginComponent Create(
            float value);
    }
}