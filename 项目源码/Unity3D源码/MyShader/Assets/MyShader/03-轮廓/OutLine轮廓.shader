Shader "Hidden/OutLine轮廓"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_Length("轮廓倍数",Range(1,3)) = 1
		_OutLineColor("轮廓颜色",Color) = (0,0,0,1)
	}
	SubShader
	{
		// No culling or depth
 		//Cull Off ZWrite Off ZTest Always

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			sampler2D _MainTex;
			float _Length;	//再次声明
			fixed4 _OutLineColor;
			

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
				v.vertex.xy *= _Length; //放大
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}
			
			

			fixed4 frag (v2f i) : SV_Target
			{
				fixed4 col = tex2D(_MainTex, i.uv);
				// just invert the colors
			//	col.rgb = 1 - col.rgb;
				return _OutLineColor;
			}
			ENDCG
		}

		Pass
		{
			ZTest Always
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

			fixed4 frag (v2f i) : SV_Target
			{
				fixed4 col = tex2D(_MainTex, i.uv);
				// just invert the colors
				//col.rgb = 1 - col.rgb;
				return fixed4(0,1,0.5,1);
			}
			ENDCG
		}
	}
}
