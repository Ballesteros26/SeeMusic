using UnityEngine;

namespace CodeStage.AntiCheat.Examples
{
	[AddComponentMenu(null)]
	internal class InfiniteRotatorReliable : MonoBehaviour
	{
		[Range(1f, 100f)]
		public float speed;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
