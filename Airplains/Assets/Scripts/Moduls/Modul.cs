
namespace Assets.Moduls
{
    public abstract class Modul
    {
        #region Methods

        public virtual void AddBonusStat(ref float stat, float bonus)
        {
            stat += bonus;
        }
        public virtual void MultiplyStat(ref float stat, float bonus)
        {
            stat *= bonus;
        }

        #endregion
    }
}
