namespace System.Threading.Tasks
{
	internal static class GenericDelegateCache<TAntecedentResult, TResult>
	{
		internal static Func<Task<Task>, object, TResult> CWAnyFuncDelegate;

		internal static Func<Task<Task>, object, TResult> CWAnyActionDelegate;

		internal static Func<Task<Task<TAntecedentResult>[]>, object, TResult> CWAllFuncDelegate;

		internal static Func<Task<Task<TAntecedentResult>[]>, object, TResult> CWAllActionDelegate;
	}
}
