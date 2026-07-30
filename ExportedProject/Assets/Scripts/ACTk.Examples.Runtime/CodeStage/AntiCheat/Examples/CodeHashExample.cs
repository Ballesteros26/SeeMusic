using CodeStage.AntiCheat.Genuine.CodeHash;
using UnityEngine;

namespace CodeStage.AntiCheat.Examples
{
	internal class CodeHashExample : MonoBehaviour
	{
		public string savedSummaryHash;

		public HashGeneratorResult LastResult { get; private set; }

		public bool IsBusy => false;

		public bool IsSupported => false;

		public bool IsGenuineValueSetInInspector => false;

		public void Init()
		{
		}

		public void StartGeneration()
		{
		}

		public bool SummaryHashMatches()
		{
			return false;
		}

		private void OnHashGenerated(HashGeneratorResult result)
		{
		}
	}
}
