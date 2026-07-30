using System;
using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Obscured Cheating Detector")]
	[DisallowMultipleComponent]
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_obscured_cheating_detector.html")]
	public class ObscuredCheatingDetector : ACTkDetectorBase<ObscuredCheatingDetector>
	{
		public const string ComponentName = "Obscured Cheating Detector";

		internal const string FinalLogPrefix = "[ACTk] Obscured Cheating Detector: ";

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredDouble. Increase in case of false positives.")]
		public double doubleEpsilon;

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredFloat. Increase in case of false positives.")]
		public float floatEpsilon;

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector2. Increase in case of false positives.")]
		public float vector2Epsilon;

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector3. Increase in case of false positives.")]
		public float vector3Epsilon;

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredQuaternion. Increase in case of false positives.")]
		public float quaternionEpsilon;

		internal static bool ExistsAndIsRunning => false;

		public static ObscuredCheatingDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		public static ObscuredCheatingDetector StartDetection()
		{
			return null;
		}

		public static ObscuredCheatingDetector StartDetection(Action callback)
		{
			return null;
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
		}

		private ObscuredCheatingDetector()
		{
		}

		private ObscuredCheatingDetector StartDetectionInternal(Action callback)
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
	}
}
