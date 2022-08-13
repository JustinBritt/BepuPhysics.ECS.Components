namespace BepuPhysics.ECS.Components.InterfacesAbstractFactories
{
    using BepuPhysics.ECS.Components.InterfacesFactories;
    using BepuPhysics.ECS.Components.InterfacesFactories.Collidables;

    public interface IAbstractFactory
    {
        IAngularVelocityComponentFactory CreateAngularVelocityComponentFactory();

        ICollidableMobilityComponentFactory CreateCollidableMobilityComponentFactory();

        ILinearVelocityComponentFactory CreateLinearVelocityComponentFactory();

        IMassComponentFactory CreateMassComponentFactory();

        IPositionComponentFactory CreatePositionComponentFactory();

        IShapeComponentFactory CreateShapeComponentFactory();

        ISimulationComponentFactory CreateSimulationComponentFactory();

        ISleepThresholdComponentFactory CreateSleepThresholdComponentFactory();

        ISpeculativeMarginComponentFactory CreateSpeculativeMarginComponentFactory();
    }
}