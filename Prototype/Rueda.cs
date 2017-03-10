using System;

namespace Prototype
{
    public class Rueda : ICloneable
    {
        public int Diametro { get; set; }
        public string Llanta { get; set; }
        public string Neumatico { get; set; }

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion ICloneable Members
    }
}