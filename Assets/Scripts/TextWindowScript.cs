using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWindowScript : MonoBehaviour
{
    public RectTransform content;
    Text textComponent;

    void Start()
    {
        textComponent = content.transform.Find("Text").GetComponent<Text>();
        textComponent.text = "";

        DisplaySystemInfo();
    }

    void Update()
    {    
	}

    void Append(string str)
    {
        textComponent.text += str;
    }

    void DisplaySystemInfo()
    {
        Display(" Device model        : ", SystemInfo.deviceModel);
        Display(" Device name         : ", SystemInfo.deviceName);
        Display(" Device type         : ", SystemInfo.deviceType.ToString());
        Display(" Device name         : ", SystemInfo.graphicsDeviceName);
        Display(" Device type         : ", SystemInfo.graphicsDeviceType.ToString());
        Display(" Device vendor       : ", SystemInfo.graphicsDeviceVendor);
        Display(" Device version      : ", SystemInfo.graphicsDeviceVersion);
        Display(" Shader level        : ", SystemInfo.graphicsShaderLevel);
        Display(" UV starts at top    : ", SystemInfo.graphicsUVStartsAtTop);
        Display(" Max texture size    : ", SystemInfo.maxTextureSize);
        Display(" OS                  : ", SystemInfo.operatingSystem);
        Display(" OS family           : ", SystemInfo.operatingSystemFamily.ToString());
        Display(" Processor count     : ", SystemInfo.processorCount);
        Display(" Processor Type      : ", SystemInfo.processorType);
        Display(" Render target count : ", SystemInfo.supportedRenderTargetCount);
        Display(" 2D array textures   : ", SystemInfo.supports2DArrayTextures);
        Display(" 3D render textures  : ", SystemInfo.supports3DRenderTextures);
        Display(" 3D textures         : ", SystemInfo.supports3DTextures);
        Display(" Compute shaders     : ", SystemInfo.supportsComputeShaders);
    }

    void Display(string str, bool val)
    {
        Append(str + (val ? "Yes" : "No") + "\n");
    }

    void Display(string str, string val)
    {
        Append(str + val + "\n");
    }

    void Display(string str, int val)
    {
        Append(str + val + "\n");
    }
}
