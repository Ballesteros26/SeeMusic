using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	[UsedByNativeCode]
	[NativeHeader("VFXScriptingClasses.h")]
	[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
	public class VisualEffectAsset : VisualEffectObject
	{
		public const string PlayEventName = "OnPlay";

		public const string StopEventName = "OnStop";

		public static readonly int PlayEventID;

		public static readonly int StopEventID;
	}
}
