
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Keysight.OpenTap.Plugins.WaveGen_33600A
{
	public class PrefixConversion
	{
		public enum EPrefix { n = -9, u = -6, m = -3, unit = 0, k = 3, M = 6, G = 9 };
		public string UnitConversion(double value, EPrefix prefix = EPrefix.unit)
		{
			double resCoefficient = 1;
			char resPrefix;

			if (value < 1.0E-6)
			{
				resCoefficient = 1.0E-9;
				resPrefix = 'n';
			}
			else if (value >= 1.0E-6 && value < 1.0E-3)
			{
				resCoefficient = 1.0E-6;
				resPrefix = 'u';
			}
			else if (value >= 1.0E-3 && value < 1)
			{
				resCoefficient = 1.0E-3;
				resPrefix = 'm';
			}
			else if (value >= 1 && value < 1.0E3)
			{
				resCoefficient = 1;
				resPrefix = ' ';
			}
			else if (value >= 1.0E3 && value < 1.0E6)
			{
				resCoefficient = 1.0E3;
				resPrefix = 'k';
			}
			else if (value >= 1.0E6 && value < 1.0E9)
			{
				resCoefficient = 1.0E6;
				resPrefix = 'M';
			}
			else
			{
				resCoefficient = 1.0E9;
				resPrefix = 'G';
			}

			var res = value / resCoefficient;
			return resPrefix == ' '? res.ToString() + ' ' : res.ToString() + ' ' + resPrefix;
		}
		
	}
}
