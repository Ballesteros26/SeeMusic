Shader "Custom/SaberShaderAVPro" {
	Properties {
		[PerRendererData] _BaseMap ("Base (RGB)", 2D) = "black" {}
		[PerRendererData] _ColorMap ("Base (RGB)", 2D) = "black" {}
		_ChromaTex ("Chroma", 2D) = "gray" {}
		[PerRendererData] _Color ("Main Color", Vector) = (1,1,1,1)
		[PerRendererData] _Threshold ("Cutout threshold", Range(0, 1)) = 0.18
		[PerRendererData] _Softness ("Cutout softness", Range(0, 0.5)) = 0.2
		[PerRendererData] _BlendFactor ("Blend factor", Range(0, 1)) = 0.15
		[PerRendererData] _BaseColor ("Color", Vector) = (1,1,1,1)
		_Cutoff ("AlphaCutout", Range(0, 1)) = 0.5
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
}