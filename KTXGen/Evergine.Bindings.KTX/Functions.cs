using Evergine.Bindings.KTX;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Evergine.Bindings.KTX
{
    public static unsafe partial class KTX
    {
        public static VkFormat ktxTexture1_GetVkFormat(ktxTexture1* This)
        {
            VkFormat vkFormat;

            vkFormat = vkGetFormatFromOpenGLInternalFormat(This->glInternalformat);
            if (vkFormat == VkFormat.UNDEFINED)
            {
                vkFormat = vkGetFormatFromOpenGLFormat(This->glFormat, This->glType);
            }
            return vkFormat;
        }

        public static VkFormat ktxTexture2_GetVkFormat(ktxTexture2* This) => (VkFormat)This->vkFormat;

        public static VkFormat ktxTexture_GetVkFormat(ktxTexture* This)
        {
            if (This->classId == class_id.ktxTexture2_c)
                return ktxTexture2_GetVkFormat((ktxTexture2*)This);
            else
                return ktxTexture1_GetVkFormat((ktxTexture1*)This);
        }

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

        private static VkFormat vkGetFormatFromOpenGLInternalFormat(uint f)
        {
            return f switch
            {
                /*GL_RGB8*/
                0x8051 => VkFormat.R8G8B8_UNORM,
                /*GL_RGBA8*/
                0x8058 => VkFormat.R8G8B8A8_UNORM,
                /*GL_R8_SNORM*/
                0x8F94 => VkFormat.R8_SNORM,
                /*GL_RG8_SNORM*/
                0x8F95 => VkFormat.R8G8_SNORM,
                /*GL_RGB8_SNORM*/
                0x8F96 => VkFormat.R8G8B8_SNORM,
                /*GL_RGBA8_SNORM*/
                0x8F97 => VkFormat.R8G8B8A8_SNORM,
                /*GL_R8UI*/
                0x8232 => VkFormat.R8_UINT,
                /*GL_RG8UI*/
                0x8238 => VkFormat.R8G8_UINT,
                /*GL_RGB8UI*/
                0x8D7D => VkFormat.R8G8B8_UINT,
                /*GL_RGBA8UI*/
                0x8D7C => VkFormat.R8G8B8A8_UINT,
                /*GL_R8I*/
                0x8231 => VkFormat.R8_SINT,
                /*GL_RG8I*/
                0x8237 => VkFormat.R8G8_SINT,
                /*GL_RGB8I*/
                0x8D8F => VkFormat.R8G8B8_SINT,
                /*GL_RGBA8I*/
                0x8D8E => VkFormat.R8G8B8A8_SINT,
                /*GL_SR8*/
                0x8FBD => VkFormat.R8_SRGB,
                /*GL_SRG8*/
                0x8FBE => VkFormat.R8G8_SRGB,
                /*GL_SRGB8*/
                0x8C41 => VkFormat.R8G8B8_SRGB,
                /*GL_SRGB8_ALPHA8*/
                0x8C43 => VkFormat.R8G8B8A8_SRGB,
                /*GL_R16*/
                0x822A => VkFormat.R16_UNORM,
                /*GL_RG16*/
                0x822C => VkFormat.R16G16_UNORM,
                /*GL_RGB16*/
                0x8054 => VkFormat.R16G16B16_UNORM,
                /*GL_RGBA16*/
                0x805B => VkFormat.R16G16B16A16_UNORM,
                /*GL_R16_SNORM*/
                0x8F98 => VkFormat.R16_SNORM,
                /*GL_RG16_SNORM*/
                0x8F99 => VkFormat.R16G16_SNORM,
                /*GL_RGB16_SNORM*/
                0x8F9A => VkFormat.R16G16B16_SNORM,
                /*GL_RGBA16_SNORM*/
                0x8F9B => VkFormat.R16G16B16A16_SNORM,
                /*GL_R16UI*/
                0x8234 => VkFormat.R16_UINT,
                /*GL_RG16UI*/
                0x823A => VkFormat.R16G16_UINT,
                /*GL_RGB16UI*/
                0x8D77 => VkFormat.R16G16B16_UINT,
                /*GL_RGBA16UI*/
                0x8D76 => VkFormat.R16G16B16A16_UINT,
                /*GL_R16I*/
                0x8233 => VkFormat.R16_SINT,
                /*GL_RG16I*/
                0x8239 => VkFormat.R16G16_SINT,
                /*GL_RGB16I*/
                0x8D89 => VkFormat.R16G16B16_SINT,
                /*GL_RGBA16I*/
                0x8D88 => VkFormat.R16G16B16A16_SINT,
                /*GL_R16F*/
                0x822D => VkFormat.R16_SFLOAT,
                /*GL_RG16F*/
                0x822F => VkFormat.R16G16_SFLOAT,
                /*GL_RGB16F*/
                0x881B => VkFormat.R16G16B16_SFLOAT,
                /*GL_RGBA16F*/
                0x881A => VkFormat.R16G16B16A16_SFLOAT,
                /*GL_R32UI*/
                0x8236 => VkFormat.R32_UINT,
                /*GL_RG32UI*/
                0x823C => VkFormat.R32G32_UINT,
                /*GL_RGB32UI*/
                0x8D71 => VkFormat.R32G32B32_UINT,
                /*GL_RGBA32UI*/
                0x8D70 => VkFormat.R32G32B32A32_UINT,
                /*GL_R32I*/
                0x8235 => VkFormat.R32_SINT,
                /*GL_RG32I*/
                0x823B => VkFormat.R32G32_SINT,
                /*GL_RGB32I*/
                0x8D83 => VkFormat.R32G32B32_SINT,
                /*GL_RGBA32I*/
                0x8D82 => VkFormat.R32G32B32A32_SINT,
                /*GL_R32F*/
                0x822E => VkFormat.R32_SFLOAT,
                /*GL_RG32F*/
                0x8230 => VkFormat.R32G32_SFLOAT,
                /*GL_RGB32F*/
                0x8815 => VkFormat.R32G32B32_SFLOAT,
                /*GL_RGBA32F*/
                0x8814 => VkFormat.R32G32B32A32_SFLOAT,
                /*GL_RGB5*/
                0x8050 => VkFormat.R5G5B5A1_UNORM_PACK16,
                /*GL_RGB565*/
                0x8D62 => VkFormat.R5G6B5_UNORM_PACK16,
                /*GL_RGB10*/
                0x8052 => VkFormat.A2R10G10B10_UNORM_PACK32,
                /*GL_RGBA4*/
                0x8056 => VkFormat.R4G4B4A4_UNORM_PACK16,
                /*GL_RGB5_A1*/
                0x8057 => VkFormat.A1R5G5B5_UNORM_PACK16,
                /*GL_RGB10_A2*/
                0x8059 => VkFormat.A2R10G10B10_UNORM_PACK32,
                /*GL_RGB10_A2UI*/
                0x906F => VkFormat.A2R10G10B10_UINT_PACK32,
                /*GL_R11F_G11F_B10F*/
                0x8C3A => VkFormat.B10G11R11_UFLOAT_PACK32,
                /*GL_RGB9_E5*/
                0x8C3D => VkFormat.E5B9G9R9_UFLOAT_PACK32,
                /*GL_COMPRESSED_RGB_S3TC_DXT1_EXT*/
                0x83F0 => VkFormat.BC1_RGB_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_S3TC_DXT1_EXT*/
                0x83F1 => VkFormat.BC1_RGBA_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_S3TC_DXT3_EXT*/
                0x83F2 => VkFormat.BC2_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_S3TC_DXT5_EXT*/
                0x83F3 => VkFormat.BC3_UNORM_BLOCK,
                /*GL_COMPRESSED_SRGB_S3TC_DXT1_EXT*/
                0x8C4C => VkFormat.BC1_RGB_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT*/
                0x8C4D => VkFormat.BC1_RGBA_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT*/
                0x8C4E => VkFormat.BC2_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT*/
                0x8C4F => VkFormat.BC3_SRGB_BLOCK,
                /*GL_COMPRESSED_LUMINANCE_LATC1_EXT*/
                0x8C70 => VkFormat.BC4_UNORM_BLOCK,
                /*GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT*/
                0x8C72 => VkFormat.BC5_UNORM_BLOCK,
                /*GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT*/
                0x8C71 => VkFormat.BC4_SNORM_BLOCK,
                /*GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT*/
                0x8C73 => VkFormat.BC5_SNORM_BLOCK,
                /*GL_COMPRESSED_RED_RGTC1*/
                0x8DBB => VkFormat.BC4_UNORM_BLOCK,
                /*GL_COMPRESSED_RG_RGTC2*/
                0x8DBD => VkFormat.BC5_UNORM_BLOCK,
                /*GL_COMPRESSED_SIGNED_RED_RGTC1*/
                0x8DBC => VkFormat.BC4_SNORM_BLOCK,
                /*GL_COMPRESSED_SIGNED_RG_RGTC2*/
                0x8DBE => VkFormat.BC5_SNORM_BLOCK,
                /*GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT*/
                0x8E8F => VkFormat.BC6H_UFLOAT_BLOCK,
                /*GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT*/
                0x8E8E => VkFormat.BC6H_SFLOAT_BLOCK,
                /*GL_COMPRESSED_RGBA_BPTC_UNORM*/
                0x8E8C => VkFormat.BC7_UNORM_BLOCK,
                /*GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM*/
                0x8E8D => VkFormat.BC7_SRGB_BLOCK,
                /*GL_ETC1_RGB8_OES*/
                0x8D64 => VkFormat.ETC2_R8G8B8_UNORM_BLOCK,
                /*GL_COMPRESSED_RGB8_ETC2*/
                0x9274 => VkFormat.ETC2_R8G8B8_UNORM_BLOCK,
                /*GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2*/
                0x9276 => VkFormat.ETC2_R8G8B8A1_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA8_ETC2_EAC*/
                0x9278 => VkFormat.ETC2_R8G8B8A8_UNORM_BLOCK,
                /*GL_COMPRESSED_SRGB8_ETC2*/
                0x9275 => VkFormat.ETC2_R8G8B8_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2*/
                0x9277 => VkFormat.ETC2_R8G8B8A1_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC*/
                0x9279 => VkFormat.ETC2_R8G8B8A8_SRGB_BLOCK,
                /*GL_COMPRESSED_R11_EAC*/
                0x9270 => VkFormat.EAC_R11_UNORM_BLOCK,
                /*GL_COMPRESSED_RG11_EAC*/
                0x9272 => VkFormat.EAC_R11G11_UNORM_BLOCK,
                /*GL_COMPRESSED_SIGNED_R11_EAC*/
                0x9271 => VkFormat.EAC_R11_SNORM_BLOCK,
                /*GL_COMPRESSED_SIGNED_RG11_EAC*/
                0x9273 => VkFormat.EAC_R11G11_SNORM_BLOCK,
                /*GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG*/
                0x8C01 => VkFormat.PVRTC1_2BPP_UNORM_BLOCK_IMG,
                /*GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG*/
                0x8C00 => VkFormat.PVRTC1_4BPP_UNORM_BLOCK_IMG,
                /*GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG*/
                0x8C03 => VkFormat.PVRTC1_2BPP_UNORM_BLOCK_IMG,
                /*GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG*/
                0x8C02 => VkFormat.PVRTC1_4BPP_UNORM_BLOCK_IMG,
                /*GL_COMPRESSED_RGBA_PVRTC_2BPPV2_IMG*/
                0x9137 => VkFormat.PVRTC2_2BPP_UNORM_BLOCK_IMG,
                /*GL_COMPRESSED_RGBA_PVRTC_4BPPV2_IMG*/
                0x9138 => VkFormat.PVRTC2_4BPP_UNORM_BLOCK_IMG,
                /*GL_COMPRESSED_SRGB_PVRTC_2BPPV1_EXT*/
                0x8A54 => VkFormat.PVRTC1_2BPP_SRGB_BLOCK_IMG,
                /*GL_COMPRESSED_SRGB_PVRTC_4BPPV1_EXT*/
                0x8A55 => VkFormat.PVRTC1_4BPP_SRGB_BLOCK_IMG,
                /*GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV1_EXT*/
                0x8A56 => VkFormat.PVRTC1_2BPP_SRGB_BLOCK_IMG,
                /*GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV1_EXT*/
                0x8A57 => VkFormat.PVRTC1_4BPP_SRGB_BLOCK_IMG,
                /*GL_COMPRESSED_SRGB_ALPHA_PVRTC_2BPPV2_IMG*/
                0x93F0 => VkFormat.PVRTC2_2BPP_SRGB_BLOCK_IMG,
                /*GL_COMPRESSED_SRGB_ALPHA_PVRTC_4BPPV2_IMG*/
                0x93F1 => VkFormat.PVRTC2_4BPP_SRGB_BLOCK_IMG,
                /*GL_COMPRESSED_RGBA_ASTC_4x4_KHR*/
                0x93B0 => VkFormat.ASTC_4x4_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_5x4_KHR*/
                0x93B1 => VkFormat.ASTC_5x4_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_5x5_KHR*/
                0x93B2 => VkFormat.ASTC_5x5_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_6x5_KHR*/
                0x93B3 => VkFormat.ASTC_6x5_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_6x6_KHR*/
                0x93B4 => VkFormat.ASTC_6x6_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_8x5_KHR*/
                0x93B5 => VkFormat.ASTC_8x5_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_8x6_KHR*/
                0x93B6 => VkFormat.ASTC_8x6_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_8x8_KHR*/
                0x93B7 => VkFormat.ASTC_8x8_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_10x5_KHR*/
                0x93B8 => VkFormat.ASTC_10x5_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_10x6_KHR*/
                0x93B9 => VkFormat.ASTC_10x6_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_10x8_KHR*/
                0x93BA => VkFormat.ASTC_10x8_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_10x10_KHR*/
                0x93BB => VkFormat.ASTC_10x10_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_12x10_KHR*/
                0x93BC => VkFormat.ASTC_12x10_UNORM_BLOCK,
                /*GL_COMPRESSED_RGBA_ASTC_12x12_KHR*/
                0x93BD => VkFormat.ASTC_12x12_UNORM_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR*/
                0x93D0 => VkFormat.ASTC_4x4_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR*/
                0x93D1 => VkFormat.ASTC_5x4_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR*/
                0x93D2 => VkFormat.ASTC_5x5_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR*/
                0x93D3 => VkFormat.ASTC_6x5_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR*/
                0x93D4 => VkFormat.ASTC_6x6_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR*/
                0x93D5 => VkFormat.ASTC_8x5_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR*/
                0x93D6 => VkFormat.ASTC_8x6_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR*/
                0x93D7 => VkFormat.ASTC_8x8_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR*/
                0x93D8 => VkFormat.ASTC_10x5_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR*/
                0x93D9 => VkFormat.ASTC_10x6_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR*/
                0x93DA => VkFormat.ASTC_10x8_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR*/
                0x93DB => VkFormat.ASTC_10x10_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR*/
                0x93DC => VkFormat.ASTC_12x10_SRGB_BLOCK,
                /*GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR*/
                0x93DD => VkFormat.ASTC_12x12_SRGB_BLOCK,
                /*GL_DEPTH_COMPONENT16*/
                0x81A5 => VkFormat.D16_UNORM,
                /*GL_DEPTH_COMPONENT24*/
                0x81A6 => VkFormat.X8_D24_UNORM_PACK32,
                /*GL_DEPTH_COMPONENT32F*/
                0x8CAC => VkFormat.D32_SFLOAT,
                /*GL_DEPTH_COMPONENT32F_NV*/
                0x8DAB => VkFormat.D32_SFLOAT,
                /*GL_STENCIL_INDEX8*/
                0x8D48 => VkFormat.S8_UINT,
                /*GL_DEPTH24_STENCIL8*/
                0x88F0 => VkFormat.D24_UNORM_S8_UINT,
                /*GL_DEPTH32F_STENCIL8*/
                0x8CAD => VkFormat.D32_SFLOAT_S8_UINT,
                /*GL_DEPTH32F_STENCIL8_NV*/
                0x8DAC => VkFormat.D32_SFLOAT_S8_UINT,
                _ => VkFormat.UNDEFINED,
            };
        }

    static VkFormat vkGetFormatFromOpenGLFormat(uint format, uint type)
    {
            switch (type)
            {
                case /*GL_UNSIGNED_BYTE*/ 0x1401:
                    {
                        switch (format)
                        {
                            case /*GL_RED*/ 0x1903: return VkFormat.R8_UNORM;
                            case /*GL_RG*/ 0x8227: return VkFormat.R8G8_UNORM;
                            case /*GL_RGB*/ 0x1907: return VkFormat.R8G8B8_UNORM;
                            case /*GL_BGR*/ 0x80E0: return VkFormat.B8G8R8_UNORM;
                            case /*GL_RGBA*/ 0x1908: return VkFormat.R8G8B8A8_UNORM;
                            case /*GL_BGRA*/ 0x80E1: return VkFormat.B8G8R8A8_UNORM;
                            case /*GL_RED_INTEGER*/ 0x8D94: return VkFormat.R8_UINT;
                            case /*GL_RG_INTEGER*/ 0x8228: return VkFormat.R8G8_UINT;
                            case /*GL_RGB_INTEGER*/ 0x8D98: return VkFormat.R8G8B8_UINT;
                            case /*GL_BGR_INTEGER*/ 0x8D9A: return VkFormat.B8G8R8_UINT;
                            case /*GL_RGBA_INTEGER*/ 0x8D99: return VkFormat.R8G8B8A8_UINT;
                            case /*GL_BGRA_INTEGER*/ 0x8D9B: return VkFormat.B8G8R8A8_UINT;
                            case /*GL_STENCIL_INDEX*/ 0x1901: return VkFormat.S8_UINT;
                            case /*GL_DEPTH_COMPONENT*/ 0x1902: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_STENCIL*/ 0x84F9: return VkFormat.UNDEFINED;
                        }
                        break;
                    }

                case /*GL_BYTE*/ 0x1400:
                    {
                        switch (format)
                        {
                            case /*GL_RED*/ 0x1903: return VkFormat.R8_SNORM;
                            case /*GL_RG*/ 0x8227: return VkFormat.R8G8_SNORM;
                            case /*GL_RGB*/ 0x1907: return VkFormat.R8G8B8_SNORM;
                            case /*GL_BGR*/ 0x80E0: return VkFormat.B8G8R8_SNORM;
                            case /*GL_RGBA*/ 0x1908: return VkFormat.R8G8B8A8_SNORM;
                            case /*GL_BGRA*/ 0x80E1: return VkFormat.B8G8R8A8_SNORM;
                            case /*GL_RED_INTEGER*/ 0x8D94: return VkFormat.R8_SINT;
                            case /*GL_RG_INTEGER*/ 0x8228: return VkFormat.R8G8_SINT;
                            case /*GL_RGB_INTEGER*/ 0x8D98: return VkFormat.R8G8B8_SINT;
                            case /*GL_BGR_INTEGER*/ 0x8D9A: return VkFormat.B8G8R8_SINT;
                            case /*GL_RGBA_INTEGER*/ 0x8D99: return VkFormat.R8G8B8A8_SINT;
                            case /*GL_BGRA_INTEGER*/ 0x8D9B: return VkFormat.B8G8R8A8_SINT;
                            case /*GL_STENCIL_INDEX*/ 0x1901: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_COMPONENT*/ 0x1902: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_STENCIL*/ 0x84F9: return VkFormat.UNDEFINED;
                        }
                        break;
                    }

                case /*GL_UNSIGNED_SHORT*/ 0x1403:
                    {
                        switch (format)
                        {
                            case /*GL_RED*/ 0x1903: return VkFormat.R16_UNORM;
                            case /*GL_RG*/ 0x8227: return VkFormat.R16G16_UNORM;
                            case /*GL_RGB*/ 0x1907: return VkFormat.R16G16B16_UNORM;
                            case /*GL_BGR*/ 0x80E0: return VkFormat.UNDEFINED;
                            case /*GL_RGBA*/ 0x1908: return VkFormat.R16G16B16A16_UNORM;
                            case /*GL_BGRA*/ 0x80E1: return VkFormat.UNDEFINED;
                            case /*GL_RED_INTEGER*/ 0x8D94: return VkFormat.R16_UINT;
                            case /*GL_RG_INTEGER*/ 0x8228: return VkFormat.R16G16_UINT;
                            case /*GL_RGB_INTEGER*/ 0x8D98: return VkFormat.R16G16B16_UINT;
                            case /*GL_BGR_INTEGER*/ 0x8D9A: return VkFormat.UNDEFINED;
                            case /*GL_RGBA_INTEGER*/ 0x8D99: return VkFormat.R16G16B16A16_UINT;
                            case /*GL_BGRA_INTEGER*/ 0x8D9B: return VkFormat.UNDEFINED;
                            case /*GL_STENCIL_INDEX*/ 0x1901: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_COMPONENT*/ 0x1902: return VkFormat.D16_UNORM;
                            case /*GL_DEPTH_STENCIL*/ 0x84F9: return VkFormat.D16_UNORM_S8_UINT;
                        }
                        break;
                    }
                case /*GL_SHORT*/ 0x1402:
                    {
                        switch (format)
                        {
                            case /*GL_RED*/ 0x1903: return VkFormat.R16_SNORM;
                            case /*GL_RG*/ 0x8227: return VkFormat.R16G16_SNORM;
                            case /*GL_RGB*/ 0x1907: return VkFormat.R16G16B16_SNORM;
                            case /*GL_BGR*/ 0x80E0: return VkFormat.UNDEFINED;
                            case /*GL_RGBA*/ 0x1908: return VkFormat.R16G16B16A16_SNORM;
                            case /*GL_BGRA*/ 0x80E1: return VkFormat.UNDEFINED;
                            case /*GL_RED_INTEGER*/ 0x8D94: return VkFormat.R16_SINT;
                            case /*GL_RG_INTEGER*/ 0x8228: return VkFormat.R16G16_SINT;
                            case /*GL_RGB_INTEGER*/ 0x8D98: return VkFormat.R16G16B16_SINT;
                            case /*GL_BGR_INTEGER*/ 0x8D9A: return VkFormat.UNDEFINED;
                            case /*GL_RGBA_INTEGER*/ 0x8D99: return VkFormat.R16G16B16A16_SINT;
                            case /*GL_BGRA_INTEGER*/ 0x8D9B: return VkFormat.UNDEFINED;
                            case /*GL_STENCIL_INDEX*/ 0x1901: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_COMPONENT*/ 0x1902: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_STENCIL*/ 0x84F9: return VkFormat.UNDEFINED;
                        }
                        break;
                    }
                case /*GL_HALF_FLOAT*/ 0x140B:
                case /*GL_HALF_FLOAT_OES*/ 0x8D61:
                    {
                        switch (format)
                        {
                            case /*GL_RED*/ 0x1903: return VkFormat.R16_SFLOAT;
                            case /*GL_RG*/ 0x8227: return VkFormat.R16G16_SFLOAT;
                            case /*GL_RGB*/ 0x1907: return VkFormat.R16G16B16_SFLOAT;
                            case /*GL_BGR*/ 0x80E0: return VkFormat.UNDEFINED;
                            case /*GL_RGBA*/ 0x1908: return VkFormat.R16G16B16A16_SFLOAT;
                            case /*GL_BGRA*/ 0x80E1: return VkFormat.UNDEFINED;
                            case /*GL_RED_INTEGER*/ 0x8D94: return VkFormat.UNDEFINED;
                            case /*GL_RG_INTEGER*/ 0x8228: return VkFormat.UNDEFINED;
                            case /*GL_RGB_INTEGER*/ 0x8D98: return VkFormat.UNDEFINED;
                            case /*GL_BGR_INTEGER*/ 0x8D9A: return VkFormat.UNDEFINED;
                            case /*GL_RGBA_INTEGER*/ 0x8D99: return VkFormat.UNDEFINED;
                            case /*GL_BGRA_INTEGER*/ 0x8D9B: return VkFormat.UNDEFINED;
                            case /*GL_STENCIL_INDEX*/ 0x1901: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_COMPONENT*/ 0x1902: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_STENCIL*/ 0x84F9: return VkFormat.UNDEFINED;
                        }
                        break;
                    }

                case /*GL_UNSIGNED_INT*/ 0x1405:
                    {
                        switch (format)
                        {
                            case /*GL_RED*/ 0x1903: return VkFormat.R32_UINT;
                            case /*GL_RG*/ 0x8227: return VkFormat.R32G32_UINT;
                            case /*GL_RGB*/ 0x1907: return VkFormat.R32G32B32_UINT;
                            case /*GL_BGR*/ 0x80E0: return VkFormat.UNDEFINED;
                            case /*GL_RGBA*/ 0x1908: return VkFormat.R32G32B32A32_UINT;
                            case /*GL_BGRA*/ 0x80E1: return VkFormat.UNDEFINED;
                            case /*GL_RED_INTEGER*/ 0x8D94: return VkFormat.R32_UINT;
                            case /*GL_RG_INTEGER*/ 0x8228: return VkFormat.R32G32_UINT;
                            case /*GL_RGB_INTEGER*/ 0x8D98: return VkFormat.R32G32B32_UINT;
                            case /*GL_BGR_INTEGER*/ 0x8D9A: return VkFormat.UNDEFINED;
                            case /*GL_RGBA_INTEGER*/ 0x8D99: return VkFormat.R32G32B32A32_UINT;
                            case /*GL_BGRA_INTEGER*/ 0x8D9B: return VkFormat.UNDEFINED;
                            case /*GL_STENCIL_INDEX*/ 0x1901: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_COMPONENT*/ 0x1902: return VkFormat.X8_D24_UNORM_PACK32;
                            case /*GL_DEPTH_STENCIL*/ 0x84F9: return VkFormat.D24_UNORM_S8_UINT;
                        }
                        break;
                    }
                case /*GL_INT*/ 0x1404:
                    {
                        switch (format)
                        {
                            case /*GL_RED*/ 0x1903: return VkFormat.R32_SINT;
                            case /*GL_RG*/ 0x8227: return VkFormat.R32G32_SINT;
                            case /*GL_RGB*/ 0x1907: return VkFormat.R32G32B32_SINT;
                            case /*GL_BGR*/ 0x80E0: return VkFormat.UNDEFINED;
                            case /*GL_RGBA*/ 0x1908: return VkFormat.R32G32B32A32_SINT;
                            case /*GL_BGRA*/ 0x80E1: return VkFormat.UNDEFINED;
                            case /*GL_RED_INTEGER*/ 0x8D94: return VkFormat.R32_SINT;
                            case /*GL_RG_INTEGER*/ 0x8228: return VkFormat.R32G32_SINT;
                            case /*GL_RGB_INTEGER*/ 0x8D98: return VkFormat.R32G32B32_SINT;
                            case /*GL_BGR_INTEGER*/ 0x8D9A: return VkFormat.UNDEFINED;
                            case /*GL_RGBA_INTEGER*/ 0x8D99: return VkFormat.R32G32B32A32_SINT;
                            case /*GL_BGRA_INTEGER*/ 0x8D9B: return VkFormat.UNDEFINED;
                            case /*GL_STENCIL_INDEX*/ 0x1901: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_COMPONENT*/ 0x1902: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_STENCIL*/ 0x84F9: return VkFormat.UNDEFINED;
                        }
                        break;
                    }
                case /*GL_FLOAT*/ 0x1406:
                    {
                        switch (format)
                        {
                            case /*GL_RED*/ 0x1903: return VkFormat.R32_SFLOAT;
                            case /*GL_RG*/ 0x8227: return VkFormat.R32G32_SFLOAT;
                            case /*GL_RGB*/ 0x1907: return VkFormat.R32G32B32_SFLOAT;
                            case /*GL_BGR*/ 0x80E0: return VkFormat.UNDEFINED;
                            case /*GL_RGBA*/ 0x1908: return VkFormat.R32G32B32A32_SFLOAT;
                            case /*GL_BGRA*/ 0x80E1: return VkFormat.UNDEFINED;
                            case /*GL_RED_INTEGER*/ 0x8D94: return VkFormat.UNDEFINED;
                            case /*GL_RG_INTEGER*/ 0x8228: return VkFormat.UNDEFINED;
                            case /*GL_RGB_INTEGER*/ 0x8D98: return VkFormat.UNDEFINED;
                            case /*GL_BGR_INTEGER*/ 0x8D9A: return VkFormat.UNDEFINED;
                            case /*GL_RGBA_INTEGER*/ 0x8D99: return VkFormat.UNDEFINED;
                            case /*GL_BGRA_INTEGER*/ 0x8D9B: return VkFormat.UNDEFINED;
                            case /*GL_STENCIL_INDEX*/ 0x1901: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_COMPONENT*/ 0x1902: return VkFormat.D32_SFLOAT;
                            case /*GL_DEPTH_STENCIL*/ 0x84F9: return VkFormat.D32_SFLOAT_S8_UINT;
                        }
                        break;
                    }

                case /*GL_UNSIGNED_INT64*/ 0x140F:
                    {
                        switch (format)
                        {
                            case /*GL_RED*/ 0x1903: return VkFormat.R64_UINT;
                            case /*GL_RG*/ 0x8227: return VkFormat.R64G64_UINT;
                            case /*GL_RGB*/ 0x1907: return VkFormat.R64G64B64_UINT;
                            case /*GL_BGR*/ 0x80E0: return VkFormat.UNDEFINED;
                            case /*GL_RGBA*/ 0x1908: return VkFormat.R64G64B64A64_UINT;
                            case /*GL_BGRA*/ 0x80E1: return VkFormat.UNDEFINED;
                            case /*GL_RED_INTEGER*/ 0x8D94: return VkFormat.UNDEFINED;
                            case /*GL_RG_INTEGER*/ 0x8228: return VkFormat.UNDEFINED;
                            case /*GL_RGB_INTEGER*/ 0x8D98: return VkFormat.UNDEFINED;
                            case /*GL_BGR_INTEGER*/ 0x8D9A: return VkFormat.UNDEFINED;
                            case /*GL_RGBA_INTEGER*/ 0x8D99: return VkFormat.UNDEFINED;
                            case /*GL_BGRA_INTEGER*/ 0x8D9B: return VkFormat.UNDEFINED;
                            case /*GL_STENCIL_INDEX*/ 0x1901: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_COMPONENT*/ 0x1902: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_STENCIL*/ 0x84F9: return VkFormat.UNDEFINED;
                        }
                        break;
                    }
                case /*GL_INT64*/ 0x140E:
                    {
                        switch (format)
                        {
                            case /*GL_RED*/ 0x1903: return VkFormat.R64_SINT;
                            case /*GL_RG*/ 0x8227: return VkFormat.R64G64_SINT;
                            case /*GL_RGB*/ 0x1907: return VkFormat.R64G64B64_SINT;
                            case /*GL_BGR*/ 0x80E0: return VkFormat.UNDEFINED;
                            case /*GL_RGBA*/ 0x1908: return VkFormat.R64G64B64A64_SINT;
                            case /*GL_BGRA*/ 0x80E1: return VkFormat.UNDEFINED;
                            case /*GL_RED_INTEGER*/ 0x8D94: return VkFormat.R64_SINT;
                            case /*GL_RG_INTEGER*/ 0x8228: return VkFormat.R64G64_SINT;
                            case /*GL_RGB_INTEGER*/ 0x8D98: return VkFormat.R64G64B64_SINT;
                            case /*GL_BGR_INTEGER*/ 0x8D9A: return VkFormat.UNDEFINED;
                            case /*GL_RGBA_INTEGER*/ 0x8D99: return VkFormat.R64G64B64A64_SINT;
                            case /*GL_BGRA_INTEGER*/ 0x8D9B: return VkFormat.UNDEFINED;
                            case /*GL_STENCIL_INDEX*/ 0x1901: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_COMPONENT*/ 0x1902: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_STENCIL*/ 0x84F9: return VkFormat.UNDEFINED;
                        }
                        break;
                    }
                case /*GL_DOUBLE*/ 0x140A:
                    {
                        switch (format)
                        {
                            case /*GL_RED*/ 0x1903: return VkFormat.R64_SFLOAT;
                            case /*GL_RG*/ 0x8227: return VkFormat.R64G64_SFLOAT;
                            case /*GL_RGB*/ 0x1907: return VkFormat.R64G64B64_SFLOAT;
                            case /*GL_BGR*/ 0x80E0: return VkFormat.UNDEFINED;
                            case /*GL_RGBA*/ 0x1908: return VkFormat.R64G64B64A64_SFLOAT;
                            case /*GL_BGRA*/ 0x80E1: return VkFormat.UNDEFINED;
                            case /*GL_RED_INTEGER*/ 0x8D94: return VkFormat.R64_SFLOAT;
                            case /*GL_RG_INTEGER*/ 0x8228: return VkFormat.R64G64_SFLOAT;
                            case /*GL_RGB_INTEGER*/ 0x8D98: return VkFormat.R64G64B64_SFLOAT;
                            case /*GL_BGR_INTEGER*/ 0x8D9A: return VkFormat.UNDEFINED;
                            case /*GL_RGBA_INTEGER*/ 0x8D99: return VkFormat.R64G64B64A64_SFLOAT;
                            case /*GL_BGRA_INTEGER*/ 0x8D9B: return VkFormat.UNDEFINED;
                            case /*GL_STENCIL_INDEX*/ 0x1901: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_COMPONENT*/ 0x1902: return VkFormat.UNDEFINED;
                            case /*GL_DEPTH_STENCIL*/ 0x84F9: return VkFormat.UNDEFINED;
                        }
                        break;
                    }

                case /*GL_UNSIGNED_BYTE_3_3_2*/ 0x8032:
                    Debug.Assert(format == /*GL_RGB*/ 0x1907 || format == /*GL_RGB_INTEGER*/ 0x8D98);
                    return VkFormat.UNDEFINED;
                case /*GL_UNSIGNED_BYTE_2_3_3_REV*/ 0x8362:
                    Debug.Assert(format == /*GL_BGR*/ 0x80E0 || format == /*GL_BGR_INTEGER*/ 0x8D9A);
                    return VkFormat.UNDEFINED;
                case /*GL_UNSIGNED_SHORT_5_6_5*/ 0x8363:
                    Debug.Assert(format == /*GL_RGB*/ 0x1907 || format == /*GL_RGB_INTEGER*/ 0x8D98);
                    return VkFormat.R5G6B5_UNORM_PACK16;
                case /*GL_UNSIGNED_SHORT_5_6_5_REV*/ 0x8364:
                    Debug.Assert(format == /*GL_BGR*/ 0x80E0 || format == /*GL_BGR_INTEGER*/ 0x8D9A);
                    return VkFormat.B5G6R5_UNORM_PACK16;
                case /*GL_UNSIGNED_SHORT_4_4_4_4*/ 0x8033:
                    Debug.Assert(format == /*GL_RGB*/ 0x1907 || format == /*GL_BGRA*/ 0x80E1 || format == /*GL_RGB_INTEGER*/ 0x8D98 || format == /*GL_BGRA_INTEGER*/ 0x8D9B);
                    return VkFormat.R4G4B4A4_UNORM_PACK16;
                case /*GL_UNSIGNED_SHORT_4_4_4_4_REV*/ 0x8365:
                    Debug.Assert(format == /*GL_RGB*/ 0x1907 || format == /*GL_BGRA*/ 0x80E1 || format == /*GL_RGB_INTEGER*/ 0x8D98 || format == /*GL_BGRA_INTEGER*/ 0x8D9B);
                    return VkFormat.B4G4R4A4_UNORM_PACK16;
                case /*GL_UNSIGNED_SHORT_5_5_5_1*/ 0x8034:
                    Debug.Assert(format == /*GL_RGB*/ 0x1907 || format == /*GL_BGRA*/ 0x80E1 || format == /*GL_RGB_INTEGER*/ 0x8D98 || format == /*GL_BGRA_INTEGER*/ 0x8D9B);
                    return VkFormat.R5G5B5A1_UNORM_PACK16;
                case /*GL_UNSIGNED_SHORT_1_5_5_5_REV*/ 0x8366:
                    Debug.Assert(format == /*GL_RGB*/ 0x1907 || format == /*GL_BGRA*/ 0x80E1 || format == /*GL_RGB_INTEGER*/ 0x8D98 || format == /*GL_BGRA_INTEGER*/ 0x8D9B);
                    return VkFormat.A1R5G5B5_UNORM_PACK16;
                case /*GL_UNSIGNED_INT_8_8_8_8*/ 0x8035:
                    Debug.Assert(format == /*GL_RGB*/ 0x1907 || format == /*GL_BGRA*/ 0x80E1 || format == /*GL_RGB_INTEGER*/ 0x8D98 || format == /*GL_BGRA_INTEGER*/ 0x8D9B);
                    return (format == /*GL_RGB_INTEGER*/ 0x8D98 || format == /*GL_BGRA_INTEGER*/ 0x8D9B) ? VkFormat.R8G8B8A8_UINT : VkFormat.R8G8B8A8_UNORM;
                case /*GL_UNSIGNED_INT_8_8_8_8_REV*/ 0x8367:
                    Debug.Assert(format == /*GL_RGB*/ 0x1907 || format == /*GL_BGRA*/ 0x80E1 || format == /*GL_RGB_INTEGER*/ 0x8D98 || format == /*GL_BGRA_INTEGER*/ 0x8D9B);
                    return (format == /*GL_RGB_INTEGER*/ 0x8D98 || format == /*GL_BGRA_INTEGER*/ 0x8D9B) ? VkFormat.A8B8G8R8_UINT_PACK32 : VkFormat.A8B8G8R8_UNORM_PACK32;
                case /*GL_UNSIGNED_INT_10_10_10_2*/ 0x8036:
                    Debug.Assert(format == /*GL_RGB*/ 0x1907 || format == /*GL_BGRA*/ 0x80E1 || format == /*GL_RGB_INTEGER*/ 0x8D98 || format == /*GL_BGRA_INTEGER*/ 0x8D9B);
                    return (format == /*GL_RGB_INTEGER*/ 0x8D98 || format == /*GL_BGRA_INTEGER*/ 0x8D9B) ? VkFormat.A2R10G10B10_UINT_PACK32 : VkFormat.A2R10G10B10_UNORM_PACK32;
                case /*GL_UNSIGNED_INT_2_10_10_10_REV*/ 0x8368:
                    Debug.Assert(format == /*GL_RGB*/ 0x1907 || format == /*GL_BGRA*/ 0x80E1 || format == /*GL_RGB_INTEGER*/ 0x8D98 || format == /*GL_BGRA_INTEGER*/ 0x8D9B);
                    return (format == /*GL_RGB_INTEGER*/ 0x8D98 || format == /*GL_BGRA_INTEGER*/ 0x8D9B) ? VkFormat.A2B10G10R10_UINT_PACK32 : VkFormat.A2B10G10R10_UNORM_PACK32;
                case /*GL_UNSIGNED_INT_10F_11F_11F_REV*/ 0x8C3B:
                    Debug.Assert(format == /*GL_RGB*/ 0x1907 || format == /*GL_BGR*/ 0x80E0);
                    return VkFormat.B10G11R11_UFLOAT_PACK32;
                case /*GL_UNSIGNED_INT_5_9_9_9_REV*/ 0x8C3E:
                    Debug.Assert(format == /*GL_RGB*/ 0x1907 || format == /*GL_BGR*/ 0x80E0);
                    return VkFormat.E5B9G9R9_UFLOAT_PACK32;
                case /*GL_UNSIGNED_INT_24_8*/ 0x84FA:
                    Debug.Assert(format == /*GL_DEPTH_STENCIL*/ 0x84F9);
                    return VkFormat.D24_UNORM_S8_UINT;
                case /*GL_FLOAT_32_UNSIGNED_INT_24_8_REV*/ 0x8DAD:
                    Debug.Assert(format == /*GL_DEPTH_STENCIL*/ 0x84F9);
                    return VkFormat.D32_SFLOAT_S8_UINT;
            }

            return VkFormat.UNDEFINED;
        }
    }
}
