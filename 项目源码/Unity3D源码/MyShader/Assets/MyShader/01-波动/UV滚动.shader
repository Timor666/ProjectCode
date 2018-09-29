Shader "Timor/01/UV滚动"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_Speed ("速度",Range(-10,20)) =1
	}
	SubShader
	{
		// No culling or depth
	//	Cull Off ZWrite Off ZTest Always

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			float _Speed;

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
				float2 uv = i.uv;
				uv.x += _Time.x * _Speed;
				//uv.y += _Time.y;

				fixed4 col = tex2D(_MainTex, uv);
				// just invert the colors
				//col.rgb = 1 - col.rgb;
				return col;
			}
			ENDCG
		}
	}
}
