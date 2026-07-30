Shader "Custom/NoteTextureImageShader" {
	Properties {
		_BaseMap ("Texture", 2D) = "white" {}
		_BlendAlpha ("BlendAlpha", Float) = 0
		_BaseColor ("BaseColor", Vector) = (1,1,1,1)
		_Cutoff ("AlphaCutout", Range(0, 1)) = 0.5
		_Rotation ("Rotation", Float) = 0
		_Scale ("Scale", Float) = 1
		_Color ("Color", Vector) = (1,1,1,0.5)
		_Width ("Width", Float) = 0
		_Height ("Height", Float) = 0
		_CropLeft ("CropLeft", Float) = 0
		_CropRight ("CropRight", Float) = 0
		_CropTop ("CropTop", Float) = 0
		_CropBottom ("CropBottom", Float) = 0
		_Brightness ("Brightness", Range(-1, 1)) = 0
		_Contrast ("Contrast", Range(0, 2)) = 1
		_Hue ("Hue", Range(-360, 360)) = 0
		_Saturation ("Saturation", Range(0, 2)) = 1
		_PosLeftRight ("PosLeftRight", Float) = 0
		_PosTopBottom ("PosTopBottom", Float) = 0
		_TextureAspect ("TextureAspect", Float) = 1
		_StencilComp ("StencilComp", Float) = 0
		_Opacity ("Opacity", Float) = 1
		[HideInInspector] _Surface ("__surface", Float) = 0
		[HideInInspector] _Blend ("__blend", Float) = 0
		[HideInInspector] _AlphaClip ("__clip", Float) = 0
		_SrcBlend ("Src", Float) = 1
		_DstBlend ("Dst", Float) = 0
		[HideInInspector] _ZWrite ("ZWrite", Float) = 1
		[HideInInspector] _Cull ("__cull", Float) = 2
		[HideInInspector] _QueueOffset ("Queue offset", Float) = 0
		[HideInInspector] _MainTex ("BaseMap", 2D) = "white" {}
		[HideInInspector] _Color ("Base Color", Vector) = (0.5,0.5,0.5,1)
		[HideInInspector] _SampleGI ("SampleGI", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Universal Render Pipeline/FallbackError"
}