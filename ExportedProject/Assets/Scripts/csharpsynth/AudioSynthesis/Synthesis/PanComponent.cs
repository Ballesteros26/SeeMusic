namespace AudioSynthesis.Synthesis
{
	public struct PanComponent
	{
		public float Left;

		public float Right;

		public PanComponent(float value, PanFormulaEnum formula)
		{
			Left = 0f;
			Right = 0f;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
