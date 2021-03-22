using System;
namespace SoundIOSharp
{
	public enum SoundIOBackend
	{
		None = 0,
		Jack = 1,
		PulseAudio = 2,
		Alsa = 3,
		CoreAudio = 4,
		Wasapi = 5,

		Android = 6,
		Dummy = 7,
	}

}
