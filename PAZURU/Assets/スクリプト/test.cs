using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    WebCamTexture webCamTexture;
    public RawImage rawImage;
    public RawImage[] raw;

    // Start is called before the first frame update
    void Start()
    {
        webCamTexture = new WebCamTexture(800, 800);
        rawImage.texture = webCamTexture;
        for(int i = 0; i < 9; i++)
        {
            raw[i].texture = rawImage.texture;
        }
        webCamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
