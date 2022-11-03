using Eternity.World;
using System.ComponentModel;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ModLoader.Config;

namespace Eternity.Utilities
{
	[Label("Client Config")]
	class EternityClientConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;