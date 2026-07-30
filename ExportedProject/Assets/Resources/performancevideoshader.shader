Shader "Custom/PerformanceVideoShader" {
	Properties {
		_BaseMap ("Texture", 2D) = "white" {}
		[PerRendererData] _Rotation ("Rotation", Float) = 0
		[PerRendererData] _Scale ("Scale", Float) = 1
		[PerRendererData] _Distortion ("Distortion", Float) = 0
		[PerRendererData] _BaseColor ("BaseColor", Vector) = (1,1,1,0.5)
		[PerRendererData] _Width ("Width", Float) = 0
		[PerRendererData] _Height ("Height", Float) = 0
		[PerRendererData] _CropLeft ("CropLeft", Float) = 0
		[PerRendererData] _CropRight ("CropRight", Float) = 0
		[PerRendererData] _CropTop ("CropTop", Float) = 0
		[PerRendererData] _CropBottom ("CropBottom", Float) = 0
		[PerRendererData] _Brightness ("Brightness", Range(-1, 1)) = 0
		[PerRendererData] _Contrast ("Contrast", Range(0, 2)) = 1
		[PerRendererData] _Hue ("Hue", Range(-360, 360)) = 0
		[PerRendererData] _Saturation ("Saturation", Range(0, 2)) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
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

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
}