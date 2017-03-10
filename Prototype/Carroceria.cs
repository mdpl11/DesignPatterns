using System;

namespace Prototype
{
    public class Carroceria : ICloneable
    {
        public bool HabitaculoReforzado { get; set; }
        public string Material { get; set; }
        public string TipoCarroceria { get; set; }

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion ICloneable Members
    }
}