﻿using grapher.Models.Serialized;

namespace grapher.Layouts
{
    public class OffLayout : LayoutBase
    {
        public OffLayout()
            : base()
        {
            Name = "Off";
            Index = (int)AccelMode.noaccel;
            LogarithmicCharts = false;

            GainSwitchOptionLayout = new OptionLayout(false, string.Empty);
            AccelLayout = new OptionLayout(false, string.Empty);
            ScaleLayout = new OptionLayout(false, string.Empty);
            CapLayout = new OptionLayout(false, string.Empty);
            WeightLayout = new OptionLayout(false, string.Empty);
            OffsetLayout = new OptionLayout(false, string.Empty);
            LimitLayout = new OptionLayout(false, string.Empty);
            ExponentLayout = new OptionLayout(false, string.Empty);
            MidpointLayout = new OptionLayout(false, string.Empty);
            LUTTextLayout = new OptionLayout(false, string.Empty);
        }
    }
}
