namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	public interface ICodeHashGenerator
	{
		HashGeneratorResult LastResult { get; }

		bool IsBusy { get; }

		ICodeHashGenerator Generate();
	}
}
