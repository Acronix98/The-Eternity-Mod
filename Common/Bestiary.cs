using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ModLoader;

namespace Eternity.Common
{
    class Bestiary : GlobalNPC
    {
        public override void SetBestiary(NPC npc, BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            base.SetBestiary(npc, database, bestiaryEntry);
        }
    }
}