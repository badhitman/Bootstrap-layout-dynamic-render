using System;
using System.Collections.Generic;
using System.Text;

namespace BootstrapAspDynamicRender.service
{
    public abstract class asCloneableObject : ICloneable
    {
        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
