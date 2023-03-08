using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;
using static ApplianceLib.Api.References.ApplianceLibGDOs;

namespace DonerMod.Items;

public class DisposableTray : CustomItem {
    public override string UniqueNameID => "DisposableTray";
    public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("DisposableTray");
    public override ItemCategory ItemCategory => ItemCategory.Generic;
    public override ItemStorage ItemStorageFlags => ItemStorage.Small;
    public override ItemValue ItemValue => ItemValue.Medium;
    public override string ColourBlindTag => "DT";

    public override void OnRegister(GameDataObject gameDataObject)
    {
        var meshRenderer = Prefab.GetComponentInChildren<MeshRenderer>();
        var material = MaterialUtils.GetCustomMaterial("Tray");
        // var material = MaterialUtils.GetExistingMaterial("Tomato");
        meshRenderer.materials = new Material[] { material };
    }
}