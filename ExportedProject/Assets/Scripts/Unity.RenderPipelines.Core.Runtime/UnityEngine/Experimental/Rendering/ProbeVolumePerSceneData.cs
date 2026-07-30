using System;
using System.Collections.Generic;

namespace UnityEngine.Experimental.Rendering
{
	[AddComponentMenu(null)]
	[ExecuteAlways]
	internal class ProbeVolumePerSceneData : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Serializable]
		private struct SerializableAssetItem
		{
			[SerializeField]
			public ProbeVolumeState state;

			[SerializeField]
			public ProbeVolumeAsset asset;
		}

		internal Dictionary<ProbeVolumeState, ProbeVolumeAsset> assets;

		[SerializeField]
		private List<SerializableAssetItem> serializedAssets;

		private ProbeVolumeState m_CurrentState;

		private ProbeVolumeState m_PreviousState;

		public void OnAfterDeserialize()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		internal void StoreAssetForState(ProbeVolumeState state, ProbeVolumeAsset asset)
		{
		}

		internal void InvalidateAllAssets()
		{
		}

		internal ProbeVolumeAsset GetCurrentStateAsset()
		{
			return null;
		}

		internal void QueueAssetLoading()
		{
		}

		internal void QueueAssetRemoval()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}
	}
}
