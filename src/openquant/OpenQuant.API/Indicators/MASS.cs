using OpenQuant.API;
using FreeQuant.Indicators;
using System.ComponentModel;
using System.Drawing;

namespace OpenQuant.API.Indicators
{
  public class MASS : Indicator
  {
    [Category("Parameters")]
    [Description("Length")]
    public int Length
    {
      get
      {
        return (this.indicator as MASS).get_Length();
      }
      set
      {
        (this.indicator as MASS).set_Length(value);
      }
    }

    [Category("Parameters")]
    [Description("Order")]
    public int Order
    {
      get
      {
        return (this.indicator as MASS).get_Order();
      }
      set
      {
        (this.indicator as MASS).set_Order(value);
      }
    }

    private MASS()
    {
      this.indicator = (Indicator) new MASS();
    }

    public MASS(OpenQuant.API.BarSeries series, int length, int order)
    {
      this.indicator = (Indicator) new MASS((SmartQuant.Series.TimeSeries) series.series, length, order);
    }

    public MASS(Indicator indicator, int length, int order)
    {
      this.indicator = (Indicator) new MASS((SmartQuant.Series.TimeSeries) indicator.indicator, length, order);
    }

    public MASS(OpenQuant.API.BarSeries series, int length, int order, Color color)
    {
      this.indicator = (Indicator) new MASS((SmartQuant.Series.TimeSeries) series.series, length, order, color);
    }

    public MASS(Indicator indicator, int length, int order, Color color)
    {
      this.indicator = (Indicator) new MASS((SmartQuant.Series.TimeSeries) indicator.indicator, length, order, color);
    }
  }
}
