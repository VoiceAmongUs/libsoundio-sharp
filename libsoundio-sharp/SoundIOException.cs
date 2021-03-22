using System;
using System.Runtime.InteropServices;

namespace SoundIOSharp
{
	public class SoundIOException : Exception
	{
		internal SoundIOException (SoundIoError errorCode)
			: base (Marshal.PtrToStringAnsi (Natives.soundio_error_name(errorCode)))
		{
		}
	}
}
