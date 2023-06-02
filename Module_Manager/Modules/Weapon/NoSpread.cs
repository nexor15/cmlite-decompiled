// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Modules.Weapon.NoSpread
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using CombatMaster.GDI;
using System.Collections.Generic;
using UnityEngine;


#nullable enable
namespace CMLiteCheat.Module_Manager.Modules.Weapon
{
  public class NoSpread : CMLiteCheat.Module_Manager.Base.Module.Module
  {
    private readonly List<(AttachmentInfo, ModificationStatsInfo)> originalValues = new List<(AttachmentInfo, ModificationStatsInfo)>();

    public NoSpread()
      : base("No Spread", "Weapon")
    {
    }

    protected override void OnEnable()
    {
      foreach (AttachmentInfo attachmentInfo in Resources.FindObjectsOfTypeAll<AttachmentInfo>())
      {
        if (!Object.op_Equality((Object) attachmentInfo.Prefab, (Object) null) && ((Object) attachmentInfo.Prefab).name.ToLower().Contains("grip"))
        {
          ModificationStatsInfo modHipFireArea = attachmentInfo.ModHipFireArea;
          this.originalValues.Add((attachmentInfo, modHipFireArea));
          attachmentInfo.ModHipFireArea = new ModificationStatsInfo()
          {
            Value = float.MinValue,
            ModStatsType = (EnumPublicSealedvaZoFiRaAdMoSpAdVeSpUnique) 10
          };
        }
      }
    }

    protected override void OnDisable()
    {
      foreach ((AttachmentInfo, ModificationStatsInfo) originalValue in this.originalValues)
        originalValue.Item1.ModHipFireArea = originalValue.Item2;
      this.originalValues.Clear();
    }
  }
}
