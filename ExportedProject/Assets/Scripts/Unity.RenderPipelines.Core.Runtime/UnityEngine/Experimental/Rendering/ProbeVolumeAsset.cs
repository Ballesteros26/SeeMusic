using System;
using System.Collections.Generic;

namespace UnityEngine.Experimental.Rendering
{
	[PreferBinarySerialization]
	internal class ProbeVolumeAsset : ScriptableObject
	{
		[Serializable]
		internal enum AssetVersion
		{
			First = 0,
			AddProbeVolumesAtlasEncodingModes = 1,
			PV2 = 2,
			ChunkBasedIndex = 3,
			Max = 4,
			Current = 3
		}

		[SerializeField]
		protected internal int m_Version;

		[SerializeField]
		internal List<ProbeReferenceVolume.Cell> cells;

		[SerializeField]
		internal Vector3Int maxCellPosition;

		[SerializeField]
		internal Vector3Int minCellPosition;

		[SerializeField]
		internal Bounds globalBounds;

		[SerializeField]
		internal ProbeVolumeSHBands bands;

		[SerializeField]
		private string m_AssetFullPath;

		[SerializeField]
		internal int cellSizeInBricks;

		[SerializeField]
		internal float minDistanceBetweenProbes;

		[SerializeField]
		internal int simplificationLevels;

		[SerializeField]
		public int Version => 0;

		internal int maxSubdivision => 0;

		internal float minBrickSize => 0f;

		internal bool CompatibleWith(ProbeVolumeAsset otherAsset)
		{
			return false;
		}

		public string GetSerializedFullPath()
		{
			return null;
		}
	}
}
