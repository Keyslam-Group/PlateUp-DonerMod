using KitchenData;
using KitchenLib;
using KitchenLib.Customs;
using KitchenLib.Event;
using KitchenLib.Utils;
using KitchenMods;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using static ApplianceLib.Api.References.ApplianceLibGDOs;

namespace DonerMod.Items;

public class CookedDoner : CustomItem {
    public override string UniqueNameID => "CookedDoner";
    public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("DonerSlices");
    public override ItemCategory ItemCategory => ItemCategory.Generic;
    public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    public override ItemValue ItemValue => ItemValue.Medium;
    public override string ColourBlindTag => "CD";

    public override void OnRegister(GameDataObject gameDataObject)
    {
        var meshRenderers = Prefab.GetComponentsInChildren<MeshRenderer>();
        var material = MaterialUtils.GetCustomMaterial("CookedDoner");
        foreach (var meshRenderer in meshRenderers)
            meshRenderer.materials = new Material[] { material };
    }
}