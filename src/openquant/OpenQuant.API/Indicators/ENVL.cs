﻿// Type: OpenQuant.API.Indicators.ENVL
// Assembly: OpenQuant.API, Version=1.0.5037.20290, Culture=neutral, PublicKeyToken=null
// MVID: EDDC005E-5962-4767-9721-B9BF91924AC8
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.API.dll

using OpenQuant.API;
using SmartQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class ENVL : Indicator
  {
    [Description("Length")]
    [Category("Parameters")]
    public int Length
    {
      get
      {
        return (this.indicator as ENVL).get_Length();
      }
      set
      {
        (this.indicator as ENVL).set_Length(value);
      }
    }

    [Category("Parameters")]
    [Description("Shift")]
    public double Shift
    {
      get
      {
        return (this.indicator as ENVL).get_Shift();
      }
      set
      {
        (this.indicator as ENVL).set_Shift(value);
      }
    }

    private ENVL()
    {
      this.indicator = (Indicator) new ENVL();
    }

    public ENVL(OpenQuant.API.BarSeries series, int length, int shift)
    {
      this.indicator = (Indicator) new ENVL((SmartQuant.Series.TimeSeries) series.series, length, (double) shift);
    }

    public ENVL(Indicator indicator, int length, int shift)
    {
      this.indicator = (Indicator) new ENVL((SmartQuant.Series.TimeSeries) indicator.indicator, length, (double) shift);
    }

    public ENVL(OpenQuant.API.BarSeries series, int length, int shift, BarData option)
    {
      this.indicator = (Indicator) new ENVL((SmartQuant.Series.TimeSeries) series.series, length, (double) shift, OpenQuant.API.EnumConverter.Convert(option));
    }

    public ENVL(Indicator indicator, int length, int shift, BarData option)
    {
      this.indicator = (Indicator) new ENVL((SmartQuant.Series.TimeSeries) indicator.indicator, length, (double) shift, OpenQuant.API.EnumConverter.Convert(option));
    }

    public ENVL(OpenQuant.API.BarSeries series, int length, int shift, Color color)
    {
      this.indicator = (Indicator) new ENVL((SmartQuant.Series.TimeSeries) series.series, length, (double) shift, color);
    }

    public ENVL(Indicator indicator, int length, int shift, Color color)
    {
      this.indicator = (Indicator) new ENVL((SmartQuant.Series.TimeSeries) indicator.indicator, length, (double) shift, color);
    }

    public ENVL(OpenQuant.API.BarSeries series, int length, int shift, BarData option, Color color)
    {
      this.indicator = (Indicator) new ENVL((SmartQuant.Series.TimeSeries) series.series, length, (double) shift, OpenQuant.API.EnumConverter.Convert(option), color);
    }

    public ENVL(Indicator indicator, int length, int shift, BarData option, Color color)
    {
      this.indicator = (Indicator) new ENVL((SmartQuant.Series.TimeSeries) indicator.indicator, length, (double) shift, OpenQuant.API.EnumConverter.Convert(option), color);
    }
  }
}