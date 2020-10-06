using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keysight.OpenTap.Plugins.WaveGen_33600A;
using System.Globalization;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var pc = new PrefixConversion();
			var res = pc.UnitConversion(1.0E7);
			Console.WriteLine(res);
			Assert.AreEqual(res, "10 M");
		}

		[TestMethod]
		public void TestMethod11()
		{
			myFunc(1.0E3, "1 k");
		}

		[TestMethod]
		public void TestMethod12()
		{
			myFunc(1.0E6, "1 M");
		}

		[TestMethod]
		public void TestMethod13()
		{
			myFunc(1.0E9, "1 G");
		}

		[TestMethod]
		public void TestMethod14()
		{
			myFunc(1.0E12, "1000 G");
		}

		[TestMethod]
		public void TestMethod21()
		{
			myFunc(1.22E-10, "0.122 n");
		}

		[TestMethod]
		public void TestMethod22()
		{
			myFunc(1.22E-8, "12.2 n");
		}

		[TestMethod]
		public void TestMethod23()
		{
			myFunc(1.22E-5, "12.2 u");
		}

		[TestMethod]
		public void TestMethod24()
		{
			myFunc(1.22E-2, "12.2 m");
		}

		[TestMethod]
		public void TestMethod25()
		{
			myFunc(1.22E1, "12.2 ");
		}

		[TestMethod]
		public void TestMethod26()
		{
			myFunc(1.22E4, "12.2 k");
		}

		[TestMethod]
		public void TestMethod27()
		{
			myFunc(1.22E10, "12.2 G");
		}

		void myFunc(double x, string result)
		{
			var pc = new PrefixConversion();
			var res = pc.UnitConversion(x);
			Console.WriteLine(res);
			Assert.AreEqual(res, result);
		}
	}
}
