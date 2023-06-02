// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Base.Module.ModuleSettings
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using CMLiteCheat.Module_Manager.Base.Settings;
using System;
using System.Collections.Generic;


#nullable enable
namespace CMLiteCheat.Module_Manager.Base.Module
{
  public class ModuleSettings
  {
    public readonly Dictionary<string, Setting> SettingsList;

    public ModuleSettings() => this.SettingsList = new Dictionary<string, Setting>();

    public void AddSetting(string name, Setting setting) => this.SettingsList[name] = setting;

    public T GetSettingValue<T>(string name)
    {
      Setting setting;
      if (this.SettingsList.TryGetValue(name, out setting))
        return (T) setting.GetValue();
      throw new ArgumentException("Setting " + name + " does not exist");
    }

    public void SetSettingValue(string name, object value)
    {
      Setting setting;
      if (!this.SettingsList.TryGetValue(name, out setting))
        throw new ArgumentException("Setting " + name + " does not exist");
      setting.SetValue(value);
    }
  }
}
