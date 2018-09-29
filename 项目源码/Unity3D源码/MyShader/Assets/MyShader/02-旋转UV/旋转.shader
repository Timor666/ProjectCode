Shader "Timor/02/旋转UILoading"
{
	Properties
	{
		_MainTex ("图片",2D) = "white" {}
		_Speed("旋转速度",Range(-50,300)) = 30
	}
	SubShader
	{
		 
		Blend SrcAlpha OneMinusSrcAlpha //开启alpha 混合
		Pass
		{
			CGPROGRAM
			float _Speed;
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
				//移动到原点
				float2 tempUV = i.uv;
				tempUV -= float2(0.5,0.5);	

				//舍弃对角线
				if(length(tempUV)>0.5){	
					return fixed4(0,0,0,0);
				}

				float2 finalUV =0;
				float angle = _Time.x * _Speed;
				
				//旋转
				finalUV.x = tempUV.x * cos(angle) - tempUV.y *sin(angle);	
				finalUV.y = tempUV.x * sin(angle) + tempUV.y * cos(angle);
				
				//移动回去
				finalUV += float2(0.5,0.5);
				fixed4 col = tex2D(_MainTex, finalUV);
			 
				return col;
			}
			ENDCG
		}
	}
}
