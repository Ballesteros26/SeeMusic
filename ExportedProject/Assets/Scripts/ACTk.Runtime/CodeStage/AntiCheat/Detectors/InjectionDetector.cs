using System;
using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Injection Detector")]
	[DisallowMultipleComponent]
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_injection_detector.html")]
	public class InjectionDetector : ACTkDetectorBase<InjectionDetector>
	{
		public delegate void InjectionDetectedEventHandler(string reason);

		public const string ComponentName = "Injection Detector";

		internal const string FinalLogPrefix = "[ACTk] Injection Detector: ";

		public static InjectionDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		public static void StartDetection()
		{
		}

		public static void StartDetection(Action<string> callback)
		{
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
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
