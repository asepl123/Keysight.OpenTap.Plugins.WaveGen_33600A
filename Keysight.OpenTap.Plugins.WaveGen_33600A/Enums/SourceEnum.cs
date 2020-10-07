using OpenTap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keysight.OpenTap.Plugins.WaveGen_33600A
{
	public static partial class Enums
	{
		public enum Modulation
		{
			[Display("AM")]
			[Scpi("AM")]
			AM,

			[Display("FM")]
			[Scpi("FM")]
			FM,

			[Display("PM")]
			[Scpi("PM")]
			PM
		}
	}
}
