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
        public static void ktxTexture_Destroy(ktxTexture* texture) => texture->vtbl->Destroy(texture);

        public static ktx_error_code_e ktxTexture_GetImageOffset(ktxTexture* texture, uint level, uint layer, uint faceOrSlice, out UIntPtr pOffset)
        {
            fixed (UIntPtr* pOffsetPtr = &pOffset)
            {
                return texture->vtbl->GetImageOffset(texture, level, layer, faceOrSlice, pOffsetPtr);
            }
        }

        public static UIntPtr ktxTexture_GetDataSizeUncompressed(ktxTexture* texture) => texture->vtbl->GetDataSizeUncompressed(texture);

        public static UIntPtr ktxTexture_GetImageSize(ktxTexture* texture, uint level) => texture->vtbl->GetImageSize(texture, level);
        public static UIntPtr ktxTexture_GetLevelSize(ktxTexture* texture, uint level) => texture->vtbl->GetLevelSize(texture, level);

        public static ktx_error_code_e ktxTexture_IterateLevels(ktxTexture* texture, PFNKTXITERCB callback, void* userData) => texture->vtbl->IterateLevels(texture, callback, userData);
        public static ktx_error_code_e ktxTexture_IterateLoadLevelFaces(ktxTexture* texture, PFNKTXITERCB callback, void* userData) => texture->vtbl->IterateLoadLevelFaces(texture, callback, userData);

        public static bool ktxTexture_NeedsTranscoding(ktxTexture* texture) => texture->vtbl->NeedsTranscoding(texture) != 0;

        public static ktx_error_code_e ktxTexture_LoadImageData(ktxTexture* texture, byte* buffer, UIntPtr bufferSize) => texture->vtbl->LoadImageData(texture, buffer, bufferSize);
        
        public static ktx_error_code_e ktxTexture_SetImageFromMemory(ktxTexture* texture, uint level, uint layer, uint faceOrSlice, byte* buffer, UIntPtr bufferSize)
            => texture->vtbl->SetImageFromMemory(texture, level, layer, faceOrSlice, buffer, bufferSize);
        public static ktx_error_code_e ktxTexture_WriteToNamedFile(ktxTexture* texture, string filePath)
        {
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(filePath);
            fixed (byte* ptr = byteArray)
            {
                return texture->vtbl->WriteToNamedFile(texture, ptr);
            }
        }
        public static ktx_error_code_e ktxTexture_WriteToMemory(ktxTexture* texture, byte** bytes, UIntPtr* size)
        {
                return texture->vtbl->WriteToMemory(texture, bytes, size);
        }





    }
}
