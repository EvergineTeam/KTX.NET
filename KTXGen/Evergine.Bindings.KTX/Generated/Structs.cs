using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.MeshOptimizer
{
	/// <summary>
	/// 
	/// @
	/// ~English
	/// 
	/// 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct ktxStream
	{

		/// <summary>
		/// pointer to function for reading bytes. 
		/// </summary>
		public  read;

		/// <summary>
		/// pointer to function for skipping bytes. 
		/// </summary>
		public  skip;

		/// <summary>
		/// pointer to function for writing bytes. 
		/// </summary>
		public  write;

		/// <summary>
		/// pointer to function for getting current position in stream. 
		/// </summary>
		public  getpos;

		/// <summary>
		/// pointer to function for setting current position in stream. 
		/// </summary>
		public  setpos;

		/// <summary>
		/// pointer to function for querying size. 
		/// </summary>
		public  getsize;

		/// <summary>
		/// destruct the stream. 
		/// </summary>
		public  destruct;
		public streamType type;

		/// <summary>
		/// pointer to the stream data. 
		/// </summary>
		public  data;

		/// <summary>
		/// used by FileStream for stdin. 
		/// </summary>
		public ulong readpos;

		/// <summary>
		/// Close FILE* or dispose of memory on destruct. 
		/// </summary>
		public  closeOnDestruct;
	}

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
		public ktxTexture_vtbl* vtbl;
		public ktxTexture_vvtbl* vvtbl;
		public ktxTexture_protected* _protected;
		public  isArray;
		public  isCubemap;
		public  isCompressed;
		public  generateMipmaps;
		public  baseWidth;
		public  baseHeight;
		public  baseDepth;
		public  numDimensions;
		public  numLevels;
		public  numLayers;
		public  numFaces;
		public ktxOrientation orientation;
		public  kvDataHead;
		public  kvDataLen;
		public * kvData;
		public  dataSize;
		public * pData;
	}

	/// <summary>
	/// 
	/// 
	/// @
	/// ~English
	/// 
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct ktxTexture_vtbl
	{
		public  Destroy;
		public  GetImageOffset;
		public  GetDataSizeUncompressed;
		public  GetImageSize;
		public  GetLevelSize;
		public  IterateLevels;
		public  IterateLoadLevelFaces;
		public  NeedsTranscoding;
		public  LoadImageData;
		public  SetImageFromMemory;
		public  SetImageFromStdioStream;
		public  WriteToStdioStream;
		public  WriteToNamedFile;
		public  WriteToMemory;
		public  WriteToStream;
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
		public ktxTexture_vtbl* vtbl;
		public ktxTexture_vvtbl* vvtbl;
		public ktxTexture_protected* _protected;
		public  isArray;
		public  isCubemap;
		public  isCompressed;
		public  generateMipmaps;
		public  baseWidth;
		public  baseHeight;
		public  baseDepth;
		public  numDimensions;
		public  numLevels;
		public  numLayers;
		public  numFaces;
		public ktxOrientation orientation;
		public  kvDataHead;
		public  kvDataLen;
		public * kvData;
		public  dataSize;
		public * pData;

		/// <summary>
		/// Format of the texture data, e.g., GL_RGB. 
		/// </summary>
		public  glFormat;

		/// <summary>
		/// Internal format of the texture data,
		/// e.g., GL_RGB8. 
		/// </summary>
		public  glInternalformat;

		/// <summary>
		/// Base format of the texture data,
		/// e.g., GL_RGB. 
		/// </summary>
		public  glBaseInternalformat;

		/// <summary>
		/// Type of the texture data, e.g, GL_UNSIGNED_BYTE.
		/// </summary>
		public  glType;

		/// <summary>
		/// Private data. 
		/// </summary>
		public ktxTexture1_private* _private;
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
		public ktxTexture_vtbl* vtbl;
		public ktxTexture_vvtbl* vvtbl;
		public ktxTexture_protected* _protected;
		public  isArray;
		public  isCubemap;
		public  isCompressed;
		public  generateMipmaps;
		public  baseWidth;
		public  baseHeight;
		public  baseDepth;
		public  numDimensions;
		public  numLevels;
		public  numLayers;
		public  numFaces;
		public ktxOrientation orientation;
		public  kvDataHead;
		public  kvDataLen;
		public * kvData;
		public  dataSize;
		public * pData;
		public  vkFormat;
		public * pDfd;
		public ktxSupercmpScheme supercompressionScheme;
		public  isVideo;
		public  duration;
		public  timescale;
		public  loopcount;

		/// <summary>
		/// Private data. 
		/// </summary>
		public ktxTexture2_private* _private;
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
		public  glInternalformat;

		/// <summary>
		/// VkFormat for texture. Ignored when creating a
		/// ktxTexture1. 
		/// </summary>
		public  vkFormat;

		/// <summary>
		/// Pointer to DFD. Used only when creating a
		/// ktxTexture2 and only if vkFormat is
		/// VK_FORMAT_UNDEFINED. 
		/// </summary>
		public * pDfd;

		/// <summary>
		/// Width of the base level of the texture. 
		/// </summary>
		public  baseWidth;

		/// <summary>
		/// Height of the base level of the texture. 
		/// </summary>
		public  baseHeight;

		/// <summary>
		/// Depth of the base level of the texture. 
		/// </summary>
		public  baseDepth;

		/// <summary>
		/// Number of dimensions in the texture, 1, 2
		/// or 3. 
		/// </summary>
		public  numDimensions;

		/// <summary>
		/// Number of mip levels in the texture. Should be
		/// 1 if 
		/// is KTX_TRUE; 
		/// </summary>
		public  numLevels;

		/// <summary>
		/// Number of array layers in the texture. 
		/// </summary>
		public  numLayers;

		/// <summary>
		/// Number of faces: 6 for cube maps, 1 otherwise. 
		/// </summary>
		public  numFaces;

		/// <summary>
		/// Set to KTX_TRUE if the texture is to be an
		/// array texture. Means OpenGL will use a
		/// GL_TEXTURE_*_ARRAY target. 
		/// </summary>
		public  isArray;

		/// <summary>
		/// Set to KTX_TRUE if mipmaps should be
		/// generated for the texture when loading
		/// into a 3D API. 
		/// </summary>
		public  generateMipmaps;
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
		public  structSize;
		public  verbose;
		public  threadCount;

		/// <summary>
		/// astcenc params 
		/// </summary>
		public  blockDimension;
		public  mode;
		public  qualityLevel;
		public  normalMap;
		public  perceptual;
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
		public  structSize;
		public  uastc;
		public  verbose;
		public  noSSE;
		public  threadCount;

		/// <summary>
		/// ETC1S params 
		/// </summary>
		public  compressionLevel;
		public  qualityLevel;
		public  maxEndpoints;
		public float endpointRDOThreshold;
		public  maxSelectors;
		public float selectorRDOThreshold;
		public fixed byte inputSwizzle[4];
		public  normalMap;
		public  separateRGToRGB_A;
		public  preSwizzle;
		public  noEndpointRDO;
		public  noSelectorRDO;

		/// <summary>
		/// UASTC params 
		/// </summary>
		public  uastcFlags;
		public  uastcRDO;
		public float uastcRDOQualityScalar;
		public  uastcRDODictSize;
		public float uastcRDOMaxSmoothBlockErrorScale;
		public float uastcRDOMaxSmoothBlockStdDev;
		public  uastcRDODontFavorSimplerModes;
		public  uastcRDONoMultithreading;
	}

}

