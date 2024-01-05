using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GuideToHumility.Items;

public class GuideToHumilityBookInactive : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 20;
        Item.useTime = 15;
        Item.useAnimation = 15;
        Item.useStyle = ItemUseStyleID.HoldUp;
        Item.value = Item.sellPrice(0, 0, 5);
        Item.rare = ItemRarityID.Green;
        Item.UseSound = SoundID.Item1;
        Item.autoReuse = true;
    }

    public override bool CanRightClick()
    {
        return true;
    }
    
    public override void RightClick(Player player)
    {
        player.PutItemInInventoryFromItemUsage(ModContent.ItemType<GuideToHumilityBook>(), Type);
    }
}