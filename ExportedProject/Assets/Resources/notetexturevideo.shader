Shader "Custom/NoteTextureVideo" {
	Properties {
		_BaseMap ("Texture", 2D) = "white" {}
		_BlendAlpha ("BlendAlpha", Float) = 0
		_BaseColor ("Color", Vector) = (1,1,1,1)
		_Cutoff ("AlphaCutout", Range(0, 1)) = 0.5
		_Rotation ("Rotation", Float) = 0
		_Scale ("Scale", Float) = 1
		_Color ("Color", Vector) = (1,1,1,0.5)
		_Width ("Width", Float) = 0
		_Height ("Height", Float) = 0
		_Brightness ("Brightness", Range(-1, 1)) = 0
		_Contrast ("Contrast", Range(0, 2)) = 1
		_Hue ("Hue", Range(-360, 360)) = 0
		_Saturation ("Saturation", Range(0, 2)) = 1
		_PosLeftRight ("PosLeftRight", Float) = 0
		_PosTopBottom ("PosTopBottom", Float) = 0
		_TextureAspect ("TextureAspect", Float) = 1
		_StencilComp ("StencilComp", Float) = 1
		_Opacity ("Opacity", Float) = 1
		[HideInInspector] _Surface ("__surface", Float) = 0
		[HideInInspector] _Blend ("__blend", Float) = 0
		[HideInInspector] _AlphaClip ("__clip", Float) = 0
		_SrcBlend ("Src", Float) = 1
		_DstBlend ("Dst", Float) = 0
		[HideInInspector] _ZWrite ("ZWrite", Float) = 1
		[HideInInspector] _Cull ("__cull", Float) = 2
		[HideInInspector] _QueueOffset ("Queue offset", Float) = 0
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

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 _Color;

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return _Color; // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Universal Render Pipeline/FallbackError"
}