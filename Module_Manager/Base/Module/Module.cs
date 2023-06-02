// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Base.Module.Module
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using UnityEngine;


#nullable enable
namespace CMLiteCheat.Module_Manager.Base.Module
{
  public abstract class Module
  {
    public readonly string ModuleName;
    public readonly string CategoryName;
    public readonly KeyCode KeyBind;
    public bool WaitingForBind;
    public bool Enabled;
    public readonly bool Hidden;
    public readonly ModuleSettings? Settings;

    protected Module(
      string moduleName,
      string categoryName,
      bool hidden = false,
      ModuleSettings? settings = null,
      KeyCode keyBind = 0)
    {
      this.ModuleName = moduleName;
      this.CategoryName = categoryName;
      this.KeyBind = keyBind;
      this.Hidden = hidden;
      this.Settings = settings;
      this.WaitingForBind = false;
      if (this.Settings == null)
        return;
      this.AddSettings();
    }

    protected virtual void AddSettings()
    {
    }

    protected virtual void OnEnable()
    {
    }

    protected virtual void OnDisable()
    {
    }

    public virtual void OnCheatLoad()
    {
    }

    public virtual void OnUpdate()
    {
    }

    public virtual void OnGUI()
    {
    }

    public virtual void OnGUIAlways()
    {
    }

    public void Toggle()
    {
      this.Enabled = !this.Enabled;
      if (this.Enabled)
        this.OnEnable();
      else
        this.OnDisable();
    }
  }
}
