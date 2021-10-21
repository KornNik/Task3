using System;

namespace Assets.Services
{
    sealed class Services
    {
        #region Fields

        private static readonly Lazy<Services> _instance = new Lazy<Services>();

        #endregion


        #region ClassLifeCycles

        public Services()
        {
            Initialize();
        }

        #endregion


        #region Properties

        public static Services Instance => _instance.Value;

        public ShipServices ShipServices { get; private set; }


        #endregion


        #region Methods

        private void Initialize()
        {
            ShipServices = new ShipServices();
        }

        #endregion
    }
}

