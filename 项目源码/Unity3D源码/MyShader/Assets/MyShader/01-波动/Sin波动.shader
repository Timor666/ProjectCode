Shader "Timor/01/sin波动"
{
	//属性块
	Properties
	{
		_Arange("高度",float) =1
		_Frenquacy("频率",float) =1
		_Speed("速度",float) =1
	}

	/*
	原理：通过改变顶点的坐标y，使用sin函数，和_Time.y
	*/
	SubShader
	{
		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float _Speed;
			float _Arange;
			float _Frenquacy;

			 

			struct appdata
			{
				float4 vertex : POSITION;	//使用模型空间顶点位置填充
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;	//裁剪坐标下位置
			};

			//顶点函数
			v2f vert (appdata v)
			{
				v2f o;
				float timer = _Time.y * _Speed;
				float waver = _Arange * sin(timer + v.vertex.x * _Frenquacy);
			
				v.vertex.y = v.vertex.y + waver;

				o.vertex = UnityObjectToClipPos(v.vertex);
				return o;
			}
			
			
			//片元函数
			fixed4 frag (v2f i) : SV_Target	//SV_Target输出值储存到渲染目标
			{
				return fixed4(0,1,0.5,0.5);	//返回绿色
			}
			ENDCG
		}
	}
}
