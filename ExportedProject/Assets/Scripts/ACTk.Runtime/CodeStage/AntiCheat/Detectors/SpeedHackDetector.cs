using System;
using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_speed_hack_detector.html")]
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Speed Hack Detector")]
	[DisallowMultipleComponent]
	public class SpeedHackDetector : ACTkDetectorBase<SpeedHackDetector>
	{
		public const string ComponentName = "Speed Hack Detector";

		internal const string FinalLogPrefix = "[ACTk] Speed Hack Detector: ";

		[Tooltip("Time (in seconds) between detector checks.")]
		public float interval;

		[Tooltip("Allowed speed multiplier threshold. Do not set to too low values (e.g. 0 or 0.00*) since there are timer fluctuations on different hardware.")]
		[Range(0.05f, 5f)]
		public float threshold;

		[Tooltip("Maximum false positives count allowed before registering speed hack.")]
		public byte maxFalsePositives;

		[Tooltip("Amount of sequential successful checks before clearing internal false positives counter.\nSet 0 to disable Cool Down feature.")]
		public int coolDown;

		private byte currentFalsePositives;

		private int currentCooldownShots;

		private long previousReliableTicks;

		private long previousVulnerableEnvironmentTicks;

		private long previousVulnerableRealtimeTicks;

		public static SpeedHackDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		public static SpeedHackDetector StartDetection()
		{
			return null;
		}

		public static SpeedHackDetector StartDetection(Action callback)
		{
			return null;
		}

		public static SpeedHackDetector StartDetection(Action callback, float interval)
		{
			return null;
		}

		public static SpeedHackDetector StartDetection(Action callback, float interval, byte maxFalsePositives)
		{
			return null;
		}

		public static SpeedHackDetector StartDetection(Action callback, float interval, byte maxFalsePositives, int coolDown)
		{
			return null;
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
		}

		private SpeedHackDetector()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		private void Update()
		{
		}

		private SpeedHackDetector StartDetectionInternal(Action callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
			return null;
		}

		protected override void StartDetectionAutomatically()
		{
		}

		protected override string GetComponentName()
		{
			return null;
		}

		private void ResetLastTicks()
		{
		}
	}
}
