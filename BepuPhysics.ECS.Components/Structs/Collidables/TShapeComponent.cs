namespace BepuPhysics.ECS.Components.Structs.Collidables
{
    using System;

    public struct TShapeComponent
    {
        public TShapeComponent(
            Type value)
        {
            this.Value = value;
        }

        public Type Value { get; set; }
    }
}