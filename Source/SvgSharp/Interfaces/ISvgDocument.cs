using System.IO;

namespace SvgSharp.Interfaces
{
	public interface ISvgDocument
	{
		void Save(Stream stream);
		void SetSize(int width, int height);
	}
}