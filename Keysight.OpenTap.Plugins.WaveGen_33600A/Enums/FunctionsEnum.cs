using OpenTap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keysight.OpenTap.Plugins.WaveGen_33600A.Enums
{
	public static partial class Enums
	{
		enum InternalFunctions
		{
			[Display("Sinusoid")]
			[Scpi("SINusoid")]
			Sinusoid,

			[Display("Square")]
			[Scpi("SQUare")]
			Square,

			[Display("Ramp")]
			[Scpi("RAMP")]
			RAMP,

			[Display("N-Ramp")]
			[Scpi("NRAMp")]
			NRamp,

			[Display("Tiangle")]
			[Scpi("TRIangle")]
			Triangle,

			[Display("Noise")]
			[Scpi("NOISe")]
			Noise,

			[Display("PRBS")]
			[Scpi("PRBS")]
			PRBS,

			[Display("Arbitrary")]
			[Scpi("ARB")]
			ARB
		}
	}
}
