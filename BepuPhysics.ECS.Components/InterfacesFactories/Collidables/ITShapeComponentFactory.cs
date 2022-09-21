namespace BepuPhysics.ECS.Components.InterfacesFactories.Collidables
{
    using System;

    using BepuPhysics.ECS.Components.Structs.Collidables;

    public interface ITShapeComponentFactory
    {
        TShapeComponent Create(
            Type value);
    }
}