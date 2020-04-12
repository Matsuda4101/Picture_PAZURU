﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Camera_satsuei_two : MonoBehaviour
{
    public RawImage rawImage;

    public Text memory;
    public Text count_down;

    float time = 0;
    int count = 0;
    bool pushFlag = false;

    public int wi = 800;
    public int he = 800;
    

    WebCamTexture webCamTexture;

    public GameObject PC;
    public GameObject OK;
    public GameObject TAKE;

    public RawImage RU;
    public RawImage RD;
    public RawImage LU;
    public RawImage LD;

    public RawImage ANS;

    public GameObject picture;
    public GameObject piece;
    public GameObject piece_set;
    public GameObject complete;
    public GameObject titlebutton;

    public GameObject timelimit;
    public GameObject answer;


    void Start()
    {
        PC.SetActive(false);
        OK.SetActive(false);
        TAKE.SetActive(true);

        piece_set.SetActive(false);
        complete.SetActive(false);

        piece.SetActive(false);
        titlebutton.SetActive(false);

        timelimit.SetActive(false);
        answer.SetActive(false);

        webCamTexture = new WebCamTexture(wi, he);
        rawImage.texture = webCamTexture;

        webCamTexture.Play();
    }

    void Update()
    {
        if (pushFlag == true)
        {
            timelimit.SetActive(true);
            time += Time.deltaTime;
            count = 10 - (int)time;

            if (count == -1)
            {
                piece.SetActive(true);

                RU.texture = rawImage.texture;
                RD.texture = rawImage.texture;
                LU.texture = rawImage.texture;
                LD.texture = rawImage.texture;

                picture.SetActive(false);
                Destroy(timelimit);
                Destroy(memory);
                Destroy(count_down);
                //webCamTexture.Stop();

                piece_set.SetActive(true);
                complete.SetActive(true);
            }
            count_down.text = count.ToString();
        }
    }

    public void OnPlay()
    {
        PC.SetActive(false);
        OK.SetActive(false);
        TAKE.SetActive(true);

        webCamTexture.Play();
    }

    public void OnStop()
    {
        PC.SetActive(true);
        OK.SetActive(true);
        TAKE.SetActive(false);

        webCamTexture.Pause();
        rawImage.texture = webCamTexture;
    }


    public void Click()
    {
        PC.SetActive(false);
        OK.SetActive(false);
        pushFlag = true;
        memory.text = "よく覚えよう！";
    }

    public void ToTitle()
    {
        webCamTexture.Stop();
        SceneManager.LoadScene("TitleScene");
    }

    public void Answer()
    {
        answer.SetActive(true);
        ANS.texture = RD.texture;
    }
}
