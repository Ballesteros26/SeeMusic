using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Time
{
	[AddComponentMenu(null)]
	[DisallowMultipleComponent]
	public class SpeedHackProofTime : KeepAliveBehaviour<SpeedHackProofTime>
	{
		private static bool inited;

		private static bool speedHackDetected;

		private static float reliableTime;

		private static float reliableDeltaTime;

		private static float reliableUnscaledTime;

		private static float reliableUnscaledDeltaTime;

		private static float reliableRealtimeSinceStartup;

		private static float reliableTimeSinceLevelLoad;

		private static bool warningShot;

		private long currentReliableTicks;

		private long lastFrameReliableTicks;

		private long reliableTicksDelta;

		public static float time => 0f;

		public static float unscaledTime => 0f;

		public static float deltaTime => 0f;

		public static float unscaledDeltaTime => 0f;

		public static float realtimeSinceStartup => 0f;

		public static float timeSinceLevelLoad => 0f;

		protected override string GetComponentName()
		{
			return null;
		}

		private void Update()
		{
		}

		public static void Init()
		{
		}

		public static void Dispose()
		{
		}

		private bool InitInternal()
		{
			return false;
		}

		private void UpdateTimeValuesFromUnityTime()
		{
		}

		private void UpdateReliableTimeValues()
		{
		}

		private void OnSpeedHackDetected()
		{
		}

		protected override void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}
	}
}
