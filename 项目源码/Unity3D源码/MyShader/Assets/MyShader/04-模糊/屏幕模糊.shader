Shader "Timor/04/屏幕模糊"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_Smoothing("模糊度",Range(0,0.05)) = 0.01
	}
	SubShader
	{
		// No culling or depth
		Cull Off ZWrite Off ZTest Always

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}
			
			sampler2D _MainTex;

			float _Smoothing;	//平滑度

			fixed4 frag (v2f i) : SV_Target
			{
				float2 tempUV = i.uv;

				fixed4 col = tex2D(_MainTex, i.uv);
				 
				//取上下左右的像素，做平均值
				fixed4 col1 = tex2D(_MainTex,tempUV + float2(_Smoothing,0));
				fixed4 col2 = tex2D(_MainTex,tempUV + float2(- _Smoothing,0));
				fixed4 col3 = tex2D(_MainTex,tempUV + float2(0,_Smoothing));
				fixed4 col4 = tex2D(_MainTex,tempUV + float2(0,-_Smoothing));

				col = (col + col1 + col2 + col3 + col4)/5;
				return col;
			}
			ENDCG
		}
	}
}
