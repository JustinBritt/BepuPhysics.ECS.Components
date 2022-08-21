namespace BepuPhysics.ECS.Components.Structs.Collidables
{
    using BepuPhysics.Collidables;

    public struct ShapeComponent
    {
        public ShapeComponent(
            IShape value)
        {
            this.Value = value;
        }

        public IShape Value { get; set; }
    }
}