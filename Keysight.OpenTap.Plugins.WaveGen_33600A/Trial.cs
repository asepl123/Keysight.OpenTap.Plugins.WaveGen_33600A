// Author: MyName
// Copyright:   Copyright 2020 Keysight Technologies
//              You have a royalty-free right to use, modify, reproduce and distribute
//              the sample application files (and/or any modified version) in any way
//              you find useful, provided that you agree that Keysight Technologies has no
//              warranty, obligations or liability for any sample application files.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using OpenTap;

namespace Keysight.OpenTap.Plugins.WaveGen_33600A
{
	[Display("Trial", Group: "Keysight.OpenTap.Plugins.WaveGen_33600A", Description: "Insert a description here")]
	public class Trial : TestStep
	{
		#region Settings
		// ToDo: Add property here for each parameter the end user should be able to change
		[Display(Name: "Instrument", Description: "Enter Instrument", Group: "Instrument Settings", Order: -10000)]
		public MyInst MyInst { get; set; }

		[Display(Name: "Frequency", Description: "Enter Frequency", Group: "Inputs", Order: 1.0)]
		public double Frequency { get; set; }

		#endregion

		public Trial()
		{
			// ToDo: Set default values for properties / settings.
		}

		public override void Run()
		{
			// ToDo: Add test case code.
			RunChildSteps(); //If the step supports child steps.
			var myFreq = Convert.ToDouble(MyInst.ScpiQuery("SOURce:FREQuency?"));
			Log.Info(myFreq.ToString());
			Log.Info(myFreq.GetType().ToString());
			// If no verdict is used, the verdict will default to NotSet.
			// You can change the verdict using UpgradeVerdict() as shown below.
			// UpgradeVerdict(Verdict.Pass);
		}
	}
}
