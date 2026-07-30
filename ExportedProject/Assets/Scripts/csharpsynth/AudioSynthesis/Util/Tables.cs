namespace AudioSynthesis.Util
{
	public static class Tables
	{
		internal static readonly float[][] EnvelopeTables;

		internal static readonly double[] SemitoneTable;

		internal static readonly double[] CentTable;

		static Tables()
		{
		}

		public static double[] CreateCentTable()
		{
			return null;
		}

		public static double[] CreateSemitoneTable()
		{
			return null;
		}

		public static float[] CreateSustainTable(int size)
		{
			return null;
		}

		public static float[] CreateLinearTable(int size)
		{
			return null;
		}

		public static float[] CreateConcaveTable(int size)
		{
			return null;
		}

		public static float[] CreateConvexTable(int size)
		{
			return null;
		}

		private static float[] RemoveDenormals(float[] data)
		{
			return null;
		}
	}
}
