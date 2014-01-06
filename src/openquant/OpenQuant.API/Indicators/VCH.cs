﻿// Type: OpenQuant.API.Indicators.VCH
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class VCH : Indicator
  {
    [Description("Length1")]
    [Category("Parameters")]
    public int Length1
    {
      get
      {
        return (this.indicator as VCH).get_Length1();
      }
      set
      {
        (this.indicator as VCH).set_Length1(value);
      }
    }

    [Category("Parameters")]
    [Description("Length2")]
    public int Length2
    {
      get
      {
        return (this.indicator as VCH).get_Length2();
      }
      set
      {
        (this.indicator as VCH).set_Length2(value);
      }
    }

    private VCH()
    {
      this.indicator = (Indicator) new VCH();
    }

    public VCH(OpenQuant.API.BarSeries series, int length1, int length2)
    {
      this.indicator = (Indicator) new VCH((SmartQuant.Series.TimeSeries) series.series, length1, length2);
    }

    public VCH(Indicator indicator, int length1, int length2)
    {
      this.indicator = (Indicator) new VCH((SmartQuant.Series.TimeSeries) indicator.indicator, length1, length2);
    }

    public VCH(OpenQuant.API.BarSeries series, int length1, int length2, Color color)
    {
      this.indicator = (Indicator) new VCH((SmartQuant.Series.TimeSeries) series.series, length1, length2, color);
    }

    public VCH(Indicator indicator, int length1, int length2, Color color)
    {
      this.indicator = (Indicator) new VCH((SmartQuant.Series.TimeSeries) indicator.indicator, length1, length2, color);
    }
  }
}