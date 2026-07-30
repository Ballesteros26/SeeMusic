using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.SceneManagement;

namespace UnityEngine.Experimental.Rendering
{
	[Serializable]
	public class ProbeVolumeSceneData : ISerializationCallbackReceiver
	{
		[Serializable]
		private struct SerializableBoundItem
		{
			[SerializeField]
			public string sceneGUID;

			[SerializeField]
			public Bounds bounds;
		}

		[Serializable]
		private struct SerializableHasPVItem
		{
			[SerializeField]
			public string sceneGUID;

			[SerializeField]
			public bool hasProbeVolumes;
		}

		[Serializable]
		private struct SerializablePVProfile
		{
			[SerializeField]
			public string sceneGUID;

			[SerializeField]
			public ProbeReferenceVolumeProfile profile;
		}

		[Serializable]
		private struct SerializablePVBakeSettings
		{
			[SerializeField]
			public string sceneGUID;

			[SerializeField]
			public ProbeVolumeBakingProcessSettings settings;
		}

		[Serializable]
		internal class BakingSet
		{
			public string name;

			public List<string> sceneGUIDs;

			public ProbeVolumeBakingProcessSettings settings;

			public ProbeReferenceVolumeProfile profile;
		}

		private static PropertyInfo s_SceneGUID;

		[SerializeField]
		private List<SerializableBoundItem> serializedBounds;

		[SerializeField]
		private List<SerializableHasPVItem> serializedHasVolumes;

		[SerializeField]
		private List<SerializablePVProfile> serializedProfiles;

		[SerializeField]
		private List<SerializablePVBakeSettings> serializedBakeSettings;

		[SerializeField]
		private List<BakingSet> serializedBakingSets;

		internal Object parentAsset;

		internal string parentSceneDataPropertyName;

		public Dictionary<string, Bounds> sceneBounds;

		internal Dictionary<string, bool> hasProbeVolumes;

		internal Dictionary<string, ProbeReferenceVolumeProfile> sceneProfiles;

		internal Dictionary<string, ProbeVolumeBakingProcessSettings> sceneBakingSettings;

		internal List<BakingSet> bakingSets;

		private string GetSceneGUID(Scene scene)
		{
			return null;
		}

		public ProbeVolumeSceneData(Object parentAsset, string parentSceneDataPropertyName)
		{
		}

		public void SetParentObject(Object parent, string parentSceneDataPropertyName)
		{
		}

		public void OnAfterDeserialize()
		{
		}

		private void UpdateBakingSets()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		internal BakingSet CreateNewBakingSet(string name)
		{
			return null;
		}

		private void InitializeBakingSet(BakingSet set, string name)
		{
		}

		internal void SyncBakingSetSettings()
		{
		}
	}
}
