// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Modules.Movement.LowGravity
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using CMLiteCheat.Module_Manager.Base;
using CombatMaster.GDI;
using System.Collections.Generic;
using UnityEngine;


#nullable enable
namespace CMLiteCheat.Module_Manager.Modules.Movement
{
  public class LowGravity : CMLiteCheat.Module_Manager.Base.Module.Module
  {
    private readonly Dictionary<OperatorsGdInfoSection, float> savedOperators = new Dictionary<OperatorsGdInfoSection, float>();

    public LowGravity()
      : base("Low Gravity", "Movement")
    {
    }

    protected override void OnEnable()
    {
      ModuleUtils.DisableModule<JumpFly>();
      foreach (OperatorsGdInfoSection key in Resources.FindObjectsOfTypeAll<OperatorsGdInfoSection>())
      {
        this.savedOperators.Add(key, key.GravityForce);
        key.GravityForce = 1f / 500f;
      }
    }

    protected override void OnDisable()
    {
      foreach (KeyValuePair<OperatorsGdInfoSection, float> savedOperator in this.savedOperators)
        savedOperator.Key.GravityForce = savedOperator.Value;
    }
  }
}
