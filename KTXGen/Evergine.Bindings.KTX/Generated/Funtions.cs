using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.KTX
{
	public static unsafe partial class KTX
	{
		/// <summary>
		/// Load pointers for the OpenGL functions needed by ktxTexture_GLUpload.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxLoadOpenGL(PFNGLGETPROCADDRESS pfnGLGetProcAddress);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture_CreateFromNamedFile(byte* filename, UInt32 createFlags, ktxTexture* newTex);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture_CreateFromMemory(byte* bytes, UIntPtr size, UInt32 createFlags, ktxTexture* newTex);

		/// <summary>
		/// Returns a pointer to the image data of a ktxTexture object.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ktxTexture_GetData(ktxTexture* This);

		/// <summary>
		/// Returns the pitch of a row of an image at the specified level.
		/// Similar to the rowPitch in a VkSubResourceLayout.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern UInt32 ktxTexture_GetRowPitch(ktxTexture* This, UInt32 level);

		/// <summary>
		/// Return the element size of the texture's images.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern UInt32 ktxTexture_GetElementSize(ktxTexture* This);

		/// <summary>
		/// Returns the size of all the image data of a ktxTexture object in bytes.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern UIntPtr ktxTexture_GetDataSize(ktxTexture* This);

		/// <summary>
		/// Uploads a texture to OpenGL {,ES}. 
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture_GLUpload(ktxTexture* This, UInt32* pTexture, UInt32* pTarget, UInt32* pGlerror);

		/// <summary>
		/// Iterate over the levels or faces in a ktxTexture object.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture_IterateLevelFaces(ktxTexture* This, PFNKTXITERCB iterCb, void* userdata);

		/// <summary>
		/// Create a new ktxTexture1.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_Create(ktxTextureCreateInfo* createInfo, ktxTextureCreateStorageEnum storageAllocation, ktxTexture1* newTex);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_CreateFromNamedFile(byte* filename, UInt32 createFlags, ktxTexture1* newTex);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_CreateFromMemory(byte* bytes, UIntPtr size, UInt32 createFlags, ktxTexture1* newTex);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxTexture1_Destroy(ktxTexture1* This);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ktxTexture1_NeedsTranscoding(ktxTexture1* This);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_LoadImageData(ktxTexture1* This, byte* pBuffer, UIntPtr bufSize);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_WriteToNamedFile(ktxTexture1* This, byte* dstname);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_WriteToMemory(ktxTexture1* This, byte* bytes, UIntPtr* size);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_WriteKTX2ToNamedFile(ktxTexture1* This, byte* dstname);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture1_WriteKTX2ToMemory(ktxTexture1* This, byte* bytes, UIntPtr* size);

		/// <summary>
		/// Create a new ktxTexture2.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_Create(ktxTextureCreateInfo* createInfo, ktxTextureCreateStorageEnum storageAllocation, ktxTexture2* newTex);

		/// <summary>
		/// Create a new ktxTexture2 as a copy of an existing texture.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CreateCopy(ktxTexture2* orig, ktxTexture2* newTex);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CreateFromNamedFile(byte* filename, UInt32 createFlags, ktxTexture2* newTex);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CreateFromMemory(byte* bytes, UIntPtr size, UInt32 createFlags, ktxTexture2* newTex);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxTexture2_Destroy(ktxTexture2* This);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CompressBasis(ktxTexture2* This, UInt32 quality);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_DeflateZstd(ktxTexture2* This, UInt32 level);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_DeflateZLIB(ktxTexture2* This, UInt32 level);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxTexture2_GetComponentInfo(ktxTexture2* This, UInt32* numComponents, UInt32* componentByteLength);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_GetImageOffset(ktxTexture2* This, UInt32 level, UInt32 layer, UInt32 faceSlice, UIntPtr* pOffset);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern UInt32 ktxTexture2_GetNumComponents(ktxTexture2* This);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern khr_df_transfer_e ktxTexture2_GetTransferFunction_e(ktxTexture2* This);

		/// <summary>
		/// For backward compatibility. 
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern khr_df_transfer_e ktxTexture2_GetOETF_e(ktxTexture2* This);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern UInt32 ktxTexture2_GetOETF(ktxTexture2* This);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern khr_df_model_e ktxTexture2_GetColorModel_e(ktxTexture2* This);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ktxTexture2_GetPremultipliedAlpha(ktxTexture2* This);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern khr_df_primaries_e ktxTexture2_GetPrimaries_e(ktxTexture2* This);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ktxTexture2_NeedsTranscoding(ktxTexture2* This);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_SetTransferFunction(ktxTexture2* This, khr_df_transfer_e tf);

		/// <summary>
		/// For backward compatibility. 
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_SetOETF(ktxTexture2* This, khr_df_transfer_e oetf);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_SetPrimaries(ktxTexture2* This, khr_df_primaries_e primaries);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_LoadImageData(ktxTexture2* This, byte* pBuffer, UIntPtr bufSize);

		/// <summary>
		/// For rare testing scenarios. Use ktxTexture2_LoadImageData.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_LoadDeflatedImageData(ktxTexture2* This, byte* pBuffer, UIntPtr bufSize);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_WriteToNamedFile(ktxTexture2* This, byte* dstname);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_WriteToMemory(ktxTexture2* This, byte* bytes, UIntPtr* size);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CompressAstcEx(ktxTexture2* This, ktxAstcParams* @params);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CompressAstc(ktxTexture2* This, UInt32 quality);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_DecodeAstc(ktxTexture2* This);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_CompressBasisEx(ktxTexture2* This, ktxBasisParams* @params);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxTexture2_TranscodeBasis(ktxTexture2* This, ktx_transcode_fmt_e fmt, UInt32 transcodeFlags);

		/// <summary>
		/// Returns a string corresponding to a KTX error code.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ktxErrorString(ktx_error_code_e error);

		/// <summary>
		/// Returns a string corresponding to a supercompression scheme.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ktxSupercompressionSchemeString(ktxSupercmpScheme scheme);

		/// <summary>
		/// Returns a string corresponding to a transcode target format.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ktxTranscodeFormatString(ktx_transcode_fmt_e format);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_Create(ktxHashList* ppHl);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_CreateCopy(ktxHashList* ppHl, ktxHashList orig);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxHashList_Construct(ktxHashList* pHl);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxHashList_ConstructCopy(ktxHashList* pHl, ktxHashList orig);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxHashList_Destroy(ktxHashList* head);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ktxHashList_Destruct(ktxHashList* head);

		/// <summary>
		/// Adds a key-value pair to a hash list.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_AddKVPair(ktxHashList* pHead, byte* key, uint valueLen, void* value);

		/// <summary>
		/// Deletes a ktxHashListEntry from a ktxHashList.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_DeleteEntry(ktxHashList* pHead, ktxHashListEntry* pEntry);

		/// <summary>
		/// Finds the entry for a key in a ktxHashList and deletes it.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_DeleteKVPair(ktxHashList* pHead, byte* key);

		/// <summary>
		/// Looks up a key and returns the ktxHashListEntry.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_FindEntry(ktxHashList* pHead, byte* key, ktxHashListEntry* ppEntry);

		/// <summary>
		/// Looks up a key and returns the value.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_FindValue(ktxHashList* pHead, byte* key, uint* pValueLen, void* pValue);

		/// <summary>
		/// Return the next entry in a ktxHashList.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktxHashListEntry* ktxHashList_Next(ktxHashListEntry* entry);

		/// <summary>
		/// Sorts a ktxHashList into order of the key codepoints.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_Sort(ktxHashList* pHead);

		/// <summary>
		/// Serializes a ktxHashList to a block of memory suitable for
		/// writing to a KTX file.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_Serialize(ktxHashList* pHead, uint* kvdLen, byte* kvd);

		/// <summary>
		/// Creates a hash table from the serialized data read from a
		/// a KTX file.
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashList_Deserialize(ktxHashList* pHead, uint kvdLen, void* kvd);

		/// <summary>
		/// Get the key from a ktxHashListEntry
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashListEntry_GetKey(ktxHashListEntry* This, uint* pKeyLen, byte* ppKey);

		/// <summary>
		/// Get the value from a ktxHashListEntry
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxHashListEntry_GetValue(ktxHashListEntry* This, uint* pValueLen, void* ppValue);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintInfoForNamedFile(byte* filename);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintInfoForMemory(byte* bytes, UIntPtr size);

		/// <summary>
		/// ===========================================================*
		/// Utilities for printing info about a KTX2 file.            *
		/// ===========================================================
		/// </summary>
		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintKTX2InfoTextForMemory(byte* bytes, UIntPtr size);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintKTX2InfoTextForNamedFile(byte* filename);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintKTX2InfoJSONForMemory(byte* bytes, UIntPtr size, UInt32 base_indent, UInt32 indent_width, [MarshalAs(UnmanagedType.Bool)] bool minified);

		[DllImport("ktx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ktx_error_code_e ktxPrintKTX2InfoJSONForNamedFile(byte* filename, UInt32 base_indent, UInt32 indent_width, [MarshalAs(UnmanagedType.Bool)] bool minified);

	}
}
