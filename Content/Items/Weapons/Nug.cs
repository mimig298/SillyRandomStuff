using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SillyRandomStuff.Content.Items.Weapons
{
    public class Nug : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 50;
            Item.height = 26;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 37;
            Item.useAnimation = 37;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 30;
            Item.knockBack = 0f;
            Item.noMelee = true;

            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item11;

            Item.shoot = ProjectileID.PurificationPowder;
            Item.shootSpeed = 5f;
            Item.useAmmo = AmmoID.Bullet;
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            velocity = new Vector2(velocity.Y, velocity.X) * -(knockback + 1);
            (damage, type) = (type, damage);
        }
    }
}
