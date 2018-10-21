using System.IO;
using System.Xml;
using SvgSharp;
using SvgSharp.Interfaces;

namespace Examples.Examples
{
	public class ExampleCreateBox : IExample
	{
		private readonly ISvgDocument _document;

		public ExampleCreateBox(ISvgDocument document)
		{
			_document = document;
		}

		public void Run()
		{
			FileStream stream = File.OpenWrite(@"c:\git\bk.svg");

			_document.SetSize(100, 100);
			_document.Save(stream);
			stream.Close();
			
		}
	}
}