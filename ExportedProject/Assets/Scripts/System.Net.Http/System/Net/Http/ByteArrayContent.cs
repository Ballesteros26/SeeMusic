using System.IO;
using System.Threading.Tasks;

namespace System.Net.Http
{
	/// <summary>Provides HTTP content based on a byte array.</summary>
	public class ByteArrayContent : HttpContent
	{
		private readonly byte[] content;

		private readonly int offset;

		private readonly int count;

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.ByteArrayContent" /> class.</summary>
		/// <param name="content">The content used to initialize the <see cref="T:System.Net.Http.ByteArrayContent" />.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="content" /> parameter is null. </exception>
		public ByteArrayContent(byte[] content)
		{
		}

		/// <summary>Creates an HTTP content stream as an asynchronous operation for reading whose backing store is memory from the <see cref="T:System.Net.Http.ByteArrayContent" />.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task`1" />.The task object representing the asynchronous operation.</returns>
		protected override Task<Stream> CreateContentReadStreamAsync()
		{
			return null;
		}

		/// <summary>Serialize and write the byte array provided in the constructor to an HTTP content stream as an asynchronous operation.</summary>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />. The task object representing the asynchronous operation.</returns>
		/// <param name="stream">The target stream.</param>
		/// <param name="context">Information about the transport, like channel binding token. This parameter may be null.</param>
		protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
		{
			return null;
		}

		/// <summary>Determines whether a byte array has a valid length in bytes.</summary>
		/// <returns>Returns <see cref="T:System.Boolean" />.true if <paramref name="length" /> is a valid length; otherwise, false.</returns>
		/// <param name="length">The length in bytes of the byte array.</param>
		protected internal override bool TryComputeLength(out long length)
		{
			length = default(long);
			return false;
		}
	}
}
