using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Eternity.Utilities
{
	public class WikiWriter
	{
		public static string Path => Environment.CurrentDirectory + "/Wiki/";

		public static void WriteWiki()
