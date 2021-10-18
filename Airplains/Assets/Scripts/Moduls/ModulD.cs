namespace Assets.Moduls
{
    class ModulD : Modul
    {
        #region Fields

        private float _bonusShieldRegen = 0.2f;

        #endregion


        #region ClassLifeCycle

        public ModulD(ref float stat)
        {
            MultiplyStat(ref stat, _bonusShieldRegen);
        }

        #endregion
    }
}
