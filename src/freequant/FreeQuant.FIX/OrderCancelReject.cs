﻿// Type: SmartQuant.FIX.OrderCancelReject
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class OrderCancelReject : FIXOrderCancelReject
  {
    public OrdStatus OrdStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXOrdStatus.FromFIX(base.OrdStatus);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.OrdStatus = FIXOrdStatus.ToFIX(value);
      }
    }

    public CxlRejResponseTo CxlRejResponseTo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXCxlRejResponseTo.FromFIX(base.CxlRejResponseTo);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.CxlRejResponseTo = FIXCxlRejResponseTo.ToFIX(value);
      }
    }

    public CxlRejReason CxlRejReason
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return FIXCxlRejReason.FromFIX(base.CxlRejReason);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        base.CxlRejReason = FIXCxlRejReason.ToFIX(value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OrderCancelReject()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}