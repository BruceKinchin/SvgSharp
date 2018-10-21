using System;
using System.IO;
using System.Xml;
using SvgSharp.Interfaces;

namespace SvgSharp
{
    public class SvgDocument : ISvgDocument
	{
		private int _width;
		private int _height;

		public void Save(Stream stream)
	    {
		    XmlWriterSettings settings = new XmlWriterSettings
		    {
				Indent = true,
		    };

		    XmlWriter writer = XmlWriter.Create(stream, settings);

			writer.WriteStartElement("svg", "http://www.w3.org/2000/svg");
			writer.WriteAttributeString("width", _width.ToString());
			writer.WriteAttributeString("height", _height.ToString());

			// Throw something in here so we can see _something_.
			writer.WriteRaw("<circle cx=\"50\" cy=\"50\" r=\"40\" stroke=\"green\" stroke-width=\"4\" fill=\"yellow\" />");

			writer.WriteEndElement();

			writer.Flush();
		}

		public void SetSize(int width, int height)
		{
			_width = width;
			_height = height;
		}
	}
}
