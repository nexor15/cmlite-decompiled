// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Modules.Host_Only.FreezeAll
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using CMLiteCheat.Optimization;
using CombatMaster.Battle.Gameplay.Player;
using Photon.Bolt;

namespace CMLiteCheat.Module_Manager.Modules.Host_Only
{
  public class FreezeAll : CMLiteCheat.Module_Manager.Base.Module.Module
  {
    public FreezeAll()
      : base("Freeze All", "Host Only")
    {
    }

    protected override void OnEnable()
    {
      foreach (PlayerHandler.PlayerModel player in Queer.playerHandler.GetPlayerList())
      {
        if (NetworkId.op_Inequality(player.PlayerEntity.NetworkId, ((EntityBehaviour) PlayerRoot.MyPlayer)._entity.NetworkId))
          BoltNetwork.FindEntity(player.PlayerEntity.NetworkId).Freeze(true);
      }
    }

    protected override void OnDisable()
    {
      foreach (PlayerHandler.PlayerModel player in Queer.playerHandler.GetPlayerList())
      {
        if (NetworkId.op_Inequality(player.PlayerEntity.NetworkId, ((EntityBehaviour) PlayerRoot.MyPlayer)._entity.NetworkId))
          BoltNetwork.FindEntity(player.PlayerEntity.NetworkId).Freeze(false);
      }
    }
  }
}
