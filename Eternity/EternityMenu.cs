using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Eternity.Backgrounds;
using ReLogic.Content;
using Terraria.ModLoader;
using System;

namespace Eternity
{
    public class EternityMenu : ModMenu
    {
        private const string MenuAssetPath = "Eternity/Textures/Menu";

        public override bool PreDrawLogo(SpriteBatch spriteBatch, ref Vector2 logoDrawCenter, ref float logoRotation, ref float logoScale, ref Color drawColor)
        {
            logoDrawCenter -= new Vector2(36, 0);
            logoScale = 1f;
            return true;
        }
        public override void Update(bool isOnTitleScreen)
        {
            Main.dayTime = true;
            Main.time = 40000;
        }