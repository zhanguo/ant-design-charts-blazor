﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AntDesign.Charts
{
    public partial class RingProgress<TItem> : ChartComponentBase<TItem, RingProgressConfig>
    {
        public RingProgress() : base("RingProgress")
        {

        }
    }
}