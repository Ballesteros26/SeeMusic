using System;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	public struct VideoResolveOptions
	{
		public enum AspectRatio
		{
			NoScaling = 0,
			FitVertically = 1,
			FitHorizontally = 2,
			FitInside = 3,
			FitOutside = 4,
			Stretch = 5
		}

		[SerializeField]
		public bool applyHSBC;

		[SerializeField]
		[Range(0f, 1f)]
		public float hue;

		[SerializeField]
		[Range(0f, 1f)]
		public float saturation;

		[Range(0f, 1f)]
		[SerializeField]
		public float brightness;

		[Range(0f, 1f)]
		[SerializeField]
		public float contrast;

		[Range(0.0001f, 10f)]
		[SerializeField]
		public float gamma;

		[SerializeField]
		public Color tint;

		[SerializeField]
		public bool generateMipmaps;

		[SerializeField]
		public AspectRatio aspectRatio;

		public bool IsColourAdjust()
		{
			return false;
		}

		internal void ResetColourAdjust()
		{
		}

		public static VideoResolveOptions Create()
		{
			return default(VideoResolveOptions);
		}
	}
}
