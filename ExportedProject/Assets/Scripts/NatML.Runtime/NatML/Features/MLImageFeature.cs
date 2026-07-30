using System.Collections.Generic;
using NatML.API.Types;
using NatML.Types;
using Unity.Collections;
using UnityEngine;

namespace NatML.Features
{
	public sealed class MLImageFeature : MLFeature, IMLEdgeFeature, IMLCloudFeature
	{
		public Vector4 mean;

		public Vector4 std;

		public AspectMode aspectMode;

		private readonly byte[] pixelBuffer;

		private unsafe readonly void* nativeBuffer;

		public int width => 0;

		public int height => 0;

		public MLImageFeature(int width, int height)
			: base(null)
		{
		}

		public MLImageFeature(Texture2D texture)
			: base(null)
		{
		}

		public MLImageFeature(Color32[] colorBuffer, int width, int height)
			: base(null)
		{
		}

		public MLImageFeature(byte[] pixelBuffer, int width, int height)
			: base(null)
		{
		}

		public MLImageFeature(NativeArray<byte> pixelBuffer, int width, int height)
			: base(null)
		{
		}

		public unsafe MLImageFeature(void* pixelBuffer, int width, int height)
			: base(null)
		{
		}

		public MLImageFeature(MLCloudFeature feature)
			: base(null)
		{
		}

		public void CopyTo(MLImageFeature destination)
		{
		}

		public void CopyTo(MLImageFeature destination, Rect rect, float rotation = 0f, Color32 background = default(Color32))
		{
		}

		public void CopyTo(MLImageFeature destination, RectInt rect, float rotation = 0f, Color32 background = default(Color32))
		{
		}

		public void CopyTo(Texture2D destination, bool upload = true)
		{
		}

		public Texture2D ToTexture()
		{
			return null;
		}

		public Vector2 TransformPoint(Vector2 point, MLImageType featureType)
		{
			return default(Vector2);
		}

		public Rect TransformRect(Rect rect, MLImageType featureType)
		{
			return default(Rect);
		}

		public static int[] NonMaxSuppression(IReadOnlyList<Rect> rects, IReadOnlyList<float> scores, float maxIoU)
		{
			return null;
		}

		public static float IntersectionOverUnion(Rect a, Rect b)
		{
			return 0f;
		}

		public ref byte GetPinnableReference()
		{
			throw null;
		}

		MLEdgeFeature IMLEdgeFeature.Create(MLFeatureType type)
		{
			return default(MLEdgeFeature);
		}

		MLCloudFeature IMLCloudFeature.Create(MLFeatureType _)
		{
			return default(MLCloudFeature);
		}

		private static byte[] ToPixelBuffer(Color32[] colorBuffer, int width, int height)
		{
			return null;
		}
	}
}
