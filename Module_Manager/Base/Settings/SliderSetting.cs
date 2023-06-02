// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Base.Settings.SliderSetting
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll


#nullable enable
namespace CMLiteCheat.Module_Manager.Base.Settings
{
  public class SliderSetting : Setting
  {
    public float Value;
    public readonly float MinValue;
    public readonly float MaxValue;

    public SliderSetting(float value, float minValue, float maxValue)
    {
      this.Value = value;
      this.MinValue = minValue;
      this.MaxValue = maxValue;
    }

    public override object GetValue() => (object) this.Value;

    public override void SetValue(object value) => this.Value = (float) value;
  }
}
