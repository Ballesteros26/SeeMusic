using System.IO;

namespace AudioSynthesis
{
	public interface IResource
	{
		bool ReadAllowed();

		string GetName();

		Stream OpenResourceForRead();
	}
}
