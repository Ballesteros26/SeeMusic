using System;
using Function.Internal;

namespace Function.Types
{
	[Serializable]
	[Preserve]
	public class User : Profile
	{
		public string email;
	}
}
