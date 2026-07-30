using System.ComponentModel;
using System.Diagnostics;

namespace System.IO.Ports
{
	/// <summary>Represents a serial port resource.</summary>
	[MonitoringDescription("SerialPortDesc")]
	public class SerialPort : Component
	{
		/// <summary>Indicates that no time-out should occur.</summary>
		public const int InfiniteTimeout = -1;

		/// <summary>Initializes a new instance of the <see cref="T:System.IO.Ports.SerialPort" /> class using the specified port name and baud rate.</summary>
		/// <param name="portName">The port to use (for example, COM1). </param>
		/// <param name="baudRate">The baud rate. </param>
		/// <exception cref="T:System.IO.IOException">The specified port could not be found or opened.</exception>
		public SerialPort(string portName, int baudRate)
		{
		}

		/// <summary>Closes the port connection, sets the <see cref="P:System.IO.Ports.SerialPort.IsOpen" /> property to false, and disposes of the internal <see cref="T:System.IO.Stream" /> object.</summary>
		/// <exception cref="T:System.IO.IOException">The port is in an invalid state.- or -An attempt to set the state of the underlying port failed. For example, the parameters passed from this <see cref="T:System.IO.Ports.SerialPort" /> object were invalid.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		public void Close()
		{
		}

		/// <summary>Gets an array of serial port names for the current computer.</summary>
		/// <returns>An array of serial port names for the current computer.</returns>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The serial port names could not be queried.</exception>
		public static string[] GetPortNames()
		{
			return null;
		}

		/// <summary>Opens a new serial port connection.</summary>
		/// <exception cref="T:System.UnauthorizedAccessException">Access is denied to the port.- or -The current process, or another process on the system, already has the specified COM port open either by a <see cref="T:System.IO.Ports.SerialPort" /> instance or in unmanaged code.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">One or more of the properties for this instance are invalid. For example, the <see cref="P:System.IO.Ports.SerialPort.Parity" />, <see cref="P:System.IO.Ports.SerialPort.DataBits" />, or <see cref="P:System.IO.Ports.SerialPort.Handshake" /> properties are not valid values; the <see cref="P:System.IO.Ports.SerialPort.BaudRate" /> is less than or equal to zero; the <see cref="P:System.IO.Ports.SerialPort.ReadTimeout" /> or <see cref="P:System.IO.Ports.SerialPort.WriteTimeout" /> property is less than zero and is not <see cref="F:System.IO.Ports.SerialPort.InfiniteTimeout" />. </exception>
		/// <exception cref="T:System.ArgumentException">The port name does not begin with "COM". - or -The file type of the port is not supported.</exception>
		/// <exception cref="T:System.IO.IOException">The port is in an invalid state.  - or - An attempt to set the state of the underlying port failed. For example, the parameters passed from this <see cref="T:System.IO.Ports.SerialPort" /> object were invalid.</exception>
		/// <exception cref="T:System.InvalidOperationException">The specified port on the current instance of the <see cref="T:System.IO.Ports.SerialPort" /> is already open.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		public void Open()
		{
		}

		/// <summary>Writes a specified number of bytes to the serial port using data from a buffer.</summary>
		/// <param name="buffer">The byte array that contains the data to write to the port. </param>
		/// <param name="offset">The zero-based byte offset in the <paramref name="buffer" /> parameter at which to begin copying bytes to the port. </param>
		/// <param name="count">The number of bytes to write. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="buffer" /> passed is null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The specified port is not open. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="offset" /> or <paramref name="count" /> parameters are outside a valid region of the <paramref name="buffer" /> being passed. Either <paramref name="offset" /> or <paramref name="count" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="offset" /> plus <paramref name="count" /> is greater than the length of the <paramref name="buffer" />. </exception>
		/// <exception cref="T:System.ServiceProcess.TimeoutException">The operation did not complete before the time-out period ended. </exception>
		public void Write(byte[] buffer, int offset, int count)
		{
		}
	}
}
