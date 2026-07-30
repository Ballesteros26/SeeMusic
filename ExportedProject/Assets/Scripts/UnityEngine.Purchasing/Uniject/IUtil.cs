using System;
using System.Collections;

namespace Uniject
{
	internal interface IUtil
	{
		object InitiateCoroutine(IEnumerator start);

		void InitiateCoroutine(IEnumerator start, int delayInSeconds);

		void RunOnMainThread(Action runnable);

		void AddPauseListener(Action<bool> runnable);

		bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant);
	}
}
