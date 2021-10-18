namespace Assets.Moduls
{
    class ModulB : Modul
    {
        #region Fields

        private float _bonusHealth = 50;

        #endregion


        #region ClassLifeCycle
        public ModulB(ref float stat)
        {
            AddBonusStat(ref stat, _bonusHealth);
        }

        #endregion
    }
}
