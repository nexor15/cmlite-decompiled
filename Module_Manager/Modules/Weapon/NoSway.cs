// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Modules.Weapon.NoSway
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using CombatMaster.GDI;
using System.Collections.Generic;
using UnityEngine;


#nullable enable
namespace CMLiteCheat.Module_Manager.Modules.Weapon
{
  public class NoSway : CMLiteCheat.Module_Manager.Base.Module.Module
  {
    private readonly List<(WeaponInfo, WeaponSwaySettings)> originalValues = new List<(WeaponInfo, WeaponSwaySettings)>();

    public NoSway()
      : base("No Sway", "Weapon")
    {
    }

    protected override void OnEnable()
    {
      foreach (WeaponInfo weaponInfo in Resources.FindObjectsOfTypeAll<WeaponInfo>())
      {
        WeaponSwaySettings swaySettings = weaponInfo.SwaySettings;
        this.originalValues.Add((weaponInfo, swaySettings));
        swaySettings.AngleRotation = 0.0f;
        weaponInfo.SwaySettings = swaySettings;
      }
    }

    protected override void OnDisable()
    {
      foreach ((WeaponInfo, WeaponSwaySettings) originalValue in this.originalValues)
        originalValue.Item1.SwaySettings = originalValue.Item2;
      this.originalValues.Clear();
    }
  }
}
