# libsoundio-sharp

libsoundio-sharp is a C# wrapper for [libsoundio](https://github.com/andrewrk/libsoundio) cross-platform audio I/O library. See what's cool at the website. Namely it is...

- cross-platform among various desktop platforms (Windows/Mac/Linux).
- modern features (device detection, channel layouts)
- C-based easy bindable API

.NET platforms lack cross-platform audio I/O solution and therefore C# is still not applied in this area. libsoundio-sharp is created to change it.

libsoundio-sharp makes use of [nclang](https://github.com/atsushieno/nclang/) PInvokeGenerator. It is on top of completely generated code without any changes.

libsoundio-sharp is verified to work on Mono on Linux, and supposed to work on .NET Framework and .NET Core.

The library is provided under the MIT License. Samples are ported from libsoundio which is largely attributed to Andrew Kelley (the original libsoundio author).

# Additional Note

Clone this repository using `git clone --recurse-submodules`.

Nclang requires an installation of clang on your system. Make sure your library search path includes `libclang` (e.g. `C:\Program Files\LLVM\bin` for `libclang.dll` on Windows).

This repository references [libsoundio-docker-build](https://github.com/VoiceAmongUs/libsoundio-docker-build), and contains the same VSCode tasks to instrument the Docker toolchain.