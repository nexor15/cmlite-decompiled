// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Utils.PlayFabInformation
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using System.Collections.Generic;
using System.Diagnostics;


#nullable enable
namespace CMLiteCheat.Utils
{
  public class PlayFabInformation
  {
    public class BoughtShopBundle
    {
      [field: DebuggerBrowsable]
      public int _uid { get; set; }
    }

    public class Loot
    {
      [field: DebuggerBrowsable]
      public List<PlayFabInformation.BoughtShopBundle> _boughtShopBundles { get; set; }
    }

    public class Root
    {
      [field: DebuggerBrowsable]
      public PlayFabInformation.Loot Loot { get; set; }
    }
  }
}
