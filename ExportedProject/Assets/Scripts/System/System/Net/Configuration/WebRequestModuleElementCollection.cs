using System.Configuration;
using System.Reflection;

namespace System.Net.Configuration
{
	/// <summary>Represents a container for Web request module configuration elements. This class cannot be inherited.</summary>
	[DefaultMember("Item")]
	[ConfigurationCollection(typeof(WebRequestModuleElement))]
	public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.WebRequestModuleElementCollection" /> class. </summary>
		public WebRequestModuleElementCollection()
		{
		}
	}
}
