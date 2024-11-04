using System.Reflection;
using System.Runtime.InteropServices;
using BigIntegerGMP2.Native.NLEngine;

namespace BigIntegerGMP2.Native.Mpfr
{
    internal static partial class NativeMethods
    {
        #region Externals
        [DllImport("kernel32")]
        private static extern nint LoadLibrary(string libraryName);

        [DllImport("kernel32", CharSet = CharSet.Ansi)]
        private static extern nint GetProcAddress(nint hwnd, string procedureName);

        private static DLLFromMemory? _mpirLoader = null;
        private static DLLFromMemory? _mpfrLoader = null;

        private static nint hMpirLib = nint.Zero;
        private static nint hMpfrLib = nint.Zero;

        internal delegate void DymmyDelegate();
        internal static DymmyDelegate DummyPointer { get => Marshal.GetDelegateForFunctionPointer<DymmyDelegate>(GetMpfrPointer(string.Empty)); }

        #endregion

        internal static nint GetMpfrPointer(string name)
        {
#if DEBUG_MEMORYLOAD || RELEASE_MEMORYLOAD
            if (_mpirLoader == null)
                if (!LoadLibraryMemory("mpir.dll", ref _mpirLoader))
                    return nint.Zero;
            if (_mpfrLoader == null)
                if (!LoadLibraryMemory("mpfr.dll", ref _mpfrLoader))
                    return nint.Zero;

            InitializePrecision();

            var res = _mpfrLoader.GetPtrFromFuncName(name);
            if (res == nint.Zero)
                throw new Exception($"Function {name} not found in library.");
            return res;
#else
            if (hMpirLib == nint.Zero)
                if (!LoadLibraryDisk("mpir.dll", ref hMpirLib))
                    return nint.Zero;
            if (hMpfrLib == nint.Zero)
                if (!LoadLibraryDisk("mpfr.dll", ref hMpfrLib))
                    return nint.Zero;

            InitializePrecision();

            var res = GetProcAddress(hMpfrLib, name);
            if (res == nint.Zero)
                throw new Exception($"Function {name} not found in library.");
            return res;
#endif
        }

        internal static bool LoadLibraryMemory(string libraryName, ref DLLFromMemory dllLoader)
        {
            try
            {
                if (dllLoader != null)
                    return false;

                foreach (var res in Assembly.GetExecutingAssembly().GetManifestResourceNames())
                    if (res.EndsWith(libraryName))
                    {
                        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(res);
                        if (stream == null)
                            return false;

                        var buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                        dllLoader = new DLLFromMemory(buffer);
                        return true;
                    }

                return false;
            }
            catch
            {
                return false;
            }
        }
        internal static bool LoadLibraryDisk(string libraryName, ref nint hLib)
        {
            if (hLib != nint.Zero)
                return false;

            var tmpFile = Path.GetTempFileName();
            if(!WriteLibraryToDisk(libraryName, tmpFile))
                return false;

            hLib = LoadLibrary(tmpFile);
            return hLib != nint.Zero;
        }

        internal static bool WriteLibraryToDisk(string libraryName, string outputPath)
        {
            try
            {
                var asm = Assembly.GetExecutingAssembly();
                foreach (var res in asm.GetManifestResourceNames())
                    if (res.EndsWith(libraryName))
                    {
                        using var stream = asm.GetManifestResourceStream(res);
                        if (stream == null)
                            return false;

                        var buffer = new byte[stream.Length];
                        stream.Read(buffer, 0, buffer.Length);
                        File.WriteAllBytes(outputPath, buffer);
                        return true;
                    }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
