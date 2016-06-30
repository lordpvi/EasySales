﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySales.Infrastructure.DomainBase
{
    public abstract class EntityBase : IEntity
    {
        private object key;

        protected EntityBase() : this(null)
        {
        }

        protected EntityBase(object key)
        {
            if (key == null)
            {
                key = NewKey();
            }
            this.key = key;
        }

        public object Key
        {
            get { return key; }
        }

        protected virtual object NewKey()
        {
            return Guid.NewGuid();
        }

        #region Equiality
        public override bool Equals(object entity)
        {
            return entity != null
                && entity is EntityBase
                && this == (EntityBase)entity;
        }

        public static bool operator ==(EntityBase base1, EntityBase base2)
        {
            if ((object)base1 == null && (object)base2 == null)
            {
                return true;
            }

            if ((object)base1 == null || (object)base2 == null)
            {
                return false;
            }

            if (!base1.Key.Equals(base2.key))
            {
                return false;
            }
            return true;
        }

        public static bool operator !=(EntityBase base1, EntityBase base2)
        {
            return (!(base1 == base2));
        }

        public override int GetHashCode()
        {
            if (this.key != null)
            {
                return this.key.GetHashCode();
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
