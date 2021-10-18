namespace Assets.Moduls
{
    class ModulA : Modul
    {
        #region Fields

        private float _bonusShield = 50;

        #endregion


        #region ClassLifeCycle
        public ModulA(ref float stat)
        {
            AddBonusStat(ref stat, _bonusShield);
        }

        #endregion
    }
}
