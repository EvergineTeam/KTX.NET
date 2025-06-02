using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Evergine.Bindings.KTX
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ktxHashListEntry { IntPtr ptr; }
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ktxHashList { ktxHashListEntry entry; }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ktxTexture_vtbl
    {
        public IntPtr Destroy;
		public IntPtr GetImageOffset;
		public IntPtr GetDataSizeUncompressed;
		public IntPtr GetImageSize;
		public IntPtr GetLevelSize;
		public IntPtr IterateLevels;
		public IntPtr IterateLoadLevelFaces;
		public IntPtr NeedsTranscoding;
		public IntPtr LoadImageData;
		public IntPtr SetImageFromMemory;
		public IntPtr SetImageFromStdioStream;
		public IntPtr WriteToStdioStream;
		public IntPtr WriteToNamedFile;
		public IntPtr WriteToMemory;
		public IntPtr WriteToStream;
	}
}
