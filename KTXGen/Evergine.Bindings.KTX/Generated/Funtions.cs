using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.MeshOptimizer
{
	public static unsafe partial class MeshOptNative
	{
		/// <summary>
		/// Load pointers for the OpenGL functions needed by ktxTexture_GLUpload.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxLoadOpenGL( pfnGLGetProcAddress);

		/// <summary>
		/// These four create a ktxTexture1 or ktxTexture2 according to the data
		/// header, and return a pointer to the base ktxTexture class.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture_CreateFromStdioStream(* stdioStream,  createFlags, ktxTexture* newTex);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture_CreateFromNamedFile(byte* filename,  createFlags, ktxTexture* newTex);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture_CreateFromMemory(* bytes,  size,  createFlags, ktxTexture* newTex);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture_CreateFromStream(ktxStream* stream,  createFlags, ktxTexture* newTex);

		/// <summary>
		/// Returns a pointer to the image data of a ktxTexture object.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern * ktxTexture_GetData(ktxTexture* This);

		/// <summary>
		/// Returns the pitch of a row of an image at the specified level.
		/// Similar to the rowPitch in a VkSubResourceLayout.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern  ktxTexture_GetRowPitch(ktxTexture* This,  level);

		/// <summary>
		/// Return the element size of the texture's images.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern  ktxTexture_GetElementSize(ktxTexture* This);

		/// <summary>
		/// Returns the size of all the image data of a ktxTexture object in bytes.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern  ktxTexture_GetDataSize(ktxTexture* This);

		/// <summary>
		/// Uploads a texture to OpenGL {,ES}. 
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture_GLUpload(ktxTexture* This, * pTexture, * pTarget, * pGlerror);

		/// <summary>
		/// Iterate over the levels or faces in a ktxTexture object.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture_IterateLevelFaces(ktxTexture* This,  iterCb, void* userdata);

		/// <summary>
		/// Create a new ktxTexture1.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_Create(ktxTextureCreateInfo* createInfo, ktxTextureCreateStorageEnum storageAllocation, ktxTexture1* newTex);

		/// <summary>
		/// These four create a ktxTexture1 provided the data is in KTX format.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_CreateFromStdioStream(* stdioStream,  createFlags, ktxTexture1* newTex);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_CreateFromNamedFile(byte* filename,  createFlags, ktxTexture1* newTex);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_CreateFromMemory(* bytes,  size,  createFlags, ktxTexture1* newTex);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_CreateFromStream(ktxStream* stream,  createFlags, ktxTexture1* newTex);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxTexture1_Destroy(ktxTexture1* This);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern  ktxTexture1_NeedsTranscoding(ktxTexture1* This);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_LoadImageData(ktxTexture1* This, * pBuffer,  bufSize);

		/// <summary>
		/// These four write a ktxTexture1 object to a KTX v1 file.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_WriteToStdioStream(ktxTexture1* This, * dstsstr);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_WriteToNamedFile(ktxTexture1* This, byte* dstname);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_WriteToMemory(ktxTexture1* This, * bytes, * size);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_WriteToStream(ktxTexture1* This, ktxStream* dststr);

		/// <summary>
		/// These four write a ktxTexture1 object to a KTX v2 file.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_WriteKTX2ToStdioStream(ktxTexture1* This, * dstsstr);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_WriteKTX2ToNamedFile(ktxTexture1* This, byte* dstname);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_WriteKTX2ToMemory(ktxTexture1* This, * bytes, * size);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_WriteKTX2ToStream(ktxTexture1* This, ktxStream* dststr);

		/// <summary>
		/// Create a new ktxTexture2.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_Create(ktxTextureCreateInfo* createInfo, ktxTextureCreateStorageEnum storageAllocation, ktxTexture2* newTex);

		/// <summary>
		/// Create a new ktxTexture2 as a copy of an existing texture.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CreateCopy(ktxTexture2* orig, ktxTexture2* newTex);

		/// <summary>
		/// These four create a ktxTexture2 provided the data is in KTX2 format.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CreateFromStdioStream(* stdioStream,  createFlags, ktxTexture2* newTex);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CreateFromNamedFile(byte* filename,  createFlags, ktxTexture2* newTex);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CreateFromMemory(* bytes,  size,  createFlags, ktxTexture2* newTex);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CreateFromStream(ktxStream* stream,  createFlags, ktxTexture2* newTex);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxTexture2_Destroy(ktxTexture2* This);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CompressBasis(ktxTexture2* This,  quality);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_DeflateZstd(ktxTexture2* This,  level);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_DeflateZLIB(ktxTexture2* This,  level);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxTexture2_GetComponentInfo(ktxTexture2* This, * numComponents, * componentByteLength);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_GetImageOffset(ktxTexture2* This,  level,  layer,  faceSlice, * pOffset);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern  ktxTexture2_GetNumComponents(ktxTexture2* This);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern  ktxTexture2_GetTransferFunction_e(ktxTexture2* This);

		/// <summary>
		/// For backward compatibility. 
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern  ktxTexture2_GetOETF_e(ktxTexture2* This);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern  ktxTexture2_GetOETF(ktxTexture2* This);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern  ktxTexture2_GetColorModel_e(ktxTexture2* This);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern  ktxTexture2_GetPremultipliedAlpha(ktxTexture2* This);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern  ktxTexture2_GetPrimaries_e(ktxTexture2* This);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern  ktxTexture2_NeedsTranscoding(ktxTexture2* This);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_SetTransferFunction(ktxTexture2* This,  tf);

		/// <summary>
		/// For backward compatibility. 
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_SetOETF(ktxTexture2* This,  oetf);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_SetPrimaries(ktxTexture2* This,  primaries);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_LoadImageData(ktxTexture2* This, * pBuffer,  bufSize);

		/// <summary>
		/// For rare testing scenarios. Use ktxTexture2_LoadImageData.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_LoadDeflatedImageData(ktxTexture2* This, * pBuffer,  bufSize);

		/// <summary>
		/// These four write a ktxTexture2 object to a KTX v2 file.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_WriteToStdioStream(ktxTexture2* This, * dstsstr);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_WriteToNamedFile(ktxTexture2* This, byte* dstname);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_WriteToMemory(ktxTexture2* This, * bytes, * size);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_WriteToStream(ktxTexture2* This, ktxStream* dststr);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CompressAstcEx(ktxTexture2* This, ktxAstcParams* params);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CompressAstc(ktxTexture2* This,  quality);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_DecodeAstc(ktxTexture2* This);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CompressBasisEx(ktxTexture2* This, ktxBasisParams* params);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_TranscodeBasis(ktxTexture2* This, ktx_transcode_fmt_e fmt,  transcodeFlags);

		/// <summary>
		/// Returns a string corresponding to a KTX error code.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ktxErrorString(ktx_error_code_e error);

		/// <summary>
		/// Returns a string corresponding to a supercompression scheme.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ktxSupercompressionSchemeString(ktxSupercmpScheme scheme);

		/// <summary>
		/// Returns a string corresponding to a transcode target format.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ktxTranscodeFormatString(ktx_transcode_fmt_e format);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_Create(* ppHl);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_CreateCopy(* ppHl,  orig);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxHashList_Construct(* pHl);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxHashList_ConstructCopy(* pHl,  orig);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxHashList_Destroy(* head);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxHashList_Destruct(* head);

		/// <summary>
		/// Adds a key-value pair to a hash list.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_AddKVPair(* pHead, byte* key, uint valueLen, void* value);

		/// <summary>
		/// Deletes a ktxHashListEntry from a ktxHashList.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_DeleteEntry(* pHead, * pEntry);

		/// <summary>
		/// Finds the entry for a key in a ktxHashList and deletes it.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_DeleteKVPair(* pHead, byte* key);

		/// <summary>
		/// Looks up a key and returns the ktxHashListEntry.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_FindEntry(* pHead, byte* key, * ppEntry);

		/// <summary>
		/// Looks up a key and returns the value.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_FindValue(* pHead, byte* key, uint* pValueLen, void* pValue);

		/// <summary>
		/// Return the next entry in a ktxHashList.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern * ktxHashList_Next(* entry);

		/// <summary>
		/// Sorts a ktxHashList into order of the key codepoints.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_Sort(* pHead);

		/// <summary>
		/// Serializes a ktxHashList to a block of memory suitable for
		/// writing to a KTX file.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_Serialize(* pHead, uint* kvdLen, byte* kvd);

		/// <summary>
		/// Creates a hash table from the serialized data read from a
		/// a KTX file.
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_Deserialize(* pHead, uint kvdLen, void* kvd);

		/// <summary>
		/// Get the key from a ktxHashListEntry
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashListEntry_GetKey(* This, uint* pKeyLen, byte* ppKey);

		/// <summary>
		/// Get the value from a ktxHashListEntry
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashListEntry_GetValue(* This, uint* pValueLen, void* ppValue);

		/// <summary>
		/// ===========================================================*
		/// Utilities for printing info about a KTX file.             *
		/// ===========================================================
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintInfoForStdioStream(* stdioStream);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintInfoForNamedFile(byte* filename);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintInfoForMemory(uint* bytes,  int size);

		/// <summary>
		/// ===========================================================*
		/// Utilities for printing info about a KTX2 file.            *
		/// ===========================================================
		/// </summary>
		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintKTX2InfoTextForMemory(* bytes,  size);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintKTX2InfoTextForNamedFile(byte* filename);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintKTX2InfoTextForStdioStream(* stdioStream);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintKTX2InfoTextForStream(ktxStream* stream);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintKTX2InfoJSONForMemory(* bytes,  size,  base_indent,  indent_width, [MarshalAs(UnmanagedType.Bool)] bool minified);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintKTX2InfoJSONForNamedFile(byte* filename,  base_indent,  indent_width, [MarshalAs(UnmanagedType.Bool)] bool minified);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintKTX2InfoJSONForStdioStream(* stdioStream,  base_indent,  indent_width, [MarshalAs(UnmanagedType.Bool)] bool minified);

		[DllImport("meshoptimizer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintKTX2InfoJSONForStream(ktxStream* stream,  base_indent,  indent_width, [MarshalAs(UnmanagedType.Bool)] bool minified);

	}
}
