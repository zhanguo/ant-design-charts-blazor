﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AntDesign.Charts
{
    public partial class Heatmap<TItem> : ChartComponentBase<IEnumerable<TItem>, HeatmapConfig>
    {
        public Heatmap() : base("Heatmap")
        {

        }
    }
}