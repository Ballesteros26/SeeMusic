namespace System.Threading.Tasks
{
	internal sealed class ContinuationResultTaskFromTask<TResult> : Task<TResult>
	{
		private Task m_antecedent;

		public ContinuationResultTaskFromTask(Task antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		{
		}

		internal override void InnerInvoke()
		{
		}
	}
}
