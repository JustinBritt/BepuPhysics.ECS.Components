namespace BepuPhysics.ECS.Components.Structs
{
    public struct MassComponent
    {
        public MassComponent(
            float value)
        {
            this.Value = value;
        }

        public float Value { get; }
    }
}