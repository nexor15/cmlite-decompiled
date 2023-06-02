// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Base.Settings.ToggleBoxSetting
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll


#nullable enable
namespace CMLiteCheat.Module_Manager.Base.Settings
{
  public class ToggleBoxSetting : Setting
  {
    public bool Value;

    public ToggleBoxSetting(bool value) => this.Value = value;

    public override object GetValue() => (object) this.Value;

    public override void SetValue(object value) => this.Value = (bool) value;
  }
}
