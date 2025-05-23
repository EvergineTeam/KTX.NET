using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.KTX
{
	/// <summary>
	/// 
	/// @
	/// ~English
	/// 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct ktxOrientation
	{

		/// <summary>
		/// Orientation in X 
		/// </summary>
		public ktxOrientationX x;

		/// <summary>
		/// Orientation in Y 
		/// </summary>
		public ktxOrientationY y;

		/// <summary>
		/// Orientation in Z 
		/// </summary>
		public ktxOrientationZ z;
	}

	/// <summary>
	/// 
	/// 
	/// @
	/// ~English
	/// 
	/// ktxTextures should be created only by one of the provided
	/// functions and these fields should be considered read-only.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct ktxTexture
	{
		public class_id classId;
		public IntPtr vtbl;
		public IntPtr vvtbl;
		public IntPtr _protected;
		public byte isArray;
		public byte isCubemap;
		public byte isCompressed;
		public byte generateMipmaps;
		public UInt32 baseWidth;
		public UInt32 baseHeight;
		public UInt32 baseDepth;
		public UInt32 numDimensions;
		public UInt32 numLevels;
		public UInt32 numLayers;
		public UInt32 numFaces;
		public ktxOrientation orientation;
		public ktxHashList kvDataHead;
		public UInt32 kvDataLen;
		public byte* kvData;
		public UIntPtr dataSize;
		public byte* pData;
	}

	/// <summary>
	/// 
	/// 
	/// @
	/// ~English
	/// 
	/// ktxTextures should be created only by one of the ktxTexture_Create*
	/// functions and these fields should be considered read-only.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct ktxTexture1
	{
		public class_id classId;
		public IntPtr vtbl;
		public IntPtr vvtbl;
		public IntPtr _protected;
		public byte isArray;
		public byte isCubemap;
		public byte isCompressed;
		public byte generateMipmaps;
		public UInt32 baseWidth;
		public UInt32 baseHeight;
		public UInt32 baseDepth;
		public UInt32 numDimensions;
		public UInt32 numLevels;
		public UInt32 numLayers;
		public UInt32 numFaces;
		public ktxOrientation orientation;
		public ktxHashList kvDataHead;
		public UInt32 kvDataLen;
		public byte* kvData;
		public UIntPtr dataSize;
		public byte* pData;

		/// <summary>
		/// Format of the texture data, e.g., GL_RGB. 
		/// </summary>
		public UInt32 glFormat;

		/// <summary>
		/// Internal format of the texture data,
		/// e.g., GL_RGB8. 
		/// </summary>
		public UInt32 glInternalformat;

		/// <summary>
		/// Base format of the texture data,
		/// e.g., GL_RGB. 
		/// </summary>
		public UInt32 glBaseInternalformat;

		/// <summary>
		/// Type of the texture data, e.g, GL_UNSIGNED_BYTE.
		/// </summary>
		public UInt32 glType;

		/// <summary>
		/// Private data. 
		/// </summary>
		public IntPtr _private;
	}

	/// <summary>
	/// 
	/// 
	/// @
	/// ~English
	/// 
	/// ktxTextures should be created only by one of the ktxTexture_Create*
	/// functions and these fields should be considered read-only.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct ktxTexture2
	{
		public class_id classId;
		public IntPtr vtbl;
		public IntPtr vvtbl;
		public IntPtr _protected;
		public byte isArray;
		public byte isCubemap;
		public byte isCompressed;
		public byte generateMipmaps;
		public UInt32 baseWidth;
		public UInt32 baseHeight;
		public UInt32 baseDepth;
		public UInt32 numDimensions;
		public UInt32 numLevels;
		public UInt32 numLayers;
		public UInt32 numFaces;
		public ktxOrientation orientation;
		public ktxHashList kvDataHead;
		public UInt32 kvDataLen;
		public byte* kvData;
		public UIntPtr dataSize;
		public byte* pData;
		public UInt32 vkFormat;
		public UInt32* pDfd;
		public ktxSupercmpScheme supercompressionScheme;
		public byte isVideo;
		public UInt32 duration;
		public UInt32 timescale;
		public UInt32 loopcount;

		/// <summary>
		/// Private data. 
		/// </summary>
		public IntPtr _private;
	}

	/// <summary>
	/// 
	/// 
	/// @
	/// ~English
	/// 
	/// 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct ktxTextureCreateInfo
	{

		/// <summary>
		/// Internal format for the texture, e.g.,
		/// GL_RGB8. Ignored when creating a
		/// ktxTexture2. 
		/// </summary>
		public UInt32 glInternalformat;

		/// <summary>
		/// VkFormat for texture. Ignored when creating a
		/// ktxTexture1. 
		/// </summary>
		public UInt32 vkFormat;

		/// <summary>
		/// Pointer to DFD. Used only when creating a
		/// ktxTexture2 and only if vkFormat is
		/// VK_FORMAT_UNDEFINED. 
		/// </summary>
		public UInt32* pDfd;

		/// <summary>
		/// Width of the base level of the texture. 
		/// </summary>
		public UInt32 baseWidth;

		/// <summary>
		/// Height of the base level of the texture. 
		/// </summary>
		public UInt32 baseHeight;

		/// <summary>
		/// Depth of the base level of the texture. 
		/// </summary>
		public UInt32 baseDepth;

		/// <summary>
		/// Number of dimensions in the texture, 1, 2
		/// or 3. 
		/// </summary>
		public UInt32 numDimensions;

		/// <summary>
		/// Number of mip levels in the texture. Should be
		/// 1 if 
		/// is KTX_TRUE; 
		/// </summary>
		public UInt32 numLevels;

		/// <summary>
		/// Number of array layers in the texture. 
		/// </summary>
		public UInt32 numLayers;

		/// <summary>
		/// Number of faces: 6 for cube maps, 1 otherwise. 
		/// </summary>
		public UInt32 numFaces;

		/// <summary>
		/// Set to KTX_TRUE if the texture is to be an
		/// array texture. Means OpenGL will use a
		/// GL_TEXTURE_*_ARRAY target. 
		/// </summary>
		public byte isArray;

		/// <summary>
		/// Set to KTX_TRUE if mipmaps should be
		/// generated for the texture when loading
		/// into a 3D API. 
		/// </summary>
		public byte generateMipmaps;
	}

	/// <summary>
	/// 
	/// 
	/// @
	/// ~English
	/// 
	/// Passing a struct initialized to 0 (e.g. " = {0};") will use blockDimension
	/// 4x4, mode LDR and qualityLevel FASTEST. Setting qualityLevel to
	/// KTX_PACK_ASTC_QUALITY_LEVEL_MEDIUM is recommended.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct ktxAstcParams
	{
		public UInt32 structSize;
		public byte verbose;
		public UInt32 threadCount;

		/// <summary>
		/// astcenc params 
		/// </summary>
		public UInt32 blockDimension;
		public UInt32 mode;
		public UInt32 qualityLevel;
		public byte normalMap;
		public byte perceptual;
		public fixed byte inputSwizzle[4];
	}

	/// <summary>
	/// 
	/// 
	/// @
	/// ~English
	/// 
	/// If you only want default values, use ktxTexture2_CompressBasis(). Here, at
	/// a minimum you must initialize the structure as follows:
	/// 
	/// 
	/// has to be explicitly set because 0 is a valid
	/// 
	/// but is not the default used by the BasisU encoder
	/// when no value is set. Only the other settings that are to be non-default
	/// must be non-zero.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct ktxBasisParams
	{
		public UInt32 structSize;
		public byte uastc;
		public byte verbose;
		public byte noSSE;
		public UInt32 threadCount;

		/// <summary>
		/// ETC1S params 
		/// </summary>
		public UInt32 compressionLevel;
		public UInt32 qualityLevel;
		public UInt32 maxEndpoints;
		public float endpointRDOThreshold;
		public UInt32 maxSelectors;
		public float selectorRDOThreshold;
		public fixed byte inputSwizzle[4];
		public byte normalMap;
		public byte separateRGToRGB_A;
		public byte preSwizzle;
		public byte noEndpointRDO;
		public byte noSelectorRDO;

		/// <summary>
		/// UASTC params 
		/// </summary>
		public UInt32 uastcFlags;
		public byte uastcRDO;
		public float uastcRDOQualityScalar;
		public UInt32 uastcRDODictSize;
		public float uastcRDOMaxSmoothBlockErrorScale;
		public float uastcRDOMaxSmoothBlockStdDev;
		public byte uastcRDODontFavorSimplerModes;
		public byte uastcRDONoMultithreading;
	}

}

