using DonerMod.Dishes;
using DonerMod.Items;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;

namespace DonerMod.Utils;

public static class Refs
{
    #region Vanilla
    public static Item Plate => Find<Item>(ItemReferences.Plate);
    public static Item DirtyPlate => Find<Item>(ItemReferences.PlateDirty);
    public static Item Wok => Find<Item>(ItemReferences.Wok);
    public static Item BurnedWok => Find<Item>(ItemReferences.WokBurned);
    public static Item Flour => Find<Item>(ItemReferences.Flour);
    public static Item Egg => Find<Item>(ItemReferences.Egg);
    public static Item CrackedEgg => Find<Item>(ItemReferences.EggCracked);
    public static Item Sugar => Find<Item>(ItemReferences.Sugar);
    public static Item Burnt => Find<Item>(ItemReferences.BurnedFood);
    public static Item Potato => Find<Item>(ItemReferences.Potato);
    public static Item ChoppedPotato => Find<Item>(ItemReferences.PotatoChopped);
    public static Item Fries => Find<Item>(ItemReferences.PotatoChoppedCooked);
    public static Item Tomato => Find<Item>(ItemReferences.Tomato);
    public static Item ChoppedTomato => Find<Item>(ItemReferences.TomatoChopped);
    public static Item Lettuce => Find<Item>(ItemReferences.Lettuce);
    public static Item ChoppedLettuce => Find<Item>(ItemReferences.LettuceChopped);
    public static Item Cheese => Find<Item>(ItemReferences.Cheese);
    public static Item ChoppedCheese => Find<Item>(ItemReferences.CheeseGrated);
    public static Item Mushroom => Find<Item>(ItemReferences.Mushroom);
    public static Item ChoppedMushroom => Find<Item>(ItemReferences.MushroomChopped);
    public static Item Onion => Find<Item>(ItemReferences.Onion);
    public static Item ChoppedOnion => Find<Item>(ItemReferences.OnionChopped);
    public static ItemGroup Mayo => Find<ItemGroup>(ItemReferences.Mayonnaise);
    public static Item OilIngredient => Find<Item>(ItemReferences.OilIngredient);

    // Processes
    public static Process Cook => Find<Process>(ProcessReferences.Cook);
    public static Process Chop => Find<Process>(ProcessReferences.Chop);
    public static Process Knead => Find<Process>(ProcessReferences.Knead);
    public static Process Oven => Find<Process>(ProcessReferences.RequireOven);
    #endregion

    #region Modded
    public static Item DisposableTray => Find<Item, DisposableTray>();
    public static Item DirtyDisposableTray => Find<Item, DirtyDisposableTray>();

    public static Item UncookedDoner => Find<Item, UncookedDoner>();
    public static Item CookedDoner => Find<Item, CookedDoner>();
    
    public static ItemGroup UncookedDonerKebab => Find<ItemGroup, UncookedDonerKebab>();
    public static Item CookedDonerKebab => Find<Item, CookedDonerKebab>();

    public static Dish CookedDonerKebabDish => Find<Dish, CookedDonerKebabDish>();
    #endregion

    private static T Find<T>(int id) where T : GameDataObject
    {
        return (T)GDOUtils.GetExistingGDO(id) ?? (T)GDOUtils.GetCustomGameDataObject(id)?.GameDataObject;
    }

    private static T Find<T, C>() where T : GameDataObject where C : CustomGameDataObject
    {
        return GDOUtils.GetCastedGDO<T, C>();
    }

    private static T Find<T>(string modName, string name) where T : GameDataObject
    {
        return GDOUtils.GetCastedGDO<T>(modName, name);
    }

    private static Appliance.ApplianceProcesses FindApplianceProcess<C>() where C : CustomSubProcess
    {
        ((CustomApplianceProccess)CustomSubProcess.GetSubProcess<C>()).Convert(out var process);
        return process;
    }
}