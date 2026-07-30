using CodeStage.AntiCheat.Storage;
using UnityEngine;

namespace CodeStage.AntiCheat.Examples
{
	[AddComponentMenu(null)]
	internal class ExamplesGUI : MonoBehaviour
	{
		private enum ExamplePage
		{
			ObscuredTypes = 0,
			ObscuredPrefs = 1,
			Detectors = 2,
			CodeHashing = 3
		}

		private const string RedColor = "#FF4040";

		private const string YellowColor = "#E9D604";

		private const string GreenColor = "#02C85F";

		[Header("Examples")]
		public ObscuredTypesExamples obscuredTypesExamples;

		public ObscuredPrefsExamples obscuredPrefsExamples;

		public DetectorsExamples detectorsExamples;

		public CodeHashExample codeHashExample;

		private readonly string[] tabs;

		private ExamplePage currentPage;

		private string allSimpleObscuredTypes;

		private ObscuredPrefs.DeviceLockLevel savesLock;

		private GUIStyle centeredStyle;

		private void OnGUI()
		{
		}

		private void DrawObscuredTypesPage()
		{
		}

		private void DrawObscuredPrefsPage()
		{
		}

		private void DrawDetectorsPage()
		{
		}

		private void DrawCodeHashingPage()
		{
		}

		private string GetAllSimpleObscuredTypes()
		{
			return null;
		}

		private string GetAllObscuredPrefsDataTypes()
		{
			return null;
		}
	}
}
