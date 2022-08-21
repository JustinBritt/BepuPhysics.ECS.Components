namespace BepuPhysics.ECS.Components.Structs.Collidables
{
    public struct SpeculativeMarginComponent
    {
        public SpeculativeMarginComponent(
            float value)
        {
            this.Value = value;
        }

        public float Value { get; set; }
    }
}