using System;

namespace UnityEngine.UIElements
{
	public class MeshGenerationContext
	{
		[Flags]
		internal enum MeshFlags
		{
			None = 0,
			UVisDisplacement = 1,
			SkipDynamicAtlas = 2
		}

		internal IStylePainter painter;

		internal MeshGenerationContext(IStylePainter painter)
		{
		}
	}
}
