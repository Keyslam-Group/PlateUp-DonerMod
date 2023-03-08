using DonerMod.Utils;
using KitchenData;
using KitchenLib;
using KitchenLib.Customs;
using KitchenLib.Event;
using KitchenLib.References;
using KitchenMods;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace DonerMod.Dishes;

public class CookedDonerKebabDish : CustomDish
{
    public override string UniqueNameID => "CookedDonerKebabDish";
    public override DishType Type => DishType.Base;
    public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallDecrease; 

    public override GameObject DisplayPrefab => Mod.Bundle.LoadAsset<GameObject>("Cooked Tomato Spinach Omelette");
    public override GameObject IconPrefab => DisplayPrefab;

    public override CardType CardType => CardType.Default;
    public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;
    public override UnlockGroup UnlockGroup => UnlockGroup.Dish;

    public override bool IsSpecificFranchiseTier => false;
    public override bool IsAvailableAsLobbyOption => true;
    public override bool DestroyAfterModUninstall => false;
    public override bool IsUnlockable => true;

    public override List<string> StartingNameSet => new List<string>
    {
        "Mouni",
        "Dunya Döner",
        "Döner and Döne",
        "Döner the Explorer",
        "Dönerful World",
        "Döner Up!",
        "Dun-Dön",
        "Kebab-ulous",
        "Döner me wrong",
    };

    public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
    {
        new Dish.MenuItem
        {
            Item = Refs.CookedDonerKebab,
            Phase = MenuPhase.Main,
            Weight = 1
        }
    };

    public override HashSet<Item> MinimumIngredients => new HashSet<Item>
    {
        Refs.Potato,
        Refs.Cheese,
        Refs.UncookedDoner,
        Refs.DisposableTray,
    };

    public override HashSet<Process> RequiredProcesses => new HashSet<Process>
    {
        Refs.Cook,
        Refs.Chop,
    };

    public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
    {
        { Locale.English, "Make fries by chopping potato and cooking it. Combine with cooked sliced Döner by taking raw Döner from the fridge and cooking it then slicing it. Add chopped cheese and bake again." }
    };

    public override void OnRegister(GameDataObject gameDataObject)
    {

    }
}