namespace BepuPhysics.ECS.Components.Structs
{
    public struct SleepThresholdComponent
    {
        public SleepThresholdComponent(
            float value)
        {
            this.Value = value;
        }

        public float Value { get; set; }
    }
}