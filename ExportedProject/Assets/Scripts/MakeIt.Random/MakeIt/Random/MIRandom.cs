using System;
using System.Reflection;
using UnityEngine;

namespace MakeIt.Random
{
	public static class MIRandom
	{
		private static Type _standardType;

		private static MethodInfo _standardCreator;

		private static object[] _standardCreatorParameters;

		private static IRandom _shared;

		public static IRandom shared
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void InitializeStaticFields()
		{
		}

		private static void FindStandardCreator()
		{
		}

		private static void CreateShared()
		{
		}

		public static IRandom CreateStandard()
		{
			return null;
		}

		public static IRandom CreateStandard(int seed)
		{
			return null;
		}

		public static IRandom CreateStandard(params int[] seed)
		{
			return null;
		}

		public static IRandom CreateStandard(string seed)
		{
			return null;
		}

		public static IRandom CreateStandard(IBitGenerator bitGenerator)
		{
			return null;
		}
	}
}
