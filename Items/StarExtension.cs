using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GuideToHumility.Items;

public class StarExtension : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Star;
    }

    public override bool CanPickup(Item item, Player player)
    {
        var hasBook = player.HasItem(ModContent.ItemType<GuideToHumilityBook>());

        var hasFullMana = player.statMana >= player.statManaMax2;

        if (hasBook && hasFullMana) return false;

        return base.CanPickup(item, player);
    }
}