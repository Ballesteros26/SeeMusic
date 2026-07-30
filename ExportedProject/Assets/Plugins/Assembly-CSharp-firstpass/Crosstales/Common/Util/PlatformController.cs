using System.Collections.Generic;
using Crosstales.Common.Model.Enum;
using UnityEngine;

namespace Crosstales.Common.Util
{
	public class PlatformController : MonoBehaviour
	{
		[Tooltip("Selected platforms for the controller.")]
		[Header("Configuration")]
		public List<Platform> Platforms;

		[Tooltip("Enable or disable the 'Objects' for the selected 'Platforms' (default: true).")]
		public bool Active;

		[Tooltip("Selected objects for the controller.")]
		[Header("GameObjects")]
		public GameObject[] Objects;

		[Tooltip("Selected scripts for the controller.")]
		[Header("MonoBehaviour Scripts")]
		public MonoBehaviour[] Scripts;

		protected Platform _currentPlatform;

		protected virtual void Awake()
		{
		}

		private void Start()
		{
		}

		protected void selectPlatform()
		{
		}

		protected void activateGameObjects()
		{
		}

		protected void activateScripts()
		{
		}
	}
}
