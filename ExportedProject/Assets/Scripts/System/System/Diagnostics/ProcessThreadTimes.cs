namespace System.Diagnostics
{
	internal class ProcessThreadTimes
	{
		internal long create;

		internal long exit;

		internal long kernel;

		internal long user;

		public DateTime StartTime => default(DateTime);

		public DateTime ExitTime => default(DateTime);

		public TimeSpan PrivilegedProcessorTime => default(TimeSpan);

		public TimeSpan UserProcessorTime => default(TimeSpan);

		public TimeSpan TotalProcessorTime => default(TimeSpan);
	}
}
