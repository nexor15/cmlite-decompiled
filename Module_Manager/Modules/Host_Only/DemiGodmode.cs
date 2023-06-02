// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Modules.Host_Only.DemiGodmode
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using CombatMaster.Battle.Gameplay.Player;
using Photon.Bolt;
using Photon.Bolt.Internal;
using UnityEngine;

namespace CMLiteCheat.Module_Manager.Modules.Host_Only
{
  public class DemiGodmode : CMLiteCheat.Module_Manager.Base.Module.Module
  {
    public DemiGodmode()
      : base("Demi-Godmode", "Host Only")
    {
    }

    public override void OnUpdate()
    {
      PlayerRoot myPlayer = PlayerRoot.MyPlayer;
      if (Object.op_Equality((Object) myPlayer, (Object) null))
        return;
      ((EntityEventListenerBase<IPlayerState>) myPlayer).state.Armor = 1000000;
    }

    protected override void OnDisable()
    {
      PlayerRoot myPlayer = PlayerRoot.MyPlayer;
      if (Object.op_Equality((Object) myPlayer, (Object) null))
        return;
      ((EntityEventListenerBase<IPlayerState>) myPlayer).state.Armor = 0;
    }
  }
}
