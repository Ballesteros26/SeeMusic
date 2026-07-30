using ForieroEngine.Pooling.Concurrent;

public class ConcurrentPoolExample
{
	public class MyObject : RecyclableObject
	{
		public string Name { get; set; }

		public override void Recycle()
		{
		}
	}

	public static void Example()
	{
	}
}
