﻿// This is the output generated by the T4 template
namespace GLSLhelper
{
	using System.Collections.Generic;

	public static partial class GlslSpecification
	{
		private static Dictionary<string, TokenType> Initialize()
		{
			var keywords = "attribute const uniform varying buffer shared coherent volatile restrict readonly writeonly atomic_uint layout quads equal_spacing fractional_even_spacing fractional_odd_spacing cw ccw points centroid flat smooth noperspective patch sample break continue do for while switch case default if else subroutine in out inout float double int void bool true false invariant precise discard return lowp mediump highp precision mat2 mat3 mat4 dmat2 dmat3 dmat4 mat2x2 mat2x3 mat2x4 dmat2x2 dmat2x3 dmat2x4 mat3x2 mat3x3 mat3x4 dmat3x2 dmat3x3 dmat3x4 mat4x2 mat4x3 mat4x4 dmat4x2 dmat4x3 dmat4x4 vec2 vec3 vec4 ivec2 ivec3 ivec4 bvec2 bvec3 bvec4 dvec2 dvec3 dvec4 uint uvec2 uvec3 uvec4 int64_t i64vec2 i64vec3 i64vec4 uint64_t u64vec2 u64vec3 u64vec4 sampler1D sampler2D sampler3D samplerCube sampler1DShadow sampler2DShadow samplerCubeShadow sampler1DArray sampler2DArray sampler1DArrayShadow sampler2DArrayShadow isampler1D isampler2D isampler3D isamplerCube isampler1DArray isampler2DArray usampler1D usampler2D usampler3D usamplerCube usampler1DArray usampler2DArray sampler2DRect sampler2DRectShadow isampler2DRect usampler2DRect samplerBuffer isamplerBuffer usamplerBuffer sampler2DMS isampler2DMS usampler2DMS sampler2DMSArray isampler2DMSArray usampler2DMSArray samplerCubeArray samplerCubeArrayShadow isamplerCubeArray usamplerCubeArray image1D iimage1D uimage1D image2D iimage2D uimage2D image3D iimage3D uimage3D image2DRect iimage2DRect uimage2DRect imageCube iimageCube uimageCube imageBuffer iimageBuffer uimageBuffer image1DArray iimage1DArray uimage1DArray image2DArray iimage2DArray uimage2DArray imageCubeArray iimageCubeArray uimageCubeArray image2DMS iimage2DMS uimage2DMS image2DMSArray iimage2DMSArray uimage2DMSArray struct common partition active asm class union enum typedef template this resource goto inline noinline public static extern external interface long short half fixed unsigned superp input output hvec2 hvec3 hvec4 fvec2 fvec3 fvec4 sampler3DRect filter sizeof cast namespace using constant_id local_size_x_id local_size_y_id local_size_z_id local_size_variable input_attachment_index push_constant set binding sampler subpassInput subpassInputMS isubpassInput isubpassInputMS usubpassInput usubpassInputMS early_fragment_tests post_depth_coverage accelerationStructureNV rayPayloadNV rayPayloadInNV hitAttributeNV callableDataNV callableDataInNV".Split();
			var functions = "radians degrees sin cos tan asin acos atan sinh cosh tanh asinh acosh atanh pow exp log exp2 log2 sqrt inversesqrt abs sign floor trunc round roundEven ceil fract mod modf min max clamp mix step smoothstep isnan isinf floatBitsToInt floatBitsToUint intBitsToFloat uintBitsToFloat fma frexp ldexp packUnorm2x16 packSnorm2x16 packUnorm4x8 packSnorm4x8 unpackUnorm2x16 unpackSnorm2x16 unpackUnorm4x8 unpackSnorm4x8 packDouble2x32 unpackDouble2x32 packHalf2x16 unpackHalf2x16 length distance dot cross normalize ftransform faceforward reflect refract matrixCompMult outerProduct transpose determinant inverse lessThan lessThanEqual greaterThan greaterThanEqual equal notEqual any all not uaddCarry usubBorrow umulExtended imulExtended bitfieldExtract bitfieldInsert bitfieldReverse bitCount findLSB findMSB textureSize textureQueryLod textureQueryLevels textureSamples texture textureProj textureLod textureOffset texelFetch texelFetchOffset textureProjOffset textureLodOffset textureProjLod textureProjLodOffset textureGrad textureGradOffset textureProjGrad textureProjGradOffset textureGather textureGatherOffset textureGatherOffsets texture1D texture1DProj texture1DLod texture1DProjLod texture2D texture2DProj texture2DLod texture2DProjLod texture3D texture3DProj texture3DLod texture3DProjLod textureCube textureCubeLod shadow1D shadow2D shadow1DProj shadow2DProj shadow1DLod shadow2DLod shadow1DProjLod shadow2DProjLod atomicCounterIncrement atomicCounterDecrement atomicCounter atomicAdd atomicMin atomicMax atomicAnd atomicOr atomicXor atomicExchange atomicCompSwap imageSize imageSamples imageLoad imageStore imageAtomicAdd imageAtomicMin imageAtomicMax imageAtomicAnd imageAtomicOr imageAtomicXor imageAtomicExchange imageAtomicCompSwap dFdx dFdy dFdxFine dFdyFine dFdxCoarse dFdyCoarse fwidth fwidthFine fwidthCoarse interpolateAtCentroid interpolateAtSample interpolateAtOffset noise1 noise2 noise3 noise4 EmitStreamVertex EndStreamPrimitive EmitVertex EndPrimitive barrier memoryBarrier memoryBarrierAtomicCounter memoryBarrierBuffer memoryBarrierShared memoryBarrierImage groupMemoryBarrier subpassLoad ballotARB readInvocationARB readInvocationARB readInvocationARB readFirstInvocationARB readFirstInvocationARB readFirstInvocationARB atomicCounterAddARB atomicCounterSubtractARB atomicCounterMinARB atomicCounterMaxARB atomicCounterAndARB atomicCounterOrARB atomicCounterXorARB atomicCounterExchangeARB atomicCounterCompSwapARB anyInvocationARB allInvocationsARB allInvocationsEqualARB traceNV reportIntersectionNV ignoreIntersectionNV terminateRayNV executeCallableNV".Split();
			var variables = "gl_NumWorkGroups gl_WorkGroupSize gl_WorkGroupID gl_LocalInvocationID gl_GlobalInvocationID gl_LocalInvocationIndex gl_LocalGroupSizeARB gl_VertexID gl_VertexIndex gl_InstanceID gl_InstanceIndex gl_PerVertex gl_Position gl_PointSize gl_ClipDistance gl_CullDistance gl_in gl_out gl_PrimitiveIDIn gl_InvocationID gl_PrimitiveID gl_Layer gl_ViewportIndex gl_PatchVerticesIn gl_PrimitiveID gl_InvocationID gl_TessLevelOuter gl_TessLevelInner gl_PatchVerticesIn gl_PrimitiveID gl_TessCoord gl_MaxPatchVertices gl_FragColor gl_FragCoord gl_FrontFacing gl_ClipDistance gl_CullDistance gl_PointCoord gl_PrimitiveID gl_SampleID gl_SamplePosition gl_SampleMaskIn gl_Layer gl_ViewportIndex gl_HelperInvocation gl_FragDepth gl_SampleMask gl_DrawIDARB gl_BaseVertexARB gl_BaseInstanceARB gl_SubGroupSizeARB gl_SubGroupInvocationARB gl_SubGroupEqMaskARB gl_SubGroupGeMaskARB gl_SubGroupGtMaskARB gl_SubGroupLeMaskARB gl_SubGroupLtMaskARB gl_LaunchIDNV gl_LaunchSizeNV gl_InstanceCustomIndexNV gl_WorldRayOriginNV gl_WorldRayDirectionNV gl_ObjectRayOriginNV gl_ObjectRayDirectionNV gl_RayTminNV gl_RayTmaxNV gl_IncomingRayFlagsNV gl_HitTNV gl_HitKindNV gl_ObjectToWorldNV gl_WorldToObjectNV gl_RayFlagsNoneNV gl_RayFlagsOpaqueNV gl_RayFlagsNoOpaqueNV gl_RayFlagsTerminateOnFirstHitNV gl_RayFlagsSkipClosestHitShaderNV gl_RayFlagsCullBackFacingTrianglesNV gl_RayFlagsCullFrontFacingTrianglesNV gl_RayFlagsCullOpaqueNV gl_RayFlagsCullNoOpaqueNV".Split();
			var result = new Dictionary<string, TokenType>();
			result.AddRange(keywords, TokenType.Keyword);
			result.AddRange(functions, TokenType.Function);
			result.AddRange(variables, TokenType.Variable);
			return result;
		}
	}
}
