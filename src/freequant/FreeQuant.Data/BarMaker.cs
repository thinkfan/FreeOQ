﻿// Type: SmartQuant.Data.BarMaker
// Assembly: SmartQuant.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=844f265c18b031f9
// MVID: FAB3F3C9-6D4A-4391-AE43-0CE5E1C624DD
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Data.dll

using oL6nXjcX2wYBRbhX2q;
using RadDBE9P5I945u5gCE;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Data
{
  public class BarMaker
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    private BarMaker()
    {
      G6i5ebBrLpy1MqcD3T.h6SXMcqzRIE7j();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MakeBars(IDataSeries tradeSeries, IDataSeries barSeries, BarType barType, long barSize)
    {
      switch (barType)
      {
        case BarType.Time:
          Bar bar1 = (Bar) null;
          foreach (Trade trade in (IEnumerable) tradeSeries)
          {
            if (bar1 == null || bar1.EndTime <= trade.DateTime)
            {
              if (bar1 != null)
                barSeries.Add(bar1.DateTime, (object) bar1);
              DateTime beginTime = BarMaker.qtghhEheM(trade.DateTime, barSize);
              bar1 = new Bar(BarType.Time, barSize, beginTime, beginTime.AddSeconds((double) barSize), trade.Price, trade.Price, trade.Price, trade.Price, (long) trade.Size, 0L);
            }
            else
            {
              if (trade.Price > bar1.High)
                bar1.High = trade.Price;
              if (trade.Price < bar1.Low)
                bar1.Low = trade.Price;
              bar1.Close = trade.Price;
              bar1.Volume += (long) trade.Size;
            }
          }
          if (bar1 != null)
            barSeries.Add(bar1.DateTime, (object) bar1);
          barSeries.Flush();
          break;
        case BarType.Tick:
          Bar bar2 = (Bar) null;
          int num = 0;
          foreach (Trade trade in (IEnumerable) tradeSeries)
          {
            if (bar2 == null)
            {
              bar2 = new Bar(BarType.Tick, barSize, trade.DateTime, trade.DateTime, trade.Price, trade.Price, trade.Price, trade.Price, (long) trade.Size, 0L);
              num = 1;
            }
            else
            {
              bar2.EndTime = trade.DateTime;
              if (trade.Price > bar2.High)
                bar2.High = trade.Price;
              if (trade.Price < bar2.Low)
                bar2.Low = trade.Price;
              bar2.Close = trade.Price;
              bar2.Volume += (long) trade.Size;
              ++num;
            }
            if ((long) num == barSize)
            {
              barSeries.Add(bar2.DateTime, (object) bar2);
              bar2 = (Bar) null;
            }
          }
          if (bar2 != null)
            barSeries.Add(bar2.DateTime, (object) bar2);
          barSeries.Flush();
          break;
        case BarType.Volume:
          Bar bar3 = (Bar) null;
          foreach (Trade trade in (IEnumerable) tradeSeries)
          {
            if (bar3 == null)
            {
              bar3 = new Bar(BarType.Volume, barSize, trade.DateTime, trade.DateTime, trade.Price, trade.Price, trade.Price, trade.Price, (long) trade.Size, 0L);
            }
            else
            {
              bar3.EndTime = trade.DateTime;
              if (trade.Price > bar3.High)
                bar3.High = trade.Price;
              if (trade.Price < bar3.Low)
                bar3.Low = trade.Price;
              bar3.Close = trade.Price;
              bar3.Volume += (long) trade.Size;
            }
            if (bar3.Volume >= barSize)
            {
              barSeries.Add(bar3.DateTime, (object) bar3);
              bar3 = (Bar) null;
            }
          }
          if (bar3 != null)
            barSeries.Add(bar3.DateTime, (object) bar3);
          barSeries.Flush();
          break;
        case BarType.Range:
          Bar bar4 = (Bar) null;
          foreach (Trade trade in (IEnumerable) tradeSeries)
          {
            DateTime dateTime = trade.DateTime;
            double price = trade.Price;
            long volume = (long) trade.Size;
            if (bar4 == null)
            {
              bar4 = new Bar(BarType.Range, barSize, dateTime, dateTime, price, price, price, price, volume, 0L);
            }
            else
            {
              bar4.EndTime = dateTime;
              if (price > bar4.High)
                bar4.High = price;
              if (price < bar4.Low)
                bar4.Low = price;
              bar4.Volume += volume;
              bool flag = false;
              while (!flag)
              {
                if (10000.0 * (bar4.High - bar4.Low) >= (double) barSize)
                {
                  Bar bar5 = new Bar(BarType.Range, barSize, dateTime, dateTime, price, price, price, price, 0L, 0L);
                  if (bar4.High == price)
                  {
                    bar4.High = bar4.Low + (double) barSize / 10000.0;
                    bar4.Close = bar4.High;
                    bar5.Low = bar4.High;
                  }
                  if (bar4.Low == price)
                  {
                    bar4.Low = bar4.High - (double) barSize / 10000.0;
                    bar4.Close = bar4.Low;
                    bar5.High = bar4.Low;
                  }
                  barSeries.Add(bar4.DateTime, (object) bar4);
                  bar4 = bar5;
                  flag = 10000.0 * (bar5.High - bar5.Low) < (double) barSize;
                }
                else
                  flag = true;
              }
            }
          }
          if (bar4 != null)
            barSeries.Add(bar4.DateTime, (object) bar4);
          barSeries.Flush();
          break;
        default:
          throw new NotImplementedException(SgtGY0EZpHQ7maRIwn.MEKJ4a3Ol(0) + ((object) barType).ToString());
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DateTime qtghhEheM([In] DateTime obj0, [In] long obj1)
    {
      long num = (long) obj0.TimeOfDay.TotalSeconds / obj1 * obj1;
      return obj0.Date.AddSeconds((double) num);
    }
  }
}