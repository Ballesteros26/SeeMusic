using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ForieroEngine
{
	public class EventManager : MonoBehaviour
	{
		public struct Test : IEMEvent
		{
			public int i;
		}

		public interface IEMEvent
		{
		}

		public delegate void EventDelegate<T>(T e) where T : IEMEvent;

		private delegate void EventDelegate(IEMEvent e);

		private static bool limitQueueProcesing;

		private static float queueProcessTime;

		private static Queue m_eventQueue;

		private static Dictionary<Type, EventDelegate> delegates;

		private static Dictionary<Delegate, EventDelegate> delegateLookup;

		private static Dictionary<Delegate, Delegate> onceLookups;

		private IEMEvent evt;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Init()
		{
		}

		private static EventDelegate AddDelegate<T>(EventDelegate<T> del) where T : IEMEvent
		{
			return null;
		}

		public static void AddListener<T>(EventDelegate<T> del) where T : IEMEvent
		{
		}

		public void AddListenerOnce<T>(EventDelegate<T> del) where T : IEMEvent
		{
		}

		public static void RemoveListener<T>(EventDelegate<T> del) where T : IEMEvent
		{
		}

		public static void RemoveAll()
		{
		}

		public static bool HasListener<T>(EventDelegate<T> del) where T : IEMEvent
		{
			return false;
		}

		public static void TriggerEvent(IEMEvent e)
		{
		}

		public static bool QueueEvent(IEMEvent evt)
		{
			return false;
		}

		private void Update()
		{
		}

		public void OnApplicationQuit()
		{
		}
	}
}
