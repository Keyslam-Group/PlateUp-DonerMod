using DonerMod.Utils;
using KitchenData;
using KitchenLib;
using KitchenLib.Customs;
using KitchenLib.Event;
using KitchenLib.Utils;
using KitchenMods;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace DonerMod.Appliances;

public class DonerProvider : CustomAppliance {
    public override string UniqueNameID => "DonerProvider";
    public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Cooked Tomato Spinach Omelette");

    public override PriceTier PriceTier => PriceTier.Medium;
    public override bool SellOnlyAsDuplicate => true;
    public override bool IsPurchasable => true;
    public override ShoppingTags ShoppingTags => ShoppingTags.Cooking | ShoppingTags.Misc;

    public override List<(Locale, ApplianceInfo)> InfoList => new()
    {
        ( Locale.English, LocalisationUtils.CreateApplianceInfo("Doner", "Provides three doner", new(), new()) )
    };

    public override List<IApplianceProperty> Properties => new()
    {
        new Kitchen.CItemProvider()
        {
            ProvidedItem = Refs.UncookedDoner.ID,
        }
    };
}