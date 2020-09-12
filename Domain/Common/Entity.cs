using Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    public abstract class Entity<TData> where TData : UniqueEntityData, new()
    {
        protected internal Entity(TData d = null) => Data = d;
        public TData Data { get; set; }
    }
}
