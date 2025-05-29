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
        public PFNKTEXDESTROY Destroy;
		public PFNKTEXGETIMAGEOFFSET GetImageOffset;
		public PFNKTEXGETDATASIZEUNCOMPRESSED GetDataSizeUncompressed;
		public PFNKTEXGETIMAGESIZE GetImageSize;
		public PFNKTEXGETLEVELSIZE GetLevelSize;
		public PFNKTEXITERATELEVELS IterateLevels;
		public PFNKTEXITERATELOADLEVELFACES IterateLoadLevelFaces;
		public PFNKTEXNEEDSTRANSCODING NeedsTranscoding;
		public PFNKTEXLOADIMAGEDATA LoadImageData;
		public PFNKTEXSETIMAGEFROMMEMORY SetImageFromMemory;
		public IntPtr SetImageFromStdioStream;
		public IntPtr WriteToStdioStream;
		public PFNKTEXWRITETONAMEDFILE WriteToNamedFile;
		public PFNKTEXWRITETOMEMORY WriteToMemory;
		public IntPtr WriteToStream;
	}
}
