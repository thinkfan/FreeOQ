﻿// Type: OpenQuant.Shared.Data.Import.NxCore.AdvancedImportSettings
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

namespace OpenQuant.Shared.Data.Import.NxCore
{
  internal class AdvancedImportSettings
  {
    public bool WriteDataAsync { get; set; }

    public int MaxBufferSize { get; set; }

    public AdvancedImportSettings()
    {
      this.WriteDataAsync = true;
      this.MaxBufferSize = 100000;
    }
  }
}
