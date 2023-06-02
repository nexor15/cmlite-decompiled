// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Modules.Host_Only.TeleportAllBots
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using CMLiteCheat.Optimization;
using CombatMaster.Battle.Gameplay.Player;
using Photon.Bolt;
using UnityEngine;

namespace CMLiteCheat.Module_Manager.Modules.Host_Only
{
  public class TeleportAllBots : CMLiteCheat.Module_Manager.Base.Module.Module
  {
    public TeleportAllBots()
      : base("Teleport All Bots", "Host Only")
    {
    }

    public override void OnUpdate()
    {
      foreach (PlayerHandler.PlayerModel player in Queer.playerHandler.GetPlayerList())
      {
        PlayerRoot myPlayer = PlayerRoot.MyPlayer;
        BoltEntity entity = ((EntityBehaviour) myPlayer)._entity;
        if (!Object.op_Equality((Object) player.PlayerEntity, (Object) ((EntityBehaviour) myPlayer)._entity) && !player.Teammate && ((Component) player.PlayerEntity).GetComponent<PlayerRoot>().IsBotInput)
        {
          Vector3 vector3 = Vector3.op_Multiply(((Component) ((EntityBehaviour) myPlayer)._entity).transform.forward, 2f);
          ((Component) player.PlayerEntity).transform.position = Vector3.op_Addition(((Component) entity).transform.position, vector3);
        }
      }
    }
  }
}
