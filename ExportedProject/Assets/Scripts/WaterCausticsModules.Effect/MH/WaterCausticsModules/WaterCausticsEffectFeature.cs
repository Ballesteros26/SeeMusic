using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace MH.WaterCausticsModules
{
	[DisallowMultipleRendererFeature("WaterCausticsEffect (Renderer Feature)")]
	[HelpURL("https://hacoapp.com/asset/wce/v2/ManualPDF.pdf")]
	public class WaterCausticsEffectFeature : ScriptableRendererFeature
	{
		private static WaterCausticsEffectFeature s_ins;

		private static int s_lastFrame;

		internal static bool effective => false;

		public static event Action<Camera> onCamRender
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<ScriptableRenderer, Camera> onEnqueue
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal static void OnAddedByScript()
		{
		}

		public override void Create()
		{
		}

		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData rendData)
		{
		}
	}
}
