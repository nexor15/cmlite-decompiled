// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Base.Settings.Setting
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll


#nullable enable
namespace CMLiteCheat.Module_Manager.Base.Settings
{
  public abstract class Setting
  {
    public abstract object GetValue();

    public abstract void SetValue(object value);
  }
}
