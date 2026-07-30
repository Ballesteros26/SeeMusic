using System;
using System.Collections.Generic;
using UnityEngine;

namespace ForieroEngine.Threading.Unity
{
	public class MainThreadDispatcher : MonoBehaviour, IThreadRunner
	{
		public enum UpdateType
		{
			FixedUpdate = 0,
			Update = 1,
			LateUpdate = 2
		}

		public delegate void UpdateEvent();

		public static UpdateEvent unityFixedUpdate;

		public static UpdateEvent unityUpdate;

		public static UpdateEvent unityLateUpdate;

		private static MainThreadDispatcher _instance;

		private static Dictionary<UpdateType, Queue<Action>> actionQueueDict;

		private static Dictionary<UpdateType, Queue<Action>> actionRunnerDict;

		public static MainThreadDispatcher Instance => null;

		public static void Create()
		{
		}

		private void Awake()
		{
		}

		public void Execute(Action action)
		{
		}

		public static void Run(Action action, UpdateType updateType = UpdateType.FixedUpdate)
		{
		}

		private void HandleActions(UpdateType updateType)
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public static void ThreadSleep(int length)
		{
		}
	}
}
