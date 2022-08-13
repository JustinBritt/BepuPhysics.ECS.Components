namespace BepuPhysics.ECS.Components.InterfacesFactories.Collidables
{
    using BepuPhysics.ECS.Components.Structs.Collidables;

    public interface ISpeculativeMarginComponentFactory
    {
        SpeculativeMarginComponent Create(
            float value);
    }
}