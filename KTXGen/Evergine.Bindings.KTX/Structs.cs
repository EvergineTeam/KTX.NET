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
}
