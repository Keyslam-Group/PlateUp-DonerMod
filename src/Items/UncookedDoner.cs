using DonerMod.Utils;
using KitchenData;
using KitchenLib;
using KitchenLib.Customs;
using KitchenLib.Event;
using KitchenLib.References;
using KitchenLib.Utils;
using KitchenMods;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace DonerMod.Items;

public class UncookedDoner : CustomItem {
    public override string UniqueNameID => "UncookedDoner";
    public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Doner");
    public override ItemCategory ItemCategory => ItemCategory.Generic;
    public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    public override ItemValue ItemValue => ItemValue.Medium;
    public override string ColourBlindTag => "UD";

    public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>() {
        new Item.ItemProcess() {
            Process = Refs.Cook,
            Result = Refs.CookedDoner,
            Duration = 2f
        }
    };

    public override void OnRegister(GameDataObject gameDataObject)
    {
        var meshRenderer = Prefab.GetComponentInChildren<MeshRenderer>();
        var material = MaterialUtils.GetCustomMaterial("CookedDoner");
        meshRenderer.materials = new Material[] { material };
    }
}