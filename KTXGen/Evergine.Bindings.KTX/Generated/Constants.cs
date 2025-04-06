using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.MeshOptimizer
{
	public static partial class MeshOptNative
	{
		public const uint KHR_DFDVAL = (((BDB)[KHR_DF_WORD_##X]>>(KHR_DF_SHIFT_##X))&(KHR_DF_MASK_##X));
		public const uint KHR_DFDSETVAL = ((BDB)[KHR_DF_WORD_##X]=((BDB)[KHR_DF_WORD_##X]&~((KHR_DF_MASK_##X)<<(KHR_DF_SHIFT_##X)))|(((uint32_t)(val)&(KHR_DF_MASK_##X))<<(KHR_DF_SHIFT_##X)));
		public const uint KHR_DFDSVAL = (((BDB)[KHR_DF_WORD_SAMPLESTART+((S)*KHR_DF_WORD_SAMPLEWORDS)+KHR_DF_SAMPLEWORD_##X]>>(KHR_DF_SAMPLESHIFT_##X))&(KHR_DF_SAMPLEMASK_##X));
		public const uint KHR_DFDSETSVAL = ((BDB)[KHR_DF_WORD_SAMPLESTART+((S)*KHR_DF_WORD_SAMPLEWORDS)+KHR_DF_SAMPLEWORD_##X]=((BDB)[KHR_DF_WORD_SAMPLESTART+((S)*KHR_DF_WORD_SAMPLEWORDS)+KHR_DF_SAMPLEWORD_##X]&~((uint32_t)(KHR_DF_SAMPLEMASK_##X)<<(KHR_DF_SAMPLESHIFT_##X)))|(((uint32_t)(val)&(uint32_t)(KHR_DF_SAMPLEMASK_##X))<<(KHR_DF_SAMPLESHIFT_##X)));
		public const uint KHR_DFDSAMPLECOUNT = (((KHR_DFDVAL(BDB,DESCRIPTORBLOCKSIZE)>>2)-KHR_DF_WORD_SAMPLESTART)/KHR_DF_WORD_SAMPLEWORDS);
		public const uint KHR_DFDSIZEWORDS = (KHR_DF_WORD_SAMPLESTART+(S)*KHR_DF_WORD_SAMPLEWORDS);
		public const uint KTX_API = __declspec(dllimport);
		public const uint KTX_APIENTRY = __stdcall;
		public const uint KTX_ANIMDATA_KEY = "KTXanimData";
		public const uint KTX_ORIENTATION_KEY = "KTXorientation";
		public const uint KTX_SWIZZLE_KEY = "KTXswizzle";
		public const uint KTX_WRITER_KEY = "KTXwriter";
		public const uint KTX_WRITER_SCPARAMS_KEY = "KTXwriterScParams";
		public const uint KTX_ORIENTATION1_FMT = "S=%c";
		public const uint KTX_ORIENTATION2_FMT = "S=%c,T=%c";
		public const uint KTX_ORIENTATION3_FMT = "S=%c,T=%c,R=%c";
		public const uint KTX_GL_UNPACK_ALIGNMENT = 4;
		public const uint KTX_FACESLICE_WHOLE_LEVEL = UINT_MAX;
		public const uint KTX_TRUE = true;
		public const uint KTX_FALSE = false;
		public const uint KTX_error_code = ktx_error_code_e;
		public const uint KTX_IDENTIFIER_REF = {0xAB,0x4B,0x54,0x58,0x20,0x31,0x31,0xBB,0x0D,0x0A,0x1A,0x0A};
		public const uint KTX_ENDIAN_REF = (0x04030201);
		public const uint KTX_ENDIAN_REF_REV = (0x01020304);
		public const uint KTX_HEADER_SIZE = (64);
		public const uint KTX_APIENTRYP = KTX_APIENTRY*;
		public const uint KTXTEXTURECLASSDEFN = class_id classId;struct ktxTexture_vtbl*vtbl;struct ktxTexture_vvtbl*vvtbl;struct ktxTexture_protected*_protected;ktx_bool_t isArray;ktx_bool_t isCubemap;ktx_bool_t isCompressed;ktx_bool_t generateMipmaps;ktx_uint32_t baseWidth;ktx_uint32_t baseHeight;ktx_uint32_t baseDepth;ktx_uint32_t numDimensions;ktx_uint32_t numLevels;ktx_uint32_t numLayers;ktx_uint32_t numFaces;struct ktxOrientation orientation;ktxHashList kvDataHead;ktx_uint32_t kvDataLen;ktx_uint8_t*kvData;ktx_size_t dataSize;ktx_uint8_t*pData;;
		public const uint ktxTexture_Destroy = (This)->vtbl->Destroy(This);
		public const uint ktxTexture_GetImageOffset = (This)->vtbl->GetImageOffset(This,level,layer,faceSlice,pOffset);
		public const uint ktxTexture_GetDataSizeUncompressed = (This)->vtbl->GetDataSizeUncompressed(This);
		public const uint ktxTexture_GetImageSize = (This)->vtbl->GetImageSize(This,level);
		public const uint ktxTexture_GetLevelSize = (This)->vtbl->GetLevelSize(This,level);
		public const uint ktxTexture_IterateLevels = (This)->vtbl->IterateLevels(This,iterCb,userdata);
		public const uint ktxTexture_IterateLoadLevelFaces = (This)->vtbl->IterateLoadLevelFaces(This,iterCb,userdata);
		public const uint ktxTexture_LoadImageData = (This)->vtbl->LoadImageData(This,pBuffer,bufSize);
		public const uint ktxTexture_NeedsTranscoding = (This)->vtbl->NeedsTranscoding(This);
		public const uint ktxTexture_SetImageFromMemory = (This)->vtbl->SetImageFromMemory(This,level,layer,faceSlice,src,srcSize);
		public const uint ktxTexture_SetImageFromStdioStream = (This)->vtbl->SetImageFromStdioStream(This,level,layer,faceSlice,src,srcSize);
		public const uint ktxTexture_WriteToStdioStream = (This)->vtbl->WriteToStdioStream(This,dstsstr);
		public const uint ktxTexture_WriteToNamedFile = (This)->vtbl->WriteToNamedFile(This,dstname);
		public const uint ktxTexture_WriteToMemory = (This)->vtbl->WriteToMemory(This,ppDstBytes,pSize);
		public const uint ktxTexture_WriteToStream = (This)->vtbl->WriteToStream(This,dststr);
		public const uint ktxTexture = ((ktxTexture*)t);
	}
}
