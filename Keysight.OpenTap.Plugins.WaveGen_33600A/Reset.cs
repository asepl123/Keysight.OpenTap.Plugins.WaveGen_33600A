using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTap;

namespace Keysight.OpenTap.Plugins.WaveGen_33600A
{
	[Display("Reset", Group: "Keysight.OpenTap.Plugins.WaveGen_33600A", Description: "This Test step reset the instrument")]
	public class Reset : TestStep
	{
		#region Settings
		// ToDo: Add property here for each parameter the end user should be able to change.
		[Display(Name:"Instrument", Description:"Enter Instrument", Group:"Instrument Settings", Order: -10000)]
		public MyInst MyInst { get; set; }

		#endregion

		public Reset()
		{
			// ToDo: Set default values for properties / settings.
		}

		public override void Run()
		{
			// ToDo: Add Instrument Specific Task
			RunChildSteps(); //If the step supports child steps.

			ResetInstrument(MyInst);

			UpgradeVerdict(Verdict.Pass);
		}

		void ResetInstrument(MyInst myInst)
		{
			myInst.ScpiCommand("*RST");
		}
	}
}
