using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GuideToHumility.Items;

public class HeartExtension : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation)
    {
        return entity.type is ItemID.Heart;
    }

    public override bool CanPickup(Item item, Player player)
    {
        var hasBook = player.HasItem(ModContent.ItemType<GuideToHumilityBook>());

        var hasFullHealth = player.statLife >= player.statLifeMax2;

        if (hasBook && hasFullHealth) return false;

        return base.CanPickup(item, player);
    }
}