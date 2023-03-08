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

namespace DonerMod.Appliances;

public class Spit : CustomAppliance {
    public override string UniqueNameID => "Spit";
    public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Cooked Tomato Spinach Omelette");

    public override PriceTier PriceTier => PriceTier.Medium;
    public override bool SellOnlyAsDuplicate => true;
    public override bool IsPurchasable => true;
    public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;

    public override List<Appliance.ApplianceProcesses> Processes => new()
    {
    };
}