﻿// Type: OpenQuant.RunnerError
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

namespace OpenQuant
{
  internal class RunnerError
  {
    private string text;

    public string Text
    {
      get
      {
        return this.text;
      }
    }

    public RunnerError(string text)
    {
      this.text = text;
    }
  }
}