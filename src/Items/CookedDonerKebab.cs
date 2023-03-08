using KitchenData;
using KitchenLib.Customs;

using UnityEngine;

namespace DonerMod.Items;

public class CookedDonerKebab : CustomItem
{
    public override string UniqueNameID => "CookedDonerKebab";
    public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Cooked Tomato Spinach Omelette");
    public override ItemCategory ItemCategory => ItemCategory.Generic;
    public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    public override ItemValue ItemValue => ItemValue.Medium;
    public override string ColourBlindTag => "CDKB";
}