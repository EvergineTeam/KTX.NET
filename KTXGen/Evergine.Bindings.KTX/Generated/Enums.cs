using System;

namespace Evergine.Bindings.KTX
{
	/// <summary>
	/// Accessors 
	/// </summary>
	public enum khr_word_e
	{
		KHR_DF_WORD_VENDORID = 0,
		KHR_DF_WORD_DESCRIPTORTYPE = 0,
		KHR_DF_WORD_VERSIONNUMBER = 1,
		KHR_DF_WORD_DESCRIPTORBLOCKSIZE = 1,
		KHR_DF_WORD_MODEL = 2,
		KHR_DF_WORD_PRIMARIES = 2,
		KHR_DF_WORD_TRANSFER = 2,
		KHR_DF_WORD_FLAGS = 2,
		KHR_DF_WORD_TEXELBLOCKDIMENSION0 = 3,
		KHR_DF_WORD_TEXELBLOCKDIMENSION1 = 3,
		KHR_DF_WORD_TEXELBLOCKDIMENSION2 = 3,
		KHR_DF_WORD_TEXELBLOCKDIMENSION3 = 3,
		KHR_DF_WORD_BYTESPLANE0 = 4,
		KHR_DF_WORD_BYTESPLANE1 = 4,
		KHR_DF_WORD_BYTESPLANE2 = 4,
		KHR_DF_WORD_BYTESPLANE3 = 4,
		KHR_DF_WORD_BYTESPLANE4 = 5,
		KHR_DF_WORD_BYTESPLANE5 = 5,
		KHR_DF_WORD_BYTESPLANE6 = 5,
		KHR_DF_WORD_BYTESPLANE7 = 5,
		KHR_DF_WORD_SAMPLESTART = 6,
		KHR_DF_WORD_SAMPLEWORDS = 4,
	}

	public enum khr_df_shift_e
	{
		KHR_DF_SHIFT_VENDORID = 0,
		KHR_DF_SHIFT_DESCRIPTORTYPE = 17,
		KHR_DF_SHIFT_VERSIONNUMBER = 0,
		KHR_DF_SHIFT_DESCRIPTORBLOCKSIZE = 16,
		KHR_DF_SHIFT_MODEL = 0,
		KHR_DF_SHIFT_PRIMARIES = 8,
		KHR_DF_SHIFT_TRANSFER = 16,
		KHR_DF_SHIFT_FLAGS = 24,
		KHR_DF_SHIFT_TEXELBLOCKDIMENSION0 = 0,
		KHR_DF_SHIFT_TEXELBLOCKDIMENSION1 = 8,
		KHR_DF_SHIFT_TEXELBLOCKDIMENSION2 = 16,
		KHR_DF_SHIFT_TEXELBLOCKDIMENSION3 = 24,
		KHR_DF_SHIFT_BYTESPLANE0 = 0,
		KHR_DF_SHIFT_BYTESPLANE1 = 8,
		KHR_DF_SHIFT_BYTESPLANE2 = 16,
		KHR_DF_SHIFT_BYTESPLANE3 = 24,
		KHR_DF_SHIFT_BYTESPLANE4 = 0,
		KHR_DF_SHIFT_BYTESPLANE5 = 8,
		KHR_DF_SHIFT_BYTESPLANE6 = 16,
		KHR_DF_SHIFT_BYTESPLANE7 = 24,
	}

	public enum khr_df_mask_e
	{
		KHR_DF_MASK_VENDORID = 131071,
		KHR_DF_MASK_DESCRIPTORTYPE = 32767,
		KHR_DF_MASK_VERSIONNUMBER = 65535,
		KHR_DF_MASK_DESCRIPTORBLOCKSIZE = 65535,
		KHR_DF_MASK_MODEL = 255,
		KHR_DF_MASK_PRIMARIES = 255,
		KHR_DF_MASK_TRANSFER = 255,
		KHR_DF_MASK_FLAGS = 255,
		KHR_DF_MASK_TEXELBLOCKDIMENSION0 = 255,
		KHR_DF_MASK_TEXELBLOCKDIMENSION1 = 255,
		KHR_DF_MASK_TEXELBLOCKDIMENSION2 = 255,
		KHR_DF_MASK_TEXELBLOCKDIMENSION3 = 255,
		KHR_DF_MASK_BYTESPLANE0 = 255,
		KHR_DF_MASK_BYTESPLANE1 = 255,
		KHR_DF_MASK_BYTESPLANE2 = 255,
		KHR_DF_MASK_BYTESPLANE3 = 255,
		KHR_DF_MASK_BYTESPLANE4 = 255,
		KHR_DF_MASK_BYTESPLANE5 = 255,
		KHR_DF_MASK_BYTESPLANE6 = 255,
		KHR_DF_MASK_BYTESPLANE7 = 255,
	}

	/// <summary>
	/// Offsets relative to the start of a sample 
	/// </summary>
	public enum khr_df_sampleword_e
	{
		KHR_DF_SAMPLEWORD_BITOFFSET = 0,
		KHR_DF_SAMPLEWORD_BITLENGTH = 0,
		KHR_DF_SAMPLEWORD_CHANNELID = 0,
		KHR_DF_SAMPLEWORD_QUALIFIERS = 0,
		KHR_DF_SAMPLEWORD_SAMPLEPOSITION0 = 1,
		KHR_DF_SAMPLEWORD_SAMPLEPOSITION1 = 1,
		KHR_DF_SAMPLEWORD_SAMPLEPOSITION2 = 1,
		KHR_DF_SAMPLEWORD_SAMPLEPOSITION3 = 1,
		KHR_DF_SAMPLEWORD_SAMPLEPOSITION_ALL = 1,
		KHR_DF_SAMPLEWORD_SAMPLELOWER = 2,
		KHR_DF_SAMPLEWORD_SAMPLEUPPER = 3,
	}

	public enum khr_df_sampleshift_e
	{
		KHR_DF_SAMPLESHIFT_BITOFFSET = 0,
		KHR_DF_SAMPLESHIFT_BITLENGTH = 16,
		KHR_DF_SAMPLESHIFT_CHANNELID = 24,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLESHIFT_QUALIFIERS = 24,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLESHIFT_SAMPLEPOSITION0 = 0,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLESHIFT_SAMPLEPOSITION1 = 8,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLESHIFT_SAMPLEPOSITION2 = 16,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLESHIFT_SAMPLEPOSITION3 = 24,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLESHIFT_SAMPLEPOSITION_ALL = 0,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLESHIFT_SAMPLELOWER = 0,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLESHIFT_SAMPLEUPPER = 0,
	}

	public enum khr_df_samplemask_e
	{
		KHR_DF_SAMPLEMASK_BITOFFSET = 65535,
		KHR_DF_SAMPLEMASK_BITLENGTH = 255,
		KHR_DF_SAMPLEMASK_CHANNELID = 15,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLEMASK_QUALIFIERS = 240,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLEMASK_SAMPLEPOSITION0 = 255,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLEMASK_SAMPLEPOSITION1 = 255,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLEMASK_SAMPLEPOSITION2 = 255,

		/// <summary>
		/// N.B. Qualifiers are defined as an offset into a byte 
		/// </summary>
		KHR_DF_SAMPLEMASK_SAMPLEPOSITION3 = 255,

		/// <summary>
		/// ISO C restricts enum values to range of int hence the
		/// cast. We do it verbosely instead of using -1 to ensure
		/// it is a 32-bit value even if int is 64 bits. 
		/// </summary>
		KHR_DF_SAMPLEMASK_SAMPLEPOSITION_ALL = -1,

		/// <summary>
		/// ISO C restricts enum values to range of int hence the
		/// cast. We do it verbosely instead of using -1 to ensure
		/// it is a 32-bit value even if int is 64 bits. 
		/// </summary>
		KHR_DF_SAMPLEMASK_SAMPLELOWER = -1,

		/// <summary>
		/// ISO C restricts enum values to range of int hence the
		/// cast. We do it verbosely instead of using -1 to ensure
		/// it is a 32-bit value even if int is 64 bits. 
		/// </summary>
		KHR_DF_SAMPLEMASK_SAMPLEUPPER = -1,
	}

	/// <summary>
	/// Vendor ids 
	/// </summary>
	public enum khr_df_vendorid_e
	{

		/// <summary>
		/// Standard Khronos descriptor 
		/// </summary>
		KHR_DF_VENDORID_KHRONOS = 0,

		/// <summary>
		/// Standard Khronos descriptor 
		/// </summary>
		KHR_DF_VENDORID_MAX = 131071,
	}

	/// <summary>
	/// Descriptor types 
	/// </summary>
	public enum khr_df_khr_descriptortype_e
	{

		/// <summary>
		/// Default Khronos basic descriptor block 
		/// </summary>
		KHR_DF_KHR_DESCRIPTORTYPE_BASICFORMAT = 0,

		/// <summary>
		/// Extension descriptor block for additional planes 
		/// </summary>
		KHR_DF_KHR_DESCRIPTORTYPE_ADDITIONAL_PLANES = 24577,

		/// <summary>
		/// Extension descriptor block for additional dimensions 
		/// </summary>
		KHR_DF_KHR_DESCRIPTORTYPE_ADDITIONAL_DIMENSIONS = 24578,

		/// <summary>
		/// Bit indicates modifying requires understanding this extension 
		/// </summary>
		KHR_DF_KHR_DESCRIPTORTYPE_NEEDED_FOR_WRITE_BIT = 8192,

		/// <summary>
		/// Bit indicates processing requires understanding this extension 
		/// </summary>
		KHR_DF_KHR_DESCRIPTORTYPE_NEEDED_FOR_DECODE_BIT = 16384,

		/// <summary>
		/// Bit indicates processing requires understanding this extension 
		/// </summary>
		KHR_DF_KHR_DESCRIPTORTYPE_MAX = 32767,
	}

	/// <summary>
	/// Descriptor block version 
	/// </summary>
	public enum khr_df_versionnumber_e
	{

		/// <summary>
		/// Version 1.0 of the specification 
		/// </summary>
		KHR_DF_VERSIONNUMBER_1_0 = 0,

		/// <summary>
		/// Version 1.1 did not bump the version number 
		/// </summary>
		KHR_DF_VERSIONNUMBER_1_1 = 0,

		/// <summary>
		/// Version 1.2 increased the version number 
		/// </summary>
		KHR_DF_VERSIONNUMBER_1_2 = 1,

		/// <summary>
		/// Version 1.3 increased the version number 
		/// </summary>
		KHR_DF_VERSIONNUMBER_1_3 = 2,

		/// <summary>
		/// Version 1.4.0 did not bump the block version number 
		/// </summary>
		KHR_DF_VERSIONNUMBER_1_4 = 2,
		KHR_DF_VERSIONNUMBER_LATEST = 2,
		KHR_DF_VERSIONNUMBER_MAX = 65535,
	}

	/// <summary>
	/// Model in which the color coordinate space is defined.
	/// There is no requirement that a color format use all the
	/// channel types that are defined in the color model. 
	/// </summary>
	public enum khr_df_model_e
	{

		/// <summary>
		/// No interpretation of color channels defined 
		/// </summary>
		KHR_DF_MODEL_UNSPECIFIED = 0,

		/// <summary>
		/// Color primaries (red, green, blue) + alpha, depth and stencil 
		/// </summary>
		KHR_DF_MODEL_RGBSDA = 1,

		/// <summary>
		/// Color differences (Y', Cb, Cr) + alpha, depth and stencil 
		/// </summary>
		KHR_DF_MODEL_YUVSDA = 2,

		/// <summary>
		/// Color differences (Y', I, Q) + alpha, depth and stencil 
		/// </summary>
		KHR_DF_MODEL_YIQSDA = 3,

		/// <summary>
		/// Perceptual color (CIE L*a*b*) + alpha, depth and stencil 
		/// </summary>
		KHR_DF_MODEL_LABSDA = 4,

		/// <summary>
		/// Subtractive colors (cyan, magenta, yellow, black) + alpha 
		/// </summary>
		KHR_DF_MODEL_CMYKA = 5,

		/// <summary>
		/// Non-color coordinate data (X, Y, Z, W) 
		/// </summary>
		KHR_DF_MODEL_XYZW = 6,

		/// <summary>
		/// Hue, saturation, value, hue angle on color circle, plus alpha 
		/// </summary>
		KHR_DF_MODEL_HSVA_ANG = 7,

		/// <summary>
		/// Hue, saturation, lightness, hue angle on color circle, plus alpha 
		/// </summary>
		KHR_DF_MODEL_HSLA_ANG = 8,

		/// <summary>
		/// Hue, saturation, value, hue on color hexagon, plus alpha 
		/// </summary>
		KHR_DF_MODEL_HSVA_HEX = 9,

		/// <summary>
		/// Hue, saturation, lightness, hue on color hexagon, plus alpha 
		/// </summary>
		KHR_DF_MODEL_HSLA_HEX = 10,

		/// <summary>
		/// Lightweight approximate color difference (luma, orange, green) 
		/// </summary>
		KHR_DF_MODEL_YCGCOA = 11,

		/// <summary>
		/// ITU BT.2020 constant luminance YcCbcCrc 
		/// </summary>
		KHR_DF_MODEL_YCCBCCRC = 12,

		/// <summary>
		/// ITU BT.2100 constant intensity ICtCp 
		/// </summary>
		KHR_DF_MODEL_ICTCP = 13,

		/// <summary>
		/// CIE 1931 XYZ color coordinates (X, Y, Z) 
		/// </summary>
		KHR_DF_MODEL_CIEXYZ = 14,

		/// <summary>
		/// CIE 1931 xyY color coordinates (X, Y, Y) 
		/// </summary>
		KHR_DF_MODEL_CIEXYY = 15,

		/// <summary>
		/// Compressed formats start at 128. 
		/// These compressed formats should generally have a single sample,
		/// sited at the 0,0 position of the texel block. Where multiple
		/// channels are used to distinguish formats, these should be cosited. 
		/// Direct3D (and S3) compressed formats 
		/// Note that premultiplied status is recorded separately 
		/// DXT1 "channels" are RGB (0), Alpha (1) 
		/// DXT1/BC1 with one channel is opaque 
		/// DXT1/BC1 with a cosited alpha sample is transparent 
		/// </summary>
		KHR_DF_MODEL_DXT1A = 128,

		/// <summary>
		/// Compressed formats start at 128. 
		/// These compressed formats should generally have a single sample,
		/// sited at the 0,0 position of the texel block. Where multiple
		/// channels are used to distinguish formats, these should be cosited. 
		/// Direct3D (and S3) compressed formats 
		/// Note that premultiplied status is recorded separately 
		/// DXT1 "channels" are RGB (0), Alpha (1) 
		/// DXT1/BC1 with one channel is opaque 
		/// DXT1/BC1 with a cosited alpha sample is transparent 
		/// </summary>
		KHR_DF_MODEL_BC1A = 128,

		/// <summary>
		/// DXT2/DXT3/BC2, with explicit 4-bit alpha 
		/// </summary>
		KHR_DF_MODEL_DXT2 = 129,

		/// <summary>
		/// DXT2/DXT3/BC2, with explicit 4-bit alpha 
		/// </summary>
		KHR_DF_MODEL_DXT3 = 129,

		/// <summary>
		/// DXT2/DXT3/BC2, with explicit 4-bit alpha 
		/// </summary>
		KHR_DF_MODEL_BC2 = 129,

		/// <summary>
		/// DXT4/DXT5/BC3, with interpolated alpha 
		/// </summary>
		KHR_DF_MODEL_DXT4 = 130,

		/// <summary>
		/// DXT4/DXT5/BC3, with interpolated alpha 
		/// </summary>
		KHR_DF_MODEL_DXT5 = 130,

		/// <summary>
		/// DXT4/DXT5/BC3, with interpolated alpha 
		/// </summary>
		KHR_DF_MODEL_BC3 = 130,

		/// <summary>
		/// ATI1n/DXT5A/BC4 - single channel interpolated 8-bit data 
		/// (The UNORM/SNORM variation is recorded in the channel data) 
		/// </summary>
		KHR_DF_MODEL_ATI1N = 131,

		/// <summary>
		/// ATI1n/DXT5A/BC4 - single channel interpolated 8-bit data 
		/// (The UNORM/SNORM variation is recorded in the channel data) 
		/// </summary>
		KHR_DF_MODEL_DXT5A = 131,

		/// <summary>
		/// ATI1n/DXT5A/BC4 - single channel interpolated 8-bit data 
		/// (The UNORM/SNORM variation is recorded in the channel data) 
		/// </summary>
		KHR_DF_MODEL_BC4 = 131,

		/// <summary>
		/// ATI2n_XY/DXN/BC5 - two channel interpolated 8-bit data 
		/// (The UNORM/SNORM variation is recorded in the channel data) 
		/// </summary>
		KHR_DF_MODEL_ATI2N_XY = 132,

		/// <summary>
		/// ATI2n_XY/DXN/BC5 - two channel interpolated 8-bit data 
		/// (The UNORM/SNORM variation is recorded in the channel data) 
		/// </summary>
		KHR_DF_MODEL_DXN = 132,

		/// <summary>
		/// ATI2n_XY/DXN/BC5 - two channel interpolated 8-bit data 
		/// (The UNORM/SNORM variation is recorded in the channel data) 
		/// </summary>
		KHR_DF_MODEL_BC5 = 132,

		/// <summary>
		/// BC6H - DX11 format for 16-bit float channels 
		/// </summary>
		KHR_DF_MODEL_BC6H = 133,

		/// <summary>
		/// BC7 - DX11 format 
		/// </summary>
		KHR_DF_MODEL_BC7 = 134,

		/// <summary>
		/// Mobile compressed formats follow 
		/// A format of ETC1 indicates that the format shall be decodable
		/// by an ETC1-compliant decoder and not rely on ETC2 features 
		/// </summary>
		KHR_DF_MODEL_ETC1 = 160,

		/// <summary>
		/// A format of ETC2 is permitted to use ETC2 encodings on top of
		/// the baseline ETC1 specification 
		/// The ETC2 format has channels "red", "green", "RGB" and "alpha",
		/// which should be cosited samples 
		/// Punch-through alpha can be distinguished from full alpha by
		/// the plane size in bytes required for the texel block 
		/// </summary>
		KHR_DF_MODEL_ETC2 = 161,

		/// <summary>
		/// Adaptive Scalable Texture Compression 
		/// ASTC HDR vs LDR is determined by the float flag in the channel 
		/// ASTC block size can be distinguished by texel block size 
		/// </summary>
		KHR_DF_MODEL_ASTC = 162,

		/// <summary>
		/// ETC1S is a simplified subset of ETC1 
		/// </summary>
		KHR_DF_MODEL_ETC1S = 163,

		/// <summary>
		/// PowerVR Texture Compression 
		/// </summary>
		KHR_DF_MODEL_PVRTC = 164,

		/// <summary>
		/// PowerVR Texture Compression 
		/// </summary>
		KHR_DF_MODEL_PVRTC2 = 165,

		/// <summary>
		/// PowerVR Texture Compression 
		/// </summary>
		KHR_DF_MODEL_UASTC = 166,

		/// <summary>
		/// Proprietary formats (ATITC, etc.) should follow 
		/// </summary>
		KHR_DF_MODEL_MAX = 255,
	}

	/// <summary>
	/// Definition of channel names for each color model 
	/// </summary>
	public enum khr_df_model_channels_e
	{

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_0 = 0,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_1 = 1,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_2 = 2,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_3 = 3,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_4 = 4,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_5 = 5,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_6 = 6,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_7 = 7,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_8 = 8,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_9 = 9,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_10 = 10,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_11 = 11,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_12 = 12,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_13 = 13,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_14 = 14,

		/// <summary>
		/// Unspecified format with nominal channel numbering 
		/// </summary>
		KHR_DF_CHANNEL_UNSPECIFIED_15 = 15,

		/// <summary>
		/// MODEL_RGBSDA - red, green, blue, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_RGBSDA_RED = 0,

		/// <summary>
		/// MODEL_RGBSDA - red, green, blue, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_RGBSDA_R = 0,

		/// <summary>
		/// MODEL_RGBSDA - red, green, blue, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_RGBSDA_GREEN = 1,

		/// <summary>
		/// MODEL_RGBSDA - red, green, blue, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_RGBSDA_G = 1,

		/// <summary>
		/// MODEL_RGBSDA - red, green, blue, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_RGBSDA_BLUE = 2,

		/// <summary>
		/// MODEL_RGBSDA - red, green, blue, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_RGBSDA_B = 2,

		/// <summary>
		/// MODEL_RGBSDA - red, green, blue, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_RGBSDA_STENCIL = 13,

		/// <summary>
		/// MODEL_RGBSDA - red, green, blue, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_RGBSDA_S = 13,

		/// <summary>
		/// MODEL_RGBSDA - red, green, blue, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_RGBSDA_DEPTH = 14,

		/// <summary>
		/// MODEL_RGBSDA - red, green, blue, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_RGBSDA_D = 14,

		/// <summary>
		/// MODEL_RGBSDA - red, green, blue, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_RGBSDA_ALPHA = 15,

		/// <summary>
		/// MODEL_RGBSDA - red, green, blue, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_RGBSDA_A = 15,

		/// <summary>
		/// MODEL_YUVSDA - luma, Cb, Cr, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YUVSDA_Y = 0,

		/// <summary>
		/// MODEL_YUVSDA - luma, Cb, Cr, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YUVSDA_CB = 1,

		/// <summary>
		/// MODEL_YUVSDA - luma, Cb, Cr, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YUVSDA_U = 1,

		/// <summary>
		/// MODEL_YUVSDA - luma, Cb, Cr, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YUVSDA_CR = 2,

		/// <summary>
		/// MODEL_YUVSDA - luma, Cb, Cr, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YUVSDA_V = 2,

		/// <summary>
		/// MODEL_YUVSDA - luma, Cb, Cr, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YUVSDA_STENCIL = 13,

		/// <summary>
		/// MODEL_YUVSDA - luma, Cb, Cr, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YUVSDA_S = 13,

		/// <summary>
		/// MODEL_YUVSDA - luma, Cb, Cr, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YUVSDA_DEPTH = 14,

		/// <summary>
		/// MODEL_YUVSDA - luma, Cb, Cr, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YUVSDA_D = 14,

		/// <summary>
		/// MODEL_YUVSDA - luma, Cb, Cr, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YUVSDA_ALPHA = 15,

		/// <summary>
		/// MODEL_YUVSDA - luma, Cb, Cr, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YUVSDA_A = 15,

		/// <summary>
		/// MODEL_YIQSDA - luma, in-phase, quadrature, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YIQSDA_Y = 0,

		/// <summary>
		/// MODEL_YIQSDA - luma, in-phase, quadrature, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YIQSDA_I = 1,

		/// <summary>
		/// MODEL_YIQSDA - luma, in-phase, quadrature, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YIQSDA_Q = 2,

		/// <summary>
		/// MODEL_YIQSDA - luma, in-phase, quadrature, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YIQSDA_STENCIL = 13,

		/// <summary>
		/// MODEL_YIQSDA - luma, in-phase, quadrature, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YIQSDA_S = 13,

		/// <summary>
		/// MODEL_YIQSDA - luma, in-phase, quadrature, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YIQSDA_DEPTH = 14,

		/// <summary>
		/// MODEL_YIQSDA - luma, in-phase, quadrature, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YIQSDA_D = 14,

		/// <summary>
		/// MODEL_YIQSDA - luma, in-phase, quadrature, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YIQSDA_ALPHA = 15,

		/// <summary>
		/// MODEL_YIQSDA - luma, in-phase, quadrature, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YIQSDA_A = 15,

		/// <summary>
		/// MODEL_LABSDA - CIELAB/L*a*b* luma, red-green, blue-yellow, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_LABSDA_L = 0,

		/// <summary>
		/// MODEL_LABSDA - CIELAB/L*a*b* luma, red-green, blue-yellow, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_LABSDA_A = 1,

		/// <summary>
		/// MODEL_LABSDA - CIELAB/L*a*b* luma, red-green, blue-yellow, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_LABSDA_B = 2,

		/// <summary>
		/// MODEL_LABSDA - CIELAB/L*a*b* luma, red-green, blue-yellow, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_LABSDA_STENCIL = 13,

		/// <summary>
		/// MODEL_LABSDA - CIELAB/L*a*b* luma, red-green, blue-yellow, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_LABSDA_S = 13,

		/// <summary>
		/// MODEL_LABSDA - CIELAB/L*a*b* luma, red-green, blue-yellow, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_LABSDA_DEPTH = 14,

		/// <summary>
		/// MODEL_LABSDA - CIELAB/L*a*b* luma, red-green, blue-yellow, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_LABSDA_D = 14,

		/// <summary>
		/// MODEL_LABSDA - CIELAB/L*a*b* luma, red-green, blue-yellow, stencil, depth, alpha 
		/// </summary>
		KHR_DF_CHANNEL_LABSDA_ALPHA = 15,

		/// <summary>
		/// NOTE: KHR_DF_CHANNEL_LABSDA_A is not a synonym for alpha! 
		/// MODEL_CMYKA - cyan, magenta, yellow, key/blacK, alpha 
		/// </summary>
		KHR_DF_CHANNEL_CMYKSDA_CYAN = 0,

		/// <summary>
		/// NOTE: KHR_DF_CHANNEL_LABSDA_A is not a synonym for alpha! 
		/// MODEL_CMYKA - cyan, magenta, yellow, key/blacK, alpha 
		/// </summary>
		KHR_DF_CHANNEL_CMYKSDA_C = 0,

		/// <summary>
		/// NOTE: KHR_DF_CHANNEL_LABSDA_A is not a synonym for alpha! 
		/// MODEL_CMYKA - cyan, magenta, yellow, key/blacK, alpha 
		/// </summary>
		KHR_DF_CHANNEL_CMYKSDA_MAGENTA = 1,

		/// <summary>
		/// NOTE: KHR_DF_CHANNEL_LABSDA_A is not a synonym for alpha! 
		/// MODEL_CMYKA - cyan, magenta, yellow, key/blacK, alpha 
		/// </summary>
		KHR_DF_CHANNEL_CMYKSDA_M = 1,

		/// <summary>
		/// NOTE: KHR_DF_CHANNEL_LABSDA_A is not a synonym for alpha! 
		/// MODEL_CMYKA - cyan, magenta, yellow, key/blacK, alpha 
		/// </summary>
		KHR_DF_CHANNEL_CMYKSDA_YELLOW = 2,

		/// <summary>
		/// NOTE: KHR_DF_CHANNEL_LABSDA_A is not a synonym for alpha! 
		/// MODEL_CMYKA - cyan, magenta, yellow, key/blacK, alpha 
		/// </summary>
		KHR_DF_CHANNEL_CMYKSDA_Y = 2,

		/// <summary>
		/// NOTE: KHR_DF_CHANNEL_LABSDA_A is not a synonym for alpha! 
		/// MODEL_CMYKA - cyan, magenta, yellow, key/blacK, alpha 
		/// </summary>
		KHR_DF_CHANNEL_CMYKSDA_KEY = 3,

		/// <summary>
		/// NOTE: KHR_DF_CHANNEL_LABSDA_A is not a synonym for alpha! 
		/// MODEL_CMYKA - cyan, magenta, yellow, key/blacK, alpha 
		/// </summary>
		KHR_DF_CHANNEL_CMYKSDA_BLACK = 3,

		/// <summary>
		/// NOTE: KHR_DF_CHANNEL_LABSDA_A is not a synonym for alpha! 
		/// MODEL_CMYKA - cyan, magenta, yellow, key/blacK, alpha 
		/// </summary>
		KHR_DF_CHANNEL_CMYKSDA_K = 3,

		/// <summary>
		/// NOTE: KHR_DF_CHANNEL_LABSDA_A is not a synonym for alpha! 
		/// MODEL_CMYKA - cyan, magenta, yellow, key/blacK, alpha 
		/// </summary>
		KHR_DF_CHANNEL_CMYKSDA_ALPHA = 15,

		/// <summary>
		/// NOTE: KHR_DF_CHANNEL_LABSDA_A is not a synonym for alpha! 
		/// MODEL_CMYKA - cyan, magenta, yellow, key/blacK, alpha 
		/// </summary>
		KHR_DF_CHANNEL_CMYKSDA_A = 15,

		/// <summary>
		/// MODEL_XYZW - coordinates x, y, z, w 
		/// </summary>
		KHR_DF_CHANNEL_XYZW_X = 0,

		/// <summary>
		/// MODEL_XYZW - coordinates x, y, z, w 
		/// </summary>
		KHR_DF_CHANNEL_XYZW_Y = 1,

		/// <summary>
		/// MODEL_XYZW - coordinates x, y, z, w 
		/// </summary>
		KHR_DF_CHANNEL_XYZW_Z = 2,

		/// <summary>
		/// MODEL_XYZW - coordinates x, y, z, w 
		/// </summary>
		KHR_DF_CHANNEL_XYZW_W = 3,

		/// <summary>
		/// MODEL_HSVA_ANG - value (luma), saturation, hue, alpha, angular projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_ANG_VALUE = 0,

		/// <summary>
		/// MODEL_HSVA_ANG - value (luma), saturation, hue, alpha, angular projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_ANG_V = 0,

		/// <summary>
		/// MODEL_HSVA_ANG - value (luma), saturation, hue, alpha, angular projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_ANG_SATURATION = 1,

		/// <summary>
		/// MODEL_HSVA_ANG - value (luma), saturation, hue, alpha, angular projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_ANG_S = 1,

		/// <summary>
		/// MODEL_HSVA_ANG - value (luma), saturation, hue, alpha, angular projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_ANG_HUE = 2,

		/// <summary>
		/// MODEL_HSVA_ANG - value (luma), saturation, hue, alpha, angular projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_ANG_H = 2,

		/// <summary>
		/// MODEL_HSVA_ANG - value (luma), saturation, hue, alpha, angular projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_ANG_ALPHA = 15,

		/// <summary>
		/// MODEL_HSVA_ANG - value (luma), saturation, hue, alpha, angular projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_ANG_A = 15,

		/// <summary>
		/// MODEL_HSLA_ANG - lightness (luma), saturation, hue, alpha, angular projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_ANG_LIGHTNESS = 0,

		/// <summary>
		/// MODEL_HSLA_ANG - lightness (luma), saturation, hue, alpha, angular projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_ANG_L = 0,

		/// <summary>
		/// MODEL_HSLA_ANG - lightness (luma), saturation, hue, alpha, angular projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_ANG_SATURATION = 1,

		/// <summary>
		/// MODEL_HSLA_ANG - lightness (luma), saturation, hue, alpha, angular projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_ANG_S = 1,

		/// <summary>
		/// MODEL_HSLA_ANG - lightness (luma), saturation, hue, alpha, angular projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_ANG_HUE = 2,

		/// <summary>
		/// MODEL_HSLA_ANG - lightness (luma), saturation, hue, alpha, angular projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_ANG_H = 2,

		/// <summary>
		/// MODEL_HSLA_ANG - lightness (luma), saturation, hue, alpha, angular projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_ANG_ALPHA = 15,

		/// <summary>
		/// MODEL_HSLA_ANG - lightness (luma), saturation, hue, alpha, angular projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_ANG_A = 15,

		/// <summary>
		/// MODEL_HSVA_HEX - value (luma), saturation, hue, alpha, hexagonal projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_HEX_VALUE = 0,

		/// <summary>
		/// MODEL_HSVA_HEX - value (luma), saturation, hue, alpha, hexagonal projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_HEX_V = 0,

		/// <summary>
		/// MODEL_HSVA_HEX - value (luma), saturation, hue, alpha, hexagonal projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_HEX_SATURATION = 1,

		/// <summary>
		/// MODEL_HSVA_HEX - value (luma), saturation, hue, alpha, hexagonal projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_HEX_S = 1,

		/// <summary>
		/// MODEL_HSVA_HEX - value (luma), saturation, hue, alpha, hexagonal projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_HEX_HUE = 2,

		/// <summary>
		/// MODEL_HSVA_HEX - value (luma), saturation, hue, alpha, hexagonal projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_HEX_H = 2,

		/// <summary>
		/// MODEL_HSVA_HEX - value (luma), saturation, hue, alpha, hexagonal projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_HEX_ALPHA = 15,

		/// <summary>
		/// MODEL_HSVA_HEX - value (luma), saturation, hue, alpha, hexagonal projection, conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSVA_HEX_A = 15,

		/// <summary>
		/// MODEL_HSLA_HEX - lightness (luma), saturation, hue, alpha, hexagonal projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_HEX_LIGHTNESS = 0,

		/// <summary>
		/// MODEL_HSLA_HEX - lightness (luma), saturation, hue, alpha, hexagonal projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_HEX_L = 0,

		/// <summary>
		/// MODEL_HSLA_HEX - lightness (luma), saturation, hue, alpha, hexagonal projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_HEX_SATURATION = 1,

		/// <summary>
		/// MODEL_HSLA_HEX - lightness (luma), saturation, hue, alpha, hexagonal projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_HEX_S = 1,

		/// <summary>
		/// MODEL_HSLA_HEX - lightness (luma), saturation, hue, alpha, hexagonal projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_HEX_HUE = 2,

		/// <summary>
		/// MODEL_HSLA_HEX - lightness (luma), saturation, hue, alpha, hexagonal projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_HEX_H = 2,

		/// <summary>
		/// MODEL_HSLA_HEX - lightness (luma), saturation, hue, alpha, hexagonal projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_HEX_ALPHA = 15,

		/// <summary>
		/// MODEL_HSLA_HEX - lightness (luma), saturation, hue, alpha, hexagonal projection, double conical space 
		/// </summary>
		KHR_DF_CHANNEL_HSLA_HEX_A = 15,

		/// <summary>
		/// MODEL_YCGCOA - luma, green delta, orange delta, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YCGCOA_Y = 0,

		/// <summary>
		/// MODEL_YCGCOA - luma, green delta, orange delta, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YCGCOA_CG = 1,

		/// <summary>
		/// MODEL_YCGCOA - luma, green delta, orange delta, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YCGCOA_CO = 2,

		/// <summary>
		/// MODEL_YCGCOA - luma, green delta, orange delta, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YCGCOA_ALPHA = 15,

		/// <summary>
		/// MODEL_YCGCOA - luma, green delta, orange delta, alpha 
		/// </summary>
		KHR_DF_CHANNEL_YCGCOA_A = 15,

		/// <summary>
		/// MODEL_CIEXYZ - CIE 1931 X, Y, Z 
		/// </summary>
		KHR_DF_CHANNEL_CIEXYZ_X = 0,

		/// <summary>
		/// MODEL_CIEXYZ - CIE 1931 X, Y, Z 
		/// </summary>
		KHR_DF_CHANNEL_CIEXYZ_Y = 1,

		/// <summary>
		/// MODEL_CIEXYZ - CIE 1931 X, Y, Z 
		/// </summary>
		KHR_DF_CHANNEL_CIEXYZ_Z = 2,

		/// <summary>
		/// MODEL_CIEXYY - CIE 1931 x, y, Y 
		/// </summary>
		KHR_DF_CHANNEL_CIEXYY_X = 0,

		/// <summary>
		/// MODEL_CIEXYY - CIE 1931 x, y, Y 
		/// </summary>
		KHR_DF_CHANNEL_CIEXYY_YCHROMA = 1,

		/// <summary>
		/// MODEL_CIEXYY - CIE 1931 x, y, Y 
		/// </summary>
		KHR_DF_CHANNEL_CIEXYY_YLUMA = 2,

		/// <summary>
		/// Compressed formats 
		/// MODEL_DXT1A/MODEL_BC1A 
		/// </summary>
		KHR_DF_CHANNEL_DXT1A_COLOR = 0,

		/// <summary>
		/// Compressed formats 
		/// MODEL_DXT1A/MODEL_BC1A 
		/// </summary>
		KHR_DF_CHANNEL_BC1A_COLOR = 0,

		/// <summary>
		/// Compressed formats 
		/// MODEL_DXT1A/MODEL_BC1A 
		/// </summary>
		KHR_DF_CHANNEL_DXT1A_ALPHAPRESENT = 1,

		/// <summary>
		/// Compressed formats 
		/// MODEL_DXT1A/MODEL_BC1A 
		/// </summary>
		KHR_DF_CHANNEL_DXT1A_ALPHA = 1,

		/// <summary>
		/// Compressed formats 
		/// MODEL_DXT1A/MODEL_BC1A 
		/// </summary>
		KHR_DF_CHANNEL_BC1A_ALPHAPRESENT = 1,

		/// <summary>
		/// Compressed formats 
		/// MODEL_DXT1A/MODEL_BC1A 
		/// </summary>
		KHR_DF_CHANNEL_BC1A_ALPHA = 1,

		/// <summary>
		/// MODEL_DXT2/3/MODEL_BC2 
		/// </summary>
		KHR_DF_CHANNEL_DXT2_COLOR = 0,

		/// <summary>
		/// MODEL_DXT2/3/MODEL_BC2 
		/// </summary>
		KHR_DF_CHANNEL_DXT3_COLOR = 0,

		/// <summary>
		/// MODEL_DXT2/3/MODEL_BC2 
		/// </summary>
		KHR_DF_CHANNEL_BC2_COLOR = 0,

		/// <summary>
		/// MODEL_DXT2/3/MODEL_BC2 
		/// </summary>
		KHR_DF_CHANNEL_DXT2_ALPHA = 15,

		/// <summary>
		/// MODEL_DXT2/3/MODEL_BC2 
		/// </summary>
		KHR_DF_CHANNEL_DXT3_ALPHA = 15,

		/// <summary>
		/// MODEL_DXT2/3/MODEL_BC2 
		/// </summary>
		KHR_DF_CHANNEL_BC2_ALPHA = 15,

		/// <summary>
		/// MODEL_DXT4/5/MODEL_BC3 
		/// </summary>
		KHR_DF_CHANNEL_DXT4_COLOR = 0,

		/// <summary>
		/// MODEL_DXT4/5/MODEL_BC3 
		/// </summary>
		KHR_DF_CHANNEL_DXT5_COLOR = 0,

		/// <summary>
		/// MODEL_DXT4/5/MODEL_BC3 
		/// </summary>
		KHR_DF_CHANNEL_BC3_COLOR = 0,

		/// <summary>
		/// MODEL_DXT4/5/MODEL_BC3 
		/// </summary>
		KHR_DF_CHANNEL_DXT4_ALPHA = 15,

		/// <summary>
		/// MODEL_DXT4/5/MODEL_BC3 
		/// </summary>
		KHR_DF_CHANNEL_DXT5_ALPHA = 15,

		/// <summary>
		/// MODEL_DXT4/5/MODEL_BC3 
		/// </summary>
		KHR_DF_CHANNEL_BC3_ALPHA = 15,

		/// <summary>
		/// MODEL_BC4 
		/// </summary>
		KHR_DF_CHANNEL_BC4_DATA = 0,

		/// <summary>
		/// MODEL_BC5 
		/// </summary>
		KHR_DF_CHANNEL_BC5_RED = 0,

		/// <summary>
		/// MODEL_BC5 
		/// </summary>
		KHR_DF_CHANNEL_BC5_R = 0,

		/// <summary>
		/// MODEL_BC5 
		/// </summary>
		KHR_DF_CHANNEL_BC5_GREEN = 1,

		/// <summary>
		/// MODEL_BC5 
		/// </summary>
		KHR_DF_CHANNEL_BC5_G = 1,

		/// <summary>
		/// MODEL_BC6H 
		/// </summary>
		KHR_DF_CHANNEL_BC6H_COLOR = 0,

		/// <summary>
		/// MODEL_BC6H 
		/// </summary>
		KHR_DF_CHANNEL_BC6H_DATA = 0,

		/// <summary>
		/// MODEL_BC7 
		/// </summary>
		KHR_DF_CHANNEL_BC7_DATA = 0,

		/// <summary>
		/// MODEL_BC7 
		/// </summary>
		KHR_DF_CHANNEL_BC7_COLOR = 0,

		/// <summary>
		/// MODEL_ETC1 
		/// </summary>
		KHR_DF_CHANNEL_ETC1_DATA = 0,

		/// <summary>
		/// MODEL_ETC1 
		/// </summary>
		KHR_DF_CHANNEL_ETC1_COLOR = 0,

		/// <summary>
		/// MODEL_ETC2 
		/// </summary>
		KHR_DF_CHANNEL_ETC2_RED = 0,

		/// <summary>
		/// MODEL_ETC2 
		/// </summary>
		KHR_DF_CHANNEL_ETC2_R = 0,

		/// <summary>
		/// MODEL_ETC2 
		/// </summary>
		KHR_DF_CHANNEL_ETC2_GREEN = 1,

		/// <summary>
		/// MODEL_ETC2 
		/// </summary>
		KHR_DF_CHANNEL_ETC2_G = 1,

		/// <summary>
		/// MODEL_ETC2 
		/// </summary>
		KHR_DF_CHANNEL_ETC2_COLOR = 2,

		/// <summary>
		/// MODEL_ETC2 
		/// </summary>
		KHR_DF_CHANNEL_ETC2_ALPHA = 15,

		/// <summary>
		/// MODEL_ETC2 
		/// </summary>
		KHR_DF_CHANNEL_ETC2_A = 15,

		/// <summary>
		/// MODEL_ASTC 
		/// </summary>
		KHR_DF_CHANNEL_ASTC_DATA = 0,

		/// <summary>
		/// MODEL_ETC1S 
		/// </summary>
		KHR_DF_CHANNEL_ETC1S_RGB = 0,

		/// <summary>
		/// MODEL_ETC1S 
		/// </summary>
		KHR_DF_CHANNEL_ETC1S_RRR = 3,

		/// <summary>
		/// MODEL_ETC1S 
		/// </summary>
		KHR_DF_CHANNEL_ETC1S_GGG = 4,

		/// <summary>
		/// MODEL_ETC1S 
		/// </summary>
		KHR_DF_CHANNEL_ETC1S_AAA = 15,

		/// <summary>
		/// MODEL_PVRTC 
		/// </summary>
		KHR_DF_CHANNEL_PVRTC_DATA = 0,

		/// <summary>
		/// MODEL_PVRTC 
		/// </summary>
		KHR_DF_CHANNEL_PVRTC_COLOR = 0,

		/// <summary>
		/// MODEL_PVRTC2 
		/// </summary>
		KHR_DF_CHANNEL_PVRTC2_DATA = 0,

		/// <summary>
		/// MODEL_PVRTC2 
		/// </summary>
		KHR_DF_CHANNEL_PVRTC2_COLOR = 0,

		/// <summary>
		/// MODEL UASTC 
		/// </summary>
		KHR_DF_CHANNEL_UASTC_RGB = 0,

		/// <summary>
		/// MODEL UASTC 
		/// </summary>
		KHR_DF_CHANNEL_UASTC_RGBA = 3,

		/// <summary>
		/// MODEL UASTC 
		/// </summary>
		KHR_DF_CHANNEL_UASTC_RRR = 4,

		/// <summary>
		/// MODEL UASTC 
		/// </summary>
		KHR_DF_CHANNEL_UASTC_RRRG = 5,

		/// <summary>
		/// MODEL UASTC 
		/// </summary>
		KHR_DF_CHANNEL_UASTC_RG = 6,

		/// <summary>
		/// Common channel names shared by multiple formats 
		/// </summary>
		KHR_DF_CHANNEL_COMMON_LUMA = 0,

		/// <summary>
		/// Common channel names shared by multiple formats 
		/// </summary>
		KHR_DF_CHANNEL_COMMON_L = 0,

		/// <summary>
		/// Common channel names shared by multiple formats 
		/// </summary>
		KHR_DF_CHANNEL_COMMON_STENCIL = 13,

		/// <summary>
		/// Common channel names shared by multiple formats 
		/// </summary>
		KHR_DF_CHANNEL_COMMON_S = 13,

		/// <summary>
		/// Common channel names shared by multiple formats 
		/// </summary>
		KHR_DF_CHANNEL_COMMON_DEPTH = 14,

		/// <summary>
		/// Common channel names shared by multiple formats 
		/// </summary>
		KHR_DF_CHANNEL_COMMON_D = 14,

		/// <summary>
		/// Common channel names shared by multiple formats 
		/// </summary>
		KHR_DF_CHANNEL_COMMON_ALPHA = 15,

		/// <summary>
		/// Common channel names shared by multiple formats 
		/// </summary>
		KHR_DF_CHANNEL_COMMON_A = 15,
	}

	/// <summary>
	/// Definition of the primary colors in color coordinates.
	/// This is implicitly responsible for defining the conversion
	/// between RGB an YUV color spaces.
	/// LAB and related absolute color models should use
	/// KHR_DF_PRIMARIES_CIEXYZ. 
	/// </summary>
	public enum khr_df_primaries_e
	{

		/// <summary>
		/// No color primaries defined 
		/// </summary>
		KHR_DF_PRIMARIES_UNSPECIFIED = 0,

		/// <summary>
		/// Color primaries of ITU-R BT.709 and sRGB 
		/// </summary>
		KHR_DF_PRIMARIES_BT709 = 1,

		/// <summary>
		/// Synonym for KHR_DF_PRIMARIES_BT709 
		/// </summary>
		KHR_DF_PRIMARIES_SRGB = 1,

		/// <summary>
		/// Color primaries of ITU-R BT.601 (625-line EBU variant) 
		/// </summary>
		KHR_DF_PRIMARIES_BT601_EBU = 2,

		/// <summary>
		/// Color primaries of ITU-R BT.601 (525-line SMPTE C variant) 
		/// </summary>
		KHR_DF_PRIMARIES_BT601_SMPTE = 3,

		/// <summary>
		/// Color primaries of ITU-R BT.2020 
		/// </summary>
		KHR_DF_PRIMARIES_BT2020 = 4,

		/// <summary>
		/// ITU-R BT.2100 uses the same primaries as BT.2020 
		/// </summary>
		KHR_DF_PRIMARIES_BT2100 = 4,

		/// <summary>
		/// CIE theoretical color coordinate space 
		/// </summary>
		KHR_DF_PRIMARIES_CIEXYZ = 5,

		/// <summary>
		/// Academy Color Encoding System primaries 
		/// </summary>
		KHR_DF_PRIMARIES_ACES = 6,

		/// <summary>
		/// Color primaries of ACEScc 
		/// </summary>
		KHR_DF_PRIMARIES_ACESCC = 7,

		/// <summary>
		/// Legacy NTSC 1953 primaries 
		/// </summary>
		KHR_DF_PRIMARIES_NTSC1953 = 8,

		/// <summary>
		/// Legacy PAL 525-line primaries 
		/// </summary>
		KHR_DF_PRIMARIES_PAL525 = 9,

		/// <summary>
		/// Color primaries of Display P3 
		/// </summary>
		KHR_DF_PRIMARIES_DISPLAYP3 = 10,

		/// <summary>
		/// Color primaries of Adobe RGB (1998) 
		/// </summary>
		KHR_DF_PRIMARIES_ADOBERGB = 11,

		/// <summary>
		/// Color primaries of Adobe RGB (1998) 
		/// </summary>
		KHR_DF_PRIMARIES_MAX = 255,
	}

	/// <summary>
	/// Definition of the optical to digital transfer function
	/// ("gamma correction"). Most transfer functions are not a pure
	/// power function and also include a linear element.
	/// LAB and related absolute color representations should use
	/// KHR_DF_TRANSFER_UNSPECIFIED.
	/// These encodings indicate that the representation has had
	/// the corresponding transfer function applied relative to a
	/// linear representation; hence to process the linear intensity
	/// represented by the value, a corresponding inverse transform
	/// must be applied. 
	/// </summary>
	public enum khr_df_transfer_e
	{

		/// <summary>
		/// No transfer function defined 
		/// </summary>
		KHR_DF_TRANSFER_UNSPECIFIED = 0,

		/// <summary>
		/// Linear transfer function (value proportional to intensity) 
		/// </summary>
		KHR_DF_TRANSFER_LINEAR = 1,

		/// <summary>
		/// Perceptually-linear transfer function of sRGB (~2.2); also used for scRGB 
		/// </summary>
		KHR_DF_TRANSFER_SRGB = 2,

		/// <summary>
		/// Perceptually-linear transfer function of sRGB (~2.2); also used for scRGB 
		/// </summary>
		KHR_DF_TRANSFER_SRGB_EOTF = 2,

		/// <summary>
		/// Perceptually-linear transfer function of sRGB (~2.2); also used for scRGB 
		/// </summary>
		KHR_DF_TRANSFER_SCRGB = 2,

		/// <summary>
		/// Perceptually-linear transfer function of sRGB (~2.2); also used for scRGB 
		/// </summary>
		KHR_DF_TRANSFER_SCRGB_EOTF = 2,

		/// <summary>
		/// Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45) 
		/// </summary>
		KHR_DF_TRANSFER_ITU = 3,

		/// <summary>
		/// Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45) 
		/// </summary>
		KHR_DF_TRANSFER_ITU_OETF = 3,

		/// <summary>
		/// Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45) 
		/// </summary>
		KHR_DF_TRANSFER_BT601 = 3,

		/// <summary>
		/// Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45) 
		/// </summary>
		KHR_DF_TRANSFER_BT601_OETF = 3,

		/// <summary>
		/// Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45) 
		/// </summary>
		KHR_DF_TRANSFER_BT709 = 3,

		/// <summary>
		/// Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45) 
		/// </summary>
		KHR_DF_TRANSFER_BT709_OETF = 3,

		/// <summary>
		/// Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45) 
		/// </summary>
		KHR_DF_TRANSFER_BT2020 = 3,

		/// <summary>
		/// Perceptually-linear transfer function of ITU BT.601, BT.709 and BT.2020 (~1/.45) 
		/// </summary>
		KHR_DF_TRANSFER_BT2020_OETF = 3,

		/// <summary>
		/// SMTPE170M (digital NTSC) defines an alias for the ITU transfer function (~1/.45) and a linear OOTF 
		/// </summary>
		KHR_DF_TRANSFER_SMTPE170M = 3,

		/// <summary>
		/// SMTPE170M (digital NTSC) defines an alias for the ITU transfer function (~1/.45) and a linear OOTF 
		/// </summary>
		KHR_DF_TRANSFER_SMTPE170M_OETF = 3,

		/// <summary>
		/// SMTPE170M (digital NTSC) defines an alias for the ITU transfer function (~1/.45) and a linear OOTF 
		/// </summary>
		KHR_DF_TRANSFER_SMTPE170M_EOTF = 3,

		/// <summary>
		/// Perceptually-linear gamma function of original NTSC (simple 2.2 gamma) 
		/// </summary>
		KHR_DF_TRANSFER_NTSC = 4,

		/// <summary>
		/// Perceptually-linear gamma function of original NTSC (simple 2.2 gamma) 
		/// </summary>
		KHR_DF_TRANSFER_NTSC_EOTF = 4,

		/// <summary>
		/// Sony S-log used by Sony video cameras 
		/// </summary>
		KHR_DF_TRANSFER_SLOG = 5,

		/// <summary>
		/// Sony S-log used by Sony video cameras 
		/// </summary>
		KHR_DF_TRANSFER_SLOG_OETF = 5,

		/// <summary>
		/// Sony S-log 2 used by Sony video cameras 
		/// </summary>
		KHR_DF_TRANSFER_SLOG2 = 6,

		/// <summary>
		/// Sony S-log 2 used by Sony video cameras 
		/// </summary>
		KHR_DF_TRANSFER_SLOG2_OETF = 6,

		/// <summary>
		/// ITU BT.1886 EOTF 
		/// </summary>
		KHR_DF_TRANSFER_BT1886 = 7,

		/// <summary>
		/// ITU BT.1886 EOTF 
		/// </summary>
		KHR_DF_TRANSFER_BT1886_EOTF = 7,

		/// <summary>
		/// ITU BT.2100 HLG OETF (typical scene-referred content), linear light normalized 0..1 
		/// </summary>
		KHR_DF_TRANSFER_HLG_OETF = 8,

		/// <summary>
		/// ITU BT.2100 HLG EOTF (nominal HDR display of HLG content), linear light normalized 0..1 
		/// </summary>
		KHR_DF_TRANSFER_HLG_EOTF = 9,

		/// <summary>
		/// ITU BT.2100 PQ EOTF (typical HDR display-referred PQ content) 
		/// </summary>
		KHR_DF_TRANSFER_PQ_EOTF = 10,

		/// <summary>
		/// ITU BT.2100 PQ OETF (nominal scene described by PQ HDR content) 
		/// </summary>
		KHR_DF_TRANSFER_PQ_OETF = 11,

		/// <summary>
		/// DCI P3 transfer function 
		/// </summary>
		KHR_DF_TRANSFER_DCIP3 = 12,

		/// <summary>
		/// DCI P3 transfer function 
		/// </summary>
		KHR_DF_TRANSFER_DCIP3_EOTF = 12,

		/// <summary>
		/// Legacy PAL OETF 
		/// </summary>
		KHR_DF_TRANSFER_PAL_OETF = 13,

		/// <summary>
		/// Legacy PAL 625-line EOTF 
		/// </summary>
		KHR_DF_TRANSFER_PAL625_EOTF = 14,

		/// <summary>
		/// Legacy ST240 transfer function 
		/// </summary>
		KHR_DF_TRANSFER_ST240 = 15,

		/// <summary>
		/// Legacy ST240 transfer function 
		/// </summary>
		KHR_DF_TRANSFER_ST240_OETF = 15,

		/// <summary>
		/// Legacy ST240 transfer function 
		/// </summary>
		KHR_DF_TRANSFER_ST240_EOTF = 15,

		/// <summary>
		/// ACEScc transfer function 
		/// </summary>
		KHR_DF_TRANSFER_ACESCC = 16,

		/// <summary>
		/// ACEScc transfer function 
		/// </summary>
		KHR_DF_TRANSFER_ACESCC_OETF = 16,

		/// <summary>
		/// ACEScct transfer function 
		/// </summary>
		KHR_DF_TRANSFER_ACESCCT = 17,

		/// <summary>
		/// ACEScct transfer function 
		/// </summary>
		KHR_DF_TRANSFER_ACESCCT_OETF = 17,

		/// <summary>
		/// Adobe RGB (1998) transfer function 
		/// </summary>
		KHR_DF_TRANSFER_ADOBERGB = 18,

		/// <summary>
		/// Adobe RGB (1998) transfer function 
		/// </summary>
		KHR_DF_TRANSFER_ADOBERGB_EOTF = 18,

		/// <summary>
		/// Legacy ITU BT.2100 HLG OETF (typical scene-referred content), linear light normalized 0..12 
		/// </summary>
		KHR_DF_TRANSFER_HLG_UNNORMALIZED_OETF = 19,

		/// <summary>
		/// Legacy ITU BT.2100 HLG OETF (typical scene-referred content), linear light normalized 0..12 
		/// </summary>
		KHR_DF_TRANSFER_MAX = 255,
	}

	public enum khr_df_flags_e
	{
		KHR_DF_FLAG_ALPHA_STRAIGHT = 0,
		KHR_DF_FLAG_ALPHA_PREMULTIPLIED = 1,
	}

	public enum khr_df_sample_datatype_qualifiers_e
	{
		KHR_DF_SAMPLE_DATATYPE_LINEAR = 16,
		KHR_DF_SAMPLE_DATATYPE_EXPONENT = 32,
		KHR_DF_SAMPLE_DATATYPE_SIGNED = 64,
		KHR_DF_SAMPLE_DATATYPE_FLOAT = 128,
	}

	/// <summary>
	/// 
	/// @
	/// ~English
	/// 
	/// </summary>
	public enum ktx_error_code_e
	{

		/// <summary>
		/// Operation was successful. 
		/// </summary>
		KTX_SUCCESS = 0,

		/// <summary>
		/// The data in the file is inconsistent with the spec. 
		/// </summary>
		KTX_FILE_DATA_ERROR = 1,

		/// <summary>
		/// The file is a pipe or named pipe. 
		/// </summary>
		KTX_FILE_ISPIPE = 2,

		/// <summary>
		/// The target file could not be opened. 
		/// </summary>
		KTX_FILE_OPEN_FAILED = 3,

		/// <summary>
		/// The operation would exceed the max file size. 
		/// </summary>
		KTX_FILE_OVERFLOW = 4,

		/// <summary>
		/// An error occurred while reading from the file. 
		/// </summary>
		KTX_FILE_READ_ERROR = 5,

		/// <summary>
		/// An error occurred while seeking in the file. 
		/// </summary>
		KTX_FILE_SEEK_ERROR = 6,

		/// <summary>
		/// File does not have enough data to satisfy request. 
		/// </summary>
		KTX_FILE_UNEXPECTED_EOF = 7,

		/// <summary>
		/// An error occurred while writing to the file. 
		/// </summary>
		KTX_FILE_WRITE_ERROR = 8,

		/// <summary>
		/// GL operations resulted in an error. 
		/// </summary>
		KTX_GL_ERROR = 9,

		/// <summary>
		/// The operation is not allowed in the current state. 
		/// </summary>
		KTX_INVALID_OPERATION = 10,

		/// <summary>
		/// A parameter value was not valid. 
		/// </summary>
		KTX_INVALID_VALUE = 11,

		/// <summary>
		/// Requested metadata key or required dynamically loaded GPU function was not found. 
		/// </summary>
		KTX_NOT_FOUND = 12,

		/// <summary>
		/// Not enough memory to complete the operation. 
		/// </summary>
		KTX_OUT_OF_MEMORY = 13,

		/// <summary>
		/// Transcoding of block compressed texture failed. 
		/// </summary>
		KTX_TRANSCODE_FAILED = 14,

		/// <summary>
		/// The file not a KTX file 
		/// </summary>
		KTX_UNKNOWN_FILE_FORMAT = 15,

		/// <summary>
		/// The KTX file specifies an unsupported texture type. 
		/// </summary>
		KTX_UNSUPPORTED_TEXTURE_TYPE = 16,

		/// <summary>
		/// Feature not included in in-use library or not yet implemented. 
		/// </summary>
		KTX_UNSUPPORTED_FEATURE = 17,

		/// <summary>
		/// Library dependency (OpenGL or Vulkan) not linked into application. 
		/// </summary>
		KTX_LIBRARY_NOT_LINKED = 18,

		/// <summary>
		/// Decompressed byte count does not match expected byte size 
		/// </summary>
		KTX_DECOMPRESS_LENGTH_ERROR = 19,

		/// <summary>
		/// Checksum mismatch when decompressing 
		/// </summary>
		KTX_DECOMPRESS_CHECKSUM_ERROR = 20,

		/// <summary>
		/// For safety checks. 
		/// </summary>
		KTX_ERROR_MAX_ENUM = 20,
	}

	public enum streamType
	{
		eStreamTypeFile = 1,
		eStreamTypeMemory = 2,
		eStreamTypeCustom = 3,
	}

	public enum ktxOrientationX
	{
		KTX_ORIENT_X_LEFT = 108,
		KTX_ORIENT_X_RIGHT = 114,
	}

	public enum ktxOrientationY
	{
		KTX_ORIENT_Y_UP = 117,
		KTX_ORIENT_Y_DOWN = 100,
	}

	public enum ktxOrientationZ
	{
		KTX_ORIENT_Z_IN = 105,
		KTX_ORIENT_Z_OUT = 111,
	}

	public enum class_id
	{
		ktxTexture1_c = 1,
		ktxTexture2_c = 2,
	}

	/// <summary>
	/// 
	/// @
	/// ~English
	/// 
	/// </summary>
	public enum ktxSupercmpScheme
	{

		/// <summary>
		/// No supercompression. 
		/// </summary>
		KTX_SS_NONE = 0,

		/// <summary>
		/// Basis LZ supercompression. 
		/// </summary>
		KTX_SS_BASIS_LZ = 1,

		/// <summary>
		/// ZStd supercompression. 
		/// </summary>
		KTX_SS_ZSTD = 2,

		/// <summary>
		/// ZLIB supercompression. 
		/// </summary>
		KTX_SS_ZLIB = 3,
		KTX_SS_BEGIN_RANGE = 0,
		KTX_SS_END_RANGE = 3,
		KTX_SS_BEGIN_VENDOR_RANGE = 65536,
		KTX_SS_END_VENDOR_RANGE = 131071,
		KTX_SS_BEGIN_RESERVED = 131072,
	}

	/// <summary>
	/// 
	/// 
	/// @
	/// ~English
	/// 
	/// 
	/// </summary>
	public enum ktxTextureCreateStorageEnum
	{

		/// <summary>
		/// Don't allocate any image storage. 
		/// </summary>
		KTX_TEXTURE_CREATE_NO_STORAGE = 0,

		/// <summary>
		/// Allocate image storage. 
		/// </summary>
		KTX_TEXTURE_CREATE_ALLOC_STORAGE = 1,
	}

	/// <summary>
	/// 
	/// 
	/// @
	/// ~English
	/// 
	/// 
	/// </summary>
	public enum ktxTextureCreateFlagBits
	{
		KTX_TEXTURE_CREATE_NO_FLAGS = 0,
		KTX_TEXTURE_CREATE_LOAD_IMAGE_DATA_BIT = 1,
		KTX_TEXTURE_CREATE_RAW_KVDATA_BIT = 2,
		KTX_TEXTURE_CREATE_SKIP_KVDATA_BIT = 4,
		KTX_TEXTURE_CREATE_CHECK_GLTF_BASISU_BIT = 8,
	}

	/// <summary>
	/// 
	/// @
	/// ~English
	/// 
	/// </summary>
	public enum ktx_pack_uastc_flag_bits_e
	{
		KTX_PACK_UASTC_LEVEL_FASTEST = 0,
		KTX_PACK_UASTC_LEVEL_FASTER = 1,
		KTX_PACK_UASTC_LEVEL_DEFAULT = 2,
		KTX_PACK_UASTC_LEVEL_SLOWER = 3,
		KTX_PACK_UASTC_LEVEL_VERYSLOW = 4,
		KTX_PACK_UASTC_MAX_LEVEL = 4,
		KTX_PACK_UASTC_LEVEL_MASK = 15,
		KTX_PACK_UASTC_FAVOR_UASTC_ERROR = 8,
		KTX_PACK_UASTC_FAVOR_BC7_ERROR = 16,
		KTX_PACK_UASTC_ETC1_FASTER_HINTS = 64,
		KTX_PACK_UASTC_ETC1_FASTEST_HINTS = 128,
		KTX_PACK_UASTC__ETC1_DISABLE_FLIP_AND_INDIVIDUAL = 256,
	}

	/// <summary>
	/// 
	/// @
	/// ~English
	/// 
	/// </summary>
	public enum ktx_pack_astc_quality_levels_e
	{
		KTX_PACK_ASTC_QUALITY_LEVEL_FASTEST = 0,
		KTX_PACK_ASTC_QUALITY_LEVEL_FAST = 10,
		KTX_PACK_ASTC_QUALITY_LEVEL_MEDIUM = 60,
		KTX_PACK_ASTC_QUALITY_LEVEL_THOROUGH = 98,
		KTX_PACK_ASTC_QUALITY_LEVEL_EXHAUSTIVE = 100,
		KTX_PACK_ASTC_QUALITY_LEVEL_MAX = 100,
	}

	/// <summary>
	/// 
	/// @
	/// ~English
	/// 
	/// </summary>
	public enum ktx_pack_astc_block_dimension_e
	{

		/// <summary>
		/// : 8.00 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_4x4 = 0,

		/// <summary>
		/// : 6.40 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_5x4 = 1,

		/// <summary>
		/// : 5.12 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_5x5 = 2,

		/// <summary>
		/// : 4.27 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_6x5 = 3,

		/// <summary>
		/// : 3.56 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_6x6 = 4,

		/// <summary>
		/// : 3.20 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_8x5 = 5,

		/// <summary>
		/// : 2.67 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_8x6 = 6,

		/// <summary>
		/// : 2.56 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_10x5 = 7,

		/// <summary>
		/// : 2.13 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_10x6 = 8,

		/// <summary>
		/// : 2.00 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_8x8 = 9,

		/// <summary>
		/// : 1.60 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_10x8 = 10,

		/// <summary>
		/// : 1.28 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_10x10 = 11,

		/// <summary>
		/// : 1.07 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_12x10 = 12,

		/// <summary>
		/// : 0.89 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_12x12 = 13,

		/// <summary>
		/// : 4.74 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_3x3x3 = 14,

		/// <summary>
		/// : 3.56 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_4x3x3 = 15,

		/// <summary>
		/// : 2.67 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_4x4x3 = 16,

		/// <summary>
		/// : 2.00 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_4x4x4 = 17,

		/// <summary>
		/// : 1.60 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_5x4x4 = 18,

		/// <summary>
		/// : 1.28 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_5x5x4 = 19,

		/// <summary>
		/// : 1.02 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_5x5x5 = 20,

		/// <summary>
		/// : 0.85 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_6x5x5 = 21,

		/// <summary>
		/// : 0.71 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_6x6x5 = 22,

		/// <summary>
		/// : 0.59 bpp
		/// </summary>
		KTX_PACK_ASTC_BLOCK_DIMENSION_6x6x6 = 23,
		KTX_PACK_ASTC_BLOCK_DIMENSION_MAX = 23,
	}

	/// <summary>
	/// 
	/// @
	/// ~English
	/// 
	/// </summary>
	public enum ktx_pack_astc_encoder_mode_e
	{
		KTX_PACK_ASTC_ENCODER_MODE_DEFAULT = 0,
		KTX_PACK_ASTC_ENCODER_MODE_LDR = 1,
		KTX_PACK_ASTC_ENCODER_MODE_HDR = 2,
		KTX_PACK_ASTC_ENCODER_MODE_MAX = 2,
	}

	/// <summary>
	/// 
	/// @
	/// ~English
	/// 
	/// For BasisU/ETC1S format, 
	/// and 
	/// here refer to 2 separate
	/// RGB images, a.k.a slices within the BasisU compressed data. For UASTC
	/// format they refer to the RGB and the alpha components of the UASTC data. If
	/// the original image had only 2 components, R will be in the opaque portion
	/// and G in the alpha portion. The R value will be replicated in the RGB
	/// components. In the case of BasisU the G value will be replicated in all 3
	/// components of the alpha slice. If the original image had only 1 component
	/// it's value is replicated in all 3 components of the opaque portion and
	/// there is no alpha.
	/// 
	/// </summary>
	public enum ktx_transcode_fmt_e
	{

		/// <summary>
		/// ETC1-2
		/// </summary>
		KTX_TTF_ETC1_RGB = 0,
		KTX_TTF_ETC2_RGBA = 1,

		/// <summary>
		/// BC1-5, BC7 (desktop, some mobile devices)
		/// </summary>
		KTX_TTF_BC1_RGB = 2,
		KTX_TTF_BC3_RGBA = 3,
		KTX_TTF_BC4_R = 4,
		KTX_TTF_BC5_RG = 5,
		KTX_TTF_BC7_RGBA = 6,

		/// <summary>
		/// PVRTC1 4bpp (mobile, PowerVR devices)
		/// </summary>
		KTX_TTF_PVRTC1_4_RGB = 8,
		KTX_TTF_PVRTC1_4_RGBA = 9,

		/// <summary>
		/// ASTC (mobile, Intel devices, hopefully all desktop GPU's one day)
		/// </summary>
		KTX_TTF_ASTC_4x4_RGBA = 10,

		/// <summary>
		/// ATC and FXT1 formats are not supported by KTX2 as there
		/// are no equivalent VkFormats.
		/// </summary>
		KTX_TTF_PVRTC2_4_RGB = 18,
		KTX_TTF_PVRTC2_4_RGBA = 19,
		KTX_TTF_ETC2_EAC_R11 = 20,
		KTX_TTF_ETC2_EAC_RG11 = 21,

		/// <summary>
		/// Uncompressed (raw pixel) formats
		/// </summary>
		KTX_TTF_RGBA32 = 13,
		KTX_TTF_RGB565 = 14,
		KTX_TTF_BGR565 = 15,
		KTX_TTF_RGBA4444 = 16,

		/// <summary>
		/// Values for automatic selection of RGB or RGBA depending if alpha
		/// present.
		/// </summary>
		KTX_TTF_ETC = 22,
		KTX_TTF_BC1_OR_3 = 23,
		KTX_TTF_NOSELECTION = 2147483647,

		/// <summary>
		/// Old enums for compatibility with code compiled against previous
		/// versions of libktx.
		/// </summary>
		KTX_TF_ETC1 = 0,
		KTX_TF_ETC2 = 22,
		KTX_TF_BC1 = 2,
		KTX_TF_BC3 = 3,
		KTX_TF_BC4 = 4,
		KTX_TF_BC5 = 5,
		KTX_TTF_BC7_M6_RGB = 6,
		KTX_TTF_BC7_M5_RGBA = 6,
		KTX_TF_BC7_M6_OPAQUE_ONLY = 6,
		KTX_TF_PVRTC1_4_OPAQUE_ONLY = 8,
	}

	/// <summary>
	/// 
	/// @
	/// ~English
	/// 
	/// </summary>
	public enum ktx_transcode_flag_bits_e
	{
		KTX_TF_PVRTC_DECODE_TO_NEXT_POW2 = 2,
		KTX_TF_TRANSCODE_ALPHA_DATA_TO_OPAQUE_FORMATS = 4,
		KTX_TF_HIGH_QUALITY = 32,
	}

}
