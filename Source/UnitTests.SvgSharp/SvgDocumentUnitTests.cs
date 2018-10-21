using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SvgSharp;

namespace UnitTests.SvgSharp
{
	internal static class MyAssert
	{
		public static void Contains(this Assert assert, string expected, string value)
		{
			if (!string.IsNullOrEmpty(expected))
			{
				if (expected.Contains(value))
				{
					return;
				}
			}

			throw new AssertFailedException("Foo");
		}
	}

	[TestClass]
	public class SvgDocumentUnitTests
	{
		[TestMethod]
		public void Save()
		{
			SvgDocument document = new SvgDocument();

			MemoryStream stream = new MemoryStream();
			document.Save(stream);

			stream.Position = 0;

			var streamReader = new StreamReader(stream);

			var output = streamReader.ReadToEnd();

			Assert.That.Contains(output, "svg");
		}
	}
}
