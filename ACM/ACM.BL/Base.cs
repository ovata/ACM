using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public abstract class Base
    {
        public bool IsNew { get; private set; }
        public bool HasChanged { get; set; }
        public EntityStateOption EntityState { get; set; }
        public bool IsValid => Validate();

        public abstract bool Validate();
    }

    public enum EntityStateOption
    {
        Active = 1,
        Deleted
    }
}
