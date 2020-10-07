using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTap;

namespace Keysight.OpenTap.Plugins.WaveGen_33600A
{
	public static partial class Enums
	{
		enum FocusChannelList
		{
			[Display("Default (CH1)")]
			[Scpi("CH1")]
			Default,

			[Display("Channel 1")]
			[Scpi("CH1")]
			CH1,

			[Display("Channel 2")]
			[Scpi("CH2")]
			CH2
		};

		public class Unit
		{
			public enum ArbRate 
			{
				[Display("Default (sample/sec)")]
				[Scpi("SRATe")]
				Default,

				[Display("sample/sec")]
				[Scpi("SRATe")]
				SamplePerSecond,

				[Display("sample/Hz")]
				[Scpi("FREQ")]
				SamplePerHz,

				[Display("sample/period")]
				[Scpi("PERiod")]SamplePerPeriod 
			};
			public enum Pulse
			{
				[Display("Default (Pulse Width)")]
				[Scpi("WIDTh")]
				Default,

				[Display("Pulse Width")]
				[Scpi("WIDTh")]
				Width,

				[Display("Pulse Duty Cycle")]
				[Scpi("DUTY")]
				Duty
			};
			public enum Rate
			{
				[Display("Default (Frequency)")]
				[Scpi("FREQuency")]
				Default,

				[Display("Frequency")]
				[Scpi("FREQuency")]
				Frequency,

				[Display("Period")]
				[Scpi("PERiod")]
				Period
			};
			public enum Sweep
			{
				[Display("Default (Sweep mode Start Stop)")]
				[Scpi("STARtstop")]
				Default,

				[Display("Sweep Mode: Start Stop")]
				[Scpi("STARtstop")]
				STARtstop,

				[Display("Sweep Mode: Period")]
				[Scpi("CENTerspan")]
				CENTerspan
			};
			public enum Voltage
			{
				[Display("Default (Amplitude Offset Voltage)")]
				[Scpi("AMPLitudeoffset")]
				Default,

				[Display("Amplitude Offset Voltage")]
				[Scpi("AMPLitudeoffset")]
				AMPLitudeoffset,

				[Display("High Low Voltage")]
				[Scpi("HIGHlow")]
				HIGHlow
			}
		}

		public enum DisplayView
		{
			[Display("Default (Standard)")]
			[Scpi("STANdard")]
			Default,

			[Display("Standard")]
			[Scpi("STANdard")]
			Standard,

			[Display("Text")]
			[Scpi("TEXT")]
			Text,

			[Display("Graph")]
			[Scpi("GRAPh")]
			Graph,

			[Display("Dual")]
			[Scpi("DUAL")]
			Dual
		}
	}
}
