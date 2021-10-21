namespace Assets.Controller
{
    class Controllers : IInitialization
    {
        #region Fields

        private readonly IExecute[] _executeControllers;
        private readonly IInitialization[] _initializations;

        #endregion


        #region Properties

        public int Length => _executeControllers.Length;

        public IExecute this[int index] => _executeControllers[index];

        #endregion


        #region ClassLifeCycles

        public Controllers()
        {
            _initializations = new IInitialization[1];
            _initializations[0] = new ShipController();
            _executeControllers = new IExecute[1];
            _executeControllers[0] = new ShipController();

        }

        #endregion


        #region IInitialization

        public void Initialization()
        {
            for (var i = 0; i < _initializations.Length; i++)
            {
                var initialization = _initializations[i];
                initialization.Initialization();
            }
            for (var i = 0; i < _executeControllers.Length; i++)
            {
                var execute = _executeControllers[i];
                if (execute is IInitialization initialization)
                {
                    initialization.Initialization();
                }
            }
        }

        #endregion
    }
}
