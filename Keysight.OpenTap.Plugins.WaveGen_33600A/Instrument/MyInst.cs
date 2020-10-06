using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using OpenTap;

//Note this template assumes that you have a SCPI based instrument, and accordingly
//extends the ScpiInstrument base class.

//If you do NOT have a SCPI based instrument, you should modify this instance to extend
//the (less powerful) Instrument base class.

namespace Keysight.OpenTap.Plugins.WaveGen_33600A.Instrument
{
	[Display("WaveGen33600A", Group: "Keysight.OpenTap.Plugins.WaveGen_33600A.Instrument", Description: "33500B/33600A Series Function / Arbitrary Waveform Generators \n List of Instrument: \n 33500B Series: 33509B, 33510B, 33511B, 33512B, 33519B, 33520B, 33521B, 33522B \n 33600A Series: 33609A, 33610A, 33611A, 33612A, 33619A, 33620A, 33621A, 33622A")]
	public class MyInst : ScpiInstrument
	{
		#region Settings
		// ToDo: Add property here for each parameter the end user should be able to change
		#endregion

		public MyInst()
		{
			Name = "33600A Series Waveform Generator";
		}

		/// <summary>
		/// Open procedure for the instrument.
		/// </summary>
		public override void Open()
		{

			base.Open();

			Log.Info("Connection to the Instrument Established");

			if (!IdnString.Contains("Instrument ID"))
			{
				Log.Error("This instrument driver does not support the connected instrument.");
				throw new ArgumentException("Wrong instrument type.");
			}

		}

		/// <summary>
		/// Close procedure for the instrument.
		/// </summary>
		public override void Close()
		{
			// TODO:  Shut down the connection to the instrument here.
			base.Close();
		}
	}
}
