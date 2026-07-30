using UnityEngine;

namespace NatML
{
	public abstract class MLFeature
	{
		public readonly MLFeatureType type;

		protected MLFeature(MLFeatureType type)
		{
		}

		public static implicit operator MLFeature(float value)
		{
			return null;
		}

		public static implicit operator MLFeature(int value)
		{
			return null;
		}

		public static implicit operator MLFeature(bool value)
		{
			return null;
		}

		public static implicit operator MLFeature(float[] array)
		{
			return null;
		}

		public static implicit operator MLFeature(int[] array)
		{
			return null;
		}

		public static implicit operator MLFeature(Texture2D texture)
		{
			return null;
		}

		public static implicit operator MLFeature(WebCamTexture texture)
		{
			return null;
		}

		public static implicit operator MLFeature(AudioClip clip)
		{
			return null;
		}

		public static implicit operator MLFeature(string text)
		{
			return null;
		}
	}
}
