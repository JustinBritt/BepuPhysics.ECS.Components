namespace BepuPhysics.ECS.Components.AbstractFactories
{
    using BepuPhysics.ECS.Components.Factories;
    using BepuPhysics.ECS.Components.Factories.Collidables;
    using BepuPhysics.ECS.Components.InterfacesAbstractFactories;
    using BepuPhysics.ECS.Components.InterfacesFactories;
    using BepuPhysics.ECS.Components.InterfacesFactories.Collidables;

    public sealed class AbstractFactory : IAbstractFactory
    {
        public AbstractFactory()
        {
        }

        public static IAbstractFactory Create()
        {
            return new AbstractFactory();
        }

        public IAngularVelocityComponentFactory CreateAngularVelocityComponentFactory()
        {
            IAngularVelocityComponentFactory factory = null;

            try
            {
                factory = new AngularVelocityComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ICollidableMobilityComponentFactory CreateCollidableMobilityComponentFactory()
        {
            ICollidableMobilityComponentFactory factory = null;

            try
            {
                factory = new CollidableMobilityComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ILinearVelocityComponentFactory CreateLinearVelocityComponentFactory()
        {
            ILinearVelocityComponentFactory factory = null;

            try
            {
                factory = new LinearVelocityComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IMassComponentFactory CreateMassComponentFactory()
        {
            IMassComponentFactory factory = null;

            try
            {
                factory = new MassComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IMaximumSpeculativeMarginComponentFactory CreateMaximumSpeculativeMarginComponentFactory()
        {
            IMaximumSpeculativeMarginComponentFactory factory = null;

            try
            {
                factory = new MaximumSpeculativeMarginComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IMinimumSpeculativeMarginComponentFactory CreateMinimumSpeculativeMarginComponentFactory()
        {
            IMinimumSpeculativeMarginComponentFactory factory = null;

            try
            {
                factory = new MinimumSpeculativeMarginComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IPositionComponentFactory CreatePositionComponentFactory()
        {
            IPositionComponentFactory factory = null;

            try
            {
                factory = new PositionComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IShapeComponentFactory CreateShapeComponentFactory()
        {
            IShapeComponentFactory factory = null;

            try
            {
                factory = new ShapeComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISimulationComponentFactory CreateSimulationComponentFactory()
        {
            ISimulationComponentFactory factory = null;

            try
            {
                factory = new SimulationComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISleepThresholdComponentFactory CreateSleepThresholdComponentFactory()
        {
            ISleepThresholdComponentFactory factory = null;

            try
            {
                factory = new SleepThresholdComponentFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISpeculativeMarginComponentFactory CreateSpeculativeMarginComponentFactory()
        {
            ISpeculativeMarginComponentFactory factory = null;

            try
            {
                factory = new SpeculativeMarginComponentFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}