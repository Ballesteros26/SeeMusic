using UnityEngine;

namespace MH.WaterCausticsModules
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[AddComponentMenu(null)]
	internal class AtOnce : MonoBehaviour
	{
		private WaterCausticsEffect _summoner;

		private MeshRenderer _render;

		private bool _inited;

		private Mesh __mesh;

		internal MeshRenderer render => null;

		private void setRenderEnable(bool isOn)
		{
		}

		private AtOnce init(WaterCausticsEffect summoner, Material mat)
		{
			return null;
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		private void updateTransform()
		{
		}

		private void Update()
		{
		}

		private Mesh getMesh()
		{
			return null;
		}

		internal static AtOnce Create(WaterCausticsEffect summoner, Material mat)
		{
			return null;
		}

		internal static void OnSummonerDestroyed(ref AtOnce a)
		{
		}

		private static void destroy<T>(ref T o) where T : Object
		{
		}

		private static void destroy(Object o)
		{
		}
	}
}
