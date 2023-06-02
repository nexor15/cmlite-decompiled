// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Modules.Host_Only.StartSinglePlayer
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using HarmonyLib;
using Photon.Bolt;
using System;
using System.Reflection;

namespace CMLiteCheat.Module_Manager.Modules.Host_Only
{
  public class StartSinglePlayer : CMLiteCheat.Module_Manager.Base.Module.Module
  {
    public StartSinglePlayer()
      : base("Force Single Player (With XP)", "Host Only")
    {
    }

    protected override void OnEnable()
    {
      MethodInfo method1 = typeof (BoltLauncher).GetMethod("StartClient", new Type[1]
      {
        typeof (int)
      });
      MethodInfo method2 = typeof (StartSinglePlayer.patchJoinSession).GetMethod("joinSessionPatch");
      Queer.Harmony.Patch((MethodBase) method1, new HarmonyMethod(method2), (HarmonyMethod) null, (HarmonyMethod) null, (HarmonyMethod) null, (HarmonyMethod) null);
    }

    protected override void OnDisable()
    {
      MethodInfo method = typeof (BoltLauncher).GetMethod("StartClient");
      Queer.Harmony.Unpatch((MethodBase) method, (HarmonyPatchType) 1, "CMLite");
    }

    private class patchJoinSession
    {
      public static bool joinSessionPatch() => false;
    }
  }
}
