// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Plugin
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;


#nullable enable
namespace CMLiteCheat
{
  [BepInPlugin("cmlite.cheat", "CMLite Cheat", "1.0.0")]
  public class Plugin : BasePlugin
  {
    public static ManualLogSource LogSource;

    public virtual void Load()
    {
      Plugin.LogSource = this.Log;
      Plugin.LogSource.LogInfo((object) "Loaded");
      Queer.Gay(this);
    }
  }
}
