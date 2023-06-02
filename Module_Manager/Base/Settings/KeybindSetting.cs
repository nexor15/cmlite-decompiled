// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Base.Settings.KeybindSetting
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using UnityEngine;


#nullable enable
namespace CMLiteCheat.Module_Manager.Base.Settings
{
  public class KeybindSetting : Setting
  {
    public KeyCode Value;

    public KeybindSetting(KeyCode value) => this.Value = value;

    public override object GetValue() => (object) this.Value;

    public override void SetValue(object value) => this.Value = (KeyCode) value;
  }
}
