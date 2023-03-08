using DonerMod.Utils;
using Kitchen;
using KitchenData;
using KitchenLib;
using KitchenLib.Customs;
using KitchenLib.Event;
using KitchenLib.References;
using KitchenMods;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace DonerMod.Items;

public class UncookedDonerKebab : CustomItemGroup
{
    public override string UniqueNameID => "UncookedDonerKebab";
    public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Cooked Tomato Spinach Omelette");
    public override ItemCategory ItemCategory => ItemCategory.Generic;
    public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;
    public override ItemValue ItemValue => ItemValue.Medium;
    public override string ColourBlindTag => "UDKB";

    public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>()
    {
        new ItemGroup.ItemSet()
        {
            Max = 1,
            Min = 1,
            Items = new List<Item>()
            {
                Refs.DisposableTray,
            }
        },
        new ItemGroup.ItemSet()
        {
            Max = 3,
            Min = 3,
            Items = new List<Item>()
            {
                Refs.CookedDoner,
                Refs.Potato,
                Refs.ChoppedCheese,
            }
        },
    };

    public override List<Item.ItemProcess> Processes => new List<Item.ItemProcess>() {
        new Item.ItemProcess() {
            Process = Refs.Cook,
            Result = Refs.CookedDonerKebab,
            Duration = 2f
        }
    };
}