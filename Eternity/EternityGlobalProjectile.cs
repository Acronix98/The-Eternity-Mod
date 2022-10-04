using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

using Eternity.Dusts;

namespace Eternity
{
    public class EternityGlobalProjectile : GlobalProjectile
    {

        public override bool InstancePerEntity => true;
        
        public override void PostAI(Projectile projectile)
        {
            if (isReflecting && projectile.hostile && !projectile.friendly)
            {
                oldvelocity = projectile.velocity;
                projectile.velocity = reflectvelocity;
                projectile.rotation += projectile.velocity.ToRotation() - oldvelocity.ToRotation();

                if(ReflectConter-- <= 0)
                {
                    projectile.Kill();
                }

                if(Vector2.Distance(Main.player[projectile.owner].Center, projectile.Center) > 500f)
                {
                    projectile.Kill();
                }
            }

            base.PostAI(projectile);
        }

        public static bool AnyProjectiles(int type)
        {
            for (int i = 0; i < Main.maxProjectiles; i++)
            {
                if (Main.projectile[i].active && Main.projectile[i].type == type)
                {
                    return true;
                }
            }

            return false;
        }

        public static int CountProjectiles(int type)
        {
            int num = 0;
            for (int i = 0; i < Main.maxProjectiles; i++)
            {
                if (Main.projectile[i].active && Main.projectile[i].type == type)
                {
                    num++;
                }
            }

            return num;
        }


        public Vector2 reflectvelocity = Vector2.Zero;

        private Vector2 oldvelocity = Vector2.Zero;

        public bool isReflecting = false;
        public int ReflectConter = 0;
    }
}
