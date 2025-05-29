using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.KTX
{
	/// <summary>
	/// 
	/// 
	/// @
	/// ~English
	/// 
	/// The function parameters are used to pass values which change for each image.
	/// Obtain values which are uniform across all images from the 
	/// object.
	/// 
	/// </summary>
	public unsafe delegate ktx_error_code_e PFNKTXITERCB(
		 int miplevel,
		 int face,
		 int width,
		 int height,
		 int depth,
		 UInt64 faceLodSize,
		 void* pixels,
		 void* userdata);

	/// <summary>
	/// Don't use KTX_APIENTRYP to avoid a Doxygen bug. 
	/// </summary>
	public unsafe delegate void PFNKTEXDESTROY(
		 ktxTexture* This);

	public unsafe delegate ktx_error_code_e PFNKTEXGETIMAGEOFFSET(
		 ktxTexture* This,
		 UInt32 level,
		 UInt32 layer,
		 UInt32 faceSlice,
		 UIntPtr* pOffset);

	public unsafe delegate UIntPtr PFNKTEXGETDATASIZEUNCOMPRESSED(
		 ktxTexture* This);

	public unsafe delegate UIntPtr PFNKTEXGETIMAGESIZE(
		 ktxTexture* This,
		 UInt32 level);

	public unsafe delegate UIntPtr PFNKTEXGETLEVELSIZE(
		 ktxTexture* This,
		 UInt32 level);

	public unsafe delegate ktx_error_code_e PFNKTEXITERATELEVELS(
		 ktxTexture* This,
		 PFNKTXITERCB iterCb,
		 void* userdata);

	public unsafe delegate ktx_error_code_e PFNKTEXITERATELOADLEVELFACES(
		 ktxTexture* This,
		 PFNKTXITERCB iterCb,
		 void* userdata);

	public unsafe delegate ktx_error_code_e PFNKTEXLOADIMAGEDATA(
		 ktxTexture* This,
		 byte* pBuffer,
		 UIntPtr bufSize);

	public unsafe delegate byte PFNKTEXNEEDSTRANSCODING(
		 ktxTexture* This);

	public unsafe delegate ktx_error_code_e PFNKTEXSETIMAGEFROMMEMORY(
		 ktxTexture* This,
		 UInt32 level,
		 UInt32 layer,
		 UInt32 faceSlice,
		 byte* src,
		 UIntPtr srcSize);

	public unsafe delegate ktx_error_code_e PFNKTEXWRITETONAMEDFILE(
		 ktxTexture* This,
		 byte* dstname);

	public unsafe delegate ktx_error_code_e PFNKTEXWRITETOMEMORY(
		 ktxTexture* This,
		 byte** bytes,
		 UIntPtr* size);

	/// <summary>
	/// 
	/// @
	/// ~English
	/// 
	/// </summary>
	public unsafe delegate void PFNVOIDFUNCTION();

	/// <summary>
	/// 
	/// @
	/// ~English
	/// 
	/// </summary>
	public unsafe delegate PFNVOIDFUNCTION PFNGLGETPROCADDRESS(
		 byte* proc);

}
