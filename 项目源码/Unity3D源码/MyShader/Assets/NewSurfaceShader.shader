Shader "Custom/NewSurfaceShader" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
		_Value("值",int) =0
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200

		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows vertex:myvert

	//	#pragma surface surf Lambert vertex:myvert
		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

		sampler2D _MainTex;

		struct Input {
			float2 uv_MainTex;
		};
		void myvert(inout appdata_base v){
			v.vertex.xyz *= v.normal * _Value;
		}
		

		void surf ( Input IN, inout SurfaceOutput o){
			
			o.Albedo = tex2D(_MainTex,uv_MainTex).rgb;
			
		}

		 
		ENDCG
	}
	FallBack "Diffuse"
}
