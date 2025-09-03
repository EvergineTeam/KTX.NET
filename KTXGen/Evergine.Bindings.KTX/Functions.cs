using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Evergine.Bindings.KTX
{
    public static unsafe partial class KTX
    {
        [DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 ktxTexture_GetVkFormat(ktxTexture* This);

        public static void ktxTexture_Destroy(ktxTexture* texture)
        {
            var f = Marshal.GetDelegateForFunctionPointer<PFNKTEXDESTROY>(texture->vtbl->Destroy);
            f(texture);
        }

        public static ktx_error_code_e ktxTexture_GetImageOffset(ktxTexture* texture, uint level, uint layer, uint faceOrSlice, out UIntPtr pOffset)
        {
            fixed (UIntPtr* pOffsetPtr = &pOffset)
            {
                var f = Marshal.GetDelegateForFunctionPointer<PFNKTEXGETIMAGEOFFSET>(texture->vtbl->GetImageOffset);
                return f(texture, level, layer, faceOrSlice, pOffsetPtr);
            }
        }

        public static UIntPtr ktxTexture_GetDataSizeUncompressed(ktxTexture* texture)
        {
            var f = Marshal.GetDelegateForFunctionPointer<PFNKTEXGETDATASIZEUNCOMPRESSED>(texture->vtbl->GetDataSizeUncompressed);
            return f(texture);
        }

        public static UIntPtr ktxTexture_GetImageSize(ktxTexture* texture, uint level)
        {
            var f = Marshal.GetDelegateForFunctionPointer<PFNKTEXGETIMAGESIZE>(texture->vtbl->GetImageSize);
            return f(texture, level);
        }
        public static UIntPtr ktxTexture_GetLevelSize(ktxTexture* texture, uint level)
        {
            var f = Marshal.GetDelegateForFunctionPointer<PFNKTEXGETLEVELSIZE>(texture->vtbl->GetLevelSize);
            return f(texture, level);
        }

        public static ktx_error_code_e ktxTexture_IterateLevels(ktxTexture* texture, PFNKTXITERCB callback, void* userData)
        {
            var f = Marshal.GetDelegateForFunctionPointer<PFNKTEXITERATELEVELS>(texture->vtbl->IterateLevels);
            return f(texture, callback, userData);
        }

        public static ktx_error_code_e ktxTexture_IterateLoadLevelFaces(ktxTexture* texture, PFNKTXITERCB callback, void* userData)
        {
            var f = Marshal.GetDelegateForFunctionPointer<PFNKTEXITERATELOADLEVELFACES>(texture->vtbl->IterateLoadLevelFaces);
            return f(texture, callback, userData);
        }

        public static bool ktxTexture_NeedsTranscoding(ktxTexture* texture)
        {
            var f = Marshal.GetDelegateForFunctionPointer<PFNKTEXNEEDSTRANSCODING>(texture->vtbl->NeedsTranscoding);
            return f(texture) != 0;
        }

        public static ktx_error_code_e ktxTexture_LoadImageData(ktxTexture* texture, byte* buffer, UIntPtr bufferSize)
        {
            var f = Marshal.GetDelegateForFunctionPointer<PFNKTEXLOADIMAGEDATA>(texture->vtbl->LoadImageData);
            return f(texture, buffer, bufferSize);
        }

        public static ktx_error_code_e ktxTexture_SetImageFromMemory(ktxTexture* texture, uint level, uint layer, uint faceOrSlice, byte* buffer, UIntPtr bufferSize)
        {
            var f = Marshal.GetDelegateForFunctionPointer<PFNKTEXSETIMAGEFROMMEMORY>(texture->vtbl->SetImageFromMemory);
            return f(texture, level, layer, faceOrSlice, buffer, bufferSize);
        }

        public static ktx_error_code_e ktxTexture_WriteToNamedFile(ktxTexture* texture, string filePath)
        {
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(filePath);
            fixed (byte* ptr = byteArray)
            {
                var f = Marshal.GetDelegateForFunctionPointer<PFNKTEXWRITETONAMEDFILE>(texture->vtbl->WriteToNamedFile);
                return f(texture, ptr);
            }
        }
        public static ktx_error_code_e ktxTexture_WriteToMemory(ktxTexture* texture, byte** bytes, UIntPtr* size)
        {
            var f = Marshal.GetDelegateForFunctionPointer<PFNKTEXWRITETOMEMORY>(texture->vtbl->WriteToMemory);
            return f(texture, bytes, size);
        }
    }
}
