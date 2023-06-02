// Decompiled with JetBrains decompiler
// Type: CMLiteCheat.Module_Manager.Modules.Weapon.InfiniteAttachments
// Assembly: CMLiteCheat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE1CDB50-B03D-44B2-BD55-9FBE67DA42B2
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Combat Master\BepInEx\plugins\CMLiteCheat_[unknowncheats.me]_.dll

using CombatMaster.GDI;
using System.Collections.Generic;
using UnityEngine;


#nullable enable
namespace CMLiteCheat.Module_Manager.Modules.Weapon
{
  public class InfiniteAttachments : CMLiteCheat.Module_Manager.Base.Module.Module
  {
    private readonly List<(AttachmentInfo, ModificationStatsInfo)> originalValues = new List<(AttachmentInfo, ModificationStatsInfo)>();

    public InfiniteAttachments()
      : base("Infinite Attachments", "Weapon")
    {
    }

    protected override void OnEnable()
    {
      foreach (WeaponsGdInfoSection weaponsGdInfoSection in Resources.FindObjectsOfTypeAll<WeaponsGdInfoSection>())
        weaponsGdInfoSection.AttachmentsMaximum = (ushort) 10000;
    }

    protected override void OnDisable()
    {
      foreach (WeaponsGdInfoSection weaponsGdInfoSection in Resources.FindObjectsOfTypeAll<WeaponsGdInfoSection>())
        weaponsGdInfoSection.AttachmentsMaximum = (ushort) 6;
    }
  }
}
