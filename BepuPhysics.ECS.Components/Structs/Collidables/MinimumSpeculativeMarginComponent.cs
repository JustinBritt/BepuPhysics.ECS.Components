namespace BepuPhysics.ECS.Components.Structs.Collidables
{
    public struct MinimumSpeculativeMarginComponent
    {
        public MinimumSpeculativeMarginComponent(
            float value)
        {
            this.Value = value;
        }

        public float Value { get; set; }
    }
}