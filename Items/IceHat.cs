using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace HatPack.Items   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    [AutoloadEquip(EquipType.Head)]
    public class IceHat : ModItem {
        /* public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Head); //this tells the game that this item can be equpped in the head accessory
            return true;
        }*/
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Hat");
            Tooltip.SetDefault("It's so cold!");
        }
 
        public override void SetDefaults()
        {
            //item.name = "Kid's Hat";   //the name displayed when hovering over the item ingame.
            item.width = 20; //The size in width of the sprite in pixels.
            item.height = 20;   //The size in height of the sprite in pixels.
            item.rare = 3;    //The color the title of your item when hovering over it ingame
            item.vanity = true; //this defines if this item is vanity or not.
        }
 
        public override bool DrawHead()
        {
            return true;     //this make so the player head does not disappear when the vanity mask is equipped.  return false if you want to not show the player head.
        }
        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = drawAltHair = false;  //this make so the player hair does not show when the vanity mask is equipped.  add true if you want to show the player hair.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.BlueDye, 2);
            recipe.AddIngredient(ItemID.CyanDye);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}