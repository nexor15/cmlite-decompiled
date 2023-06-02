// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Modules.Visuals.RemovePlayfabId
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using CombatMaster.View.UI.Gameplay;
using UnityEngine;

namespace CMLiteCheat.Module_Manager.Modules.Visuals
{
  public class RemovePlayfabId : CMLiteCheat.Module_Manager.Base.Module.Module
  {
    public RemovePlayfabId()
      : base("Remove PlayfabID", "Visuals")
    {
    }

    protected override void OnEnable()
    {
      foreach (Object @object in Resources.FindObjectsOfTypeAll<BattleInfoPanel>())
        Object.Destroy(@object);
    }
  }
}
