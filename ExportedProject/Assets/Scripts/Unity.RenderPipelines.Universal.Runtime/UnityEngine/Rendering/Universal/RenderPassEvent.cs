using System;
using System.ComponentModel;

namespace UnityEngine.Rendering.Universal
{
	public enum RenderPassEvent
	{
		BeforeRendering = 0,
		BeforeRenderingShadows = 50,
		AfterRenderingShadows = 100,
		BeforeRenderingPrePasses = 150,
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Obsolete, to match the capital from 'Prepass' to 'PrePass' (UnityUpgradable) -> BeforeRenderingPrePasses")]
		BeforeRenderingPrepasses = 151,
		AfterRenderingPrePasses = 200,
		BeforeRenderingGbuffer = 210,
		AfterRenderingGbuffer = 220,
		BeforeRenderingDeferredLights = 230,
		AfterRenderingDeferredLights = 240,
		BeforeRenderingOpaques = 250,
		AfterRenderingOpaques = 300,
		BeforeRenderingSkybox = 350,
		AfterRenderingSkybox = 400,
		BeforeRenderingTransparents = 450,
		AfterRenderingTransparents = 500,
		BeforeRenderingPostProcessing = 550,
		AfterRenderingPostProcessing = 600,
		AfterRendering = 1000
	}
}
