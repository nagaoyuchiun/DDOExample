﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interface.IProvider
{
    public interface ITimeProvider
    {
        DateTime GetNow();
    }
}
