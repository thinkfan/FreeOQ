using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXMDReqRejReason : FIXCharField
  {
    public const char UnknownSymbol = '0';
    public const char DuplicateMDReqID = '1';
    public const char InsufficientBandwidth = '2';
    public const char InsufficientPermissions = '3';
    public const char UnsupportedSubscriptionRequestType = '4';
    public const char UnsupportedMarketDepth = '5';
    public const char UnsupportedMDUpdateType = '6';
    public const char UnsupportedAggregatedBook = '7';
    public const char UnsupportedMDEntryType = '8';
    public const char UnsupportedTradingSessionID = '9';
    public const char UnsupportedScope = 'A';
    public const char UnsupportedOpenCloseSettleFlag = 'B';
    public const char UnsupportedMDImplicitDelete = 'C';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXMDReqRejReason(char value) : base(281, value)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static MDReqRejReason FromFIX(char value)
    {
      switch (value)
      {
        case '0':
          return MDReqRejReason.UnknownSymbol;
        case '1':
          return MDReqRejReason.DuplicateMDReqID;
        case '2':
          return MDReqRejReason.InsufficientBandwidth;
        case '3':
          return MDReqRejReason.InsufficientPermissions;
        case '4':
          return MDReqRejReason.UnsupportedSubscriptionRequestType;
        case '5':
          return MDReqRejReason.UnsupportedMarketDepth;
        case '6':
          return MDReqRejReason.UnsupportedMDUpdateType;
        case '7':
          return MDReqRejReason.UnsupportedAggregatedBook;
        case '8':
          return MDReqRejReason.UnsupportedMDEntryType;
        case '9':
          return MDReqRejReason.UnsupportedTradingSessionID;
        case 'A':
          return MDReqRejReason.UnsupportedScope;
        case 'B':
          return MDReqRejReason.UnsupportedOpenCloseSettleFlag;
        case 'C':
          return MDReqRejReason.UnsupportedMDImplicitDelete;
        default:
					throw new ArgumentException(string.Format("", (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char ToFIX(MDReqRejReason reason)
    {
      switch (reason)
      {
        case MDReqRejReason.UnknownSymbol:
          return '0';
        case MDReqRejReason.DuplicateMDReqID:
          return '1';
        case MDReqRejReason.InsufficientBandwidth:
          return '2';
        case MDReqRejReason.InsufficientPermissions:
          return '3';
        case MDReqRejReason.UnsupportedSubscriptionRequestType:
          return '4';
        case MDReqRejReason.UnsupportedMarketDepth:
          return '5';
        case MDReqRejReason.UnsupportedMDUpdateType:
          return '6';
        case MDReqRejReason.UnsupportedAggregatedBook:
          return '7';
        case MDReqRejReason.UnsupportedMDEntryType:
          return '8';
        case MDReqRejReason.UnsupportedTradingSessionID:
          return '9';
        case MDReqRejReason.UnsupportedScope:
          return 'A';
        case MDReqRejReason.UnsupportedOpenCloseSettleFlag:
          return 'B';
        case MDReqRejReason.UnsupportedMDImplicitDelete:
          return 'C';
        default:
					throw new ArgumentException(string.Format("", (object) reason));
      }
    }
  }
}
