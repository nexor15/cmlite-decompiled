﻿// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Modules.Movement.SpeedHack
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using HarmonyLib;
using Photon.Bolt;
using System.Reflection;

namespace CMLiteCheat.Module_Manager.Modules.Movement
{
  public class SpeedHack : CMLiteCheat.Module_Manager.Base.Module.Module
  {
    public SpeedHack()
      : base("Speed Hack", "Movement")
    {
    }

    protected override void OnEnable()
    {
      MethodInfo methodInfo1 = AccessTools.PropertySetter(typeof (PlayerCommandInput), "IsFalling");
      MethodInfo method1 = typeof (SpeedHack.patchMovement).GetMethod("MovementPatch");
      Queer.Harmony.Patch((MethodBase) methodInfo1, new HarmonyMethod(method1), (HarmonyMethod) null, (HarmonyMethod) null, (HarmonyMethod) null, (HarmonyMethod) null);
      MethodInfo methodInfo2 = AccessTools.PropertySetter(typeof (PlayerCommandInput), "IsSkyDescent");
      MethodInfo method2 = typeof (SpeedHack.patchMovement).GetMethod("MovementPatch");
      Queer.Harmony.Patch((MethodBase) methodInfo2, new HarmonyMethod(method2), (HarmonyMethod) null, (HarmonyMethod) null, (HarmonyMethod) null, (HarmonyMethod) null);
    }

    protected override void OnDisable()
    {
      MethodInfo methodInfo1 = AccessTools.PropertySetter(typeof (PlayerCommandInput), "IsFalling");
      Queer.Harmony.Unpatch((MethodBase) methodInfo1, (HarmonyPatchType) 1, "CMLite");
      MethodInfo methodInfo2 = AccessTools.PropertySetter(typeof (PlayerCommandInput), "IsSkyDescent");
      Queer.Harmony.Unpatch((MethodBase) methodInfo2, (HarmonyPatchType) 1, "CMLite");
    }

    private class patchMovement
    {
      public static void MovementPatch(ref bool value) => value = true;
    }
  }
}
