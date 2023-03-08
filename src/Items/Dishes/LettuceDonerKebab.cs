// using KitchenData;
// using KitchenLib;
// using KitchenLib.Customs;
// using KitchenLib.Event;
// using KitchenLib.References;
// using KitchenMods;
// using System.Collections.Generic;
// using System.Reflection;
// using UnityEngine;

// namespace DonerMod;

// public class LettuceDonerKebab : CustomDish
// {
//     public override string UniqueNameID => "LettuceDonerKebab";
//     public override DishType Type => DishType.Main;
//     public override DishCustomerChange CustomerMultiplier => DishCustomerChange.SmallIncrease; 

//     public override GameObject DisplayPrefab => Mod.Bundle.LoadAsset<GameObject>("Cooked Tomato Spinach Omelette");
//     public override GameObject IconPrefab => DisplayPrefab;

//     public override CardType CardType => CardType.Default;
//     public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Small;
//     public override UnlockGroup UnlockGroup => UnlockGroup.Dish;

//     public override bool IsSpecificFranchiseTier => false;
//     public override bool IsAvailableAsLobbyOption => true;
//     public override bool DestroyAfterModUninstall => false;
//     public override bool IsUnlockable => true;

//     public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
//     {
//         new Dish.MenuItem
//         {
//             Item = Utils.Find<Item>("Doner", ""),
//             Phase = MenuPhase.Main,
//             Weight = 1
//         }
//     };

//     public override HashSet<Item> MinimumIngredients => new HashSet<Item>
//     {
//         Utils.Find<Item>(ItemReferences.Potato),
//         Utils.Find<Item>(ItemReferences.Cheese),
//         Utils.Find<Item>(ItemReferences.Plate),
//         Utils.Find<Item>("Doner", "RawDoner"),
//     };

//     public override HashSet<Process> RequiredProcesses => new HashSet<Process>
//     {
//         Utils.Find<Process>(ProcessReferences.Cook),
//         Utils.Find<Process>(ProcessReferences.Chop),
//     };

//     public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
//     {
//         { Locale.English, "Make fries by chopping potato and cooking it. Combine with cooked sliced Döner by taking raw Döner from the fridge and cooking it then slicing it. Add chopped cheese and bake again." }
//     };

//     public override void OnRegister(GameDataObject gameDataObject)
//     {

//     }
// }