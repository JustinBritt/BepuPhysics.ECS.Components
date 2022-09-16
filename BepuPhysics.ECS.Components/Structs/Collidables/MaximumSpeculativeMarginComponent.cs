namespace BepuPhysics.ECS.Components.Structs.Collidables
{
    public struct MaximumSpeculativeMarginComponent
    {
        public MaximumSpeculativeMarginComponent(
            float value)
        {
            this.Value = value;
        }

        public float Value { get; set; }
    }
}