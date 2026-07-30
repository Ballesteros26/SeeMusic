using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/Avatar.h")]
	[UsedByNativeCode]
	public class Avatar : Object
	{
		public HumanDescription humanDescription => default(HumanDescription);

		private Avatar()
		{
		}

		[SpecialName]
		private void get_humanDescription_Injected(out HumanDescription ret)
		{
			ret = default(HumanDescription);
		}
	}
}
