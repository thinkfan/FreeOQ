using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXEmailEventArgs : EventArgs
  {
    private FIXEmail mnGQ7PEsVN;

    public FIXEmail Email
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.mnGQ7PEsVN;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.mnGQ7PEsVN = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXEmailEventArgs(FIXEmail Email): base()
    {
      this.mnGQ7PEsVN = Email;
    }
  }
}
