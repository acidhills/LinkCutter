﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Contracts
{
    public interface ILinkStatisticService
    {
        void IncrementLinkStat(int linkId);
    }
}
