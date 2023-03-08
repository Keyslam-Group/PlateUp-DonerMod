using KitchenData;
using KitchenLib.Customs;
using UnityEngine;

namespace DonerMod.Items;

public class DirtyDisposableTray : CustomItem {
    public override string UniqueNameID => "DirtyDisposableTray";
    public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Cooked Tomato Spinach Omelette");
    public override ItemCategory ItemCategory => ItemCategory.Generic;
    public override ItemStorage ItemStorageFlags => ItemStorage.Small;
    public override ItemValue ItemValue => ItemValue.Medium;
    public override string ColourBlindTag => "DDT";
}