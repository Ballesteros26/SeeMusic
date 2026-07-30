using System.IO;

namespace Better.StreamingAssets
{
	internal class SubReadOnlyStream : Stream
	{
		private readonly long m_offset;

		private readonly bool m_leaveOpen;

		private long? m_length;

		private Stream m_actualStream;

		private long m_position;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public SubReadOnlyStream(Stream actualStream, bool leaveOpen = false)
		{
		}

		public SubReadOnlyStream(Stream actualStream, long offset, long length, bool leaveOpen = false)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void Flush()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void ThrowIfDisposed()
		{
		}

		private void ThrowIfCantRead()
		{
		}
	}
}
