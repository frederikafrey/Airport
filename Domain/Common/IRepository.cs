﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    public interface IRepository<T> : ICrudMethods<T>, ISorting, IFiltering, IPaging { }
}
