using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 相机模糊特效
/// </summary>
public class CameraVagueEffect : MonoBehaviour {

    public Material mat;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //函数系统调用,渲染顺序
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination,mat);
    }
}
