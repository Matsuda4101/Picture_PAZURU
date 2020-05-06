using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class piece_set_three : MonoBehaviour
{
    public GameObject RU;
    public GameObject CU;
    public GameObject LU;
    public GameObject RC;
    public GameObject CC;
    public GameObject LC;
    public GameObject RD;
    public GameObject CD;
    public GameObject LD;

    public Text mistake;
    public GameObject titlebutton;
    public GameObject complete;

    RectTransform RUT;
    RectTransform CUT;
    RectTransform LUT;
    RectTransform RCT;
    RectTransform CCT;
    RectTransform LCT;
    RectTransform RDT;
    RectTransform CDT;
    RectTransform LDT;

    public AudioClip seikai;
    public AudioClip noseikai;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        RUT = RU.GetComponent<RectTransform>();
        RUT.localPosition = new Vector3(Random.Range(-250, 250), Random.Range(-400, -100), 0);

        CUT = CU.GetComponent<RectTransform>();
        CUT.localPosition = new Vector3(Random.Range(-250, 250), Random.Range(-400, -100), 0);

        LUT = LU.GetComponent<RectTransform>();
        LUT.localPosition = new Vector3(Random.Range(-250, 250), Random.Range(-400, -100), 0);

        RCT = RC.GetComponent<RectTransform>();
        RCT.localPosition = new Vector3(Random.Range(-250, 250), Random.Range(-400, -100), 0);

        CCT = CC.GetComponent<RectTransform>();
        CCT.localPosition = new Vector3(Random.Range(-250, 250), Random.Range(-400, -100), 0);

        LCT = LC.GetComponent<RectTransform>();
        LCT.localPosition = new Vector3(Random.Range(-250, 250), Random.Range(-400, -100), 0);

        RDT = RD.GetComponent<RectTransform>();
        RDT.localPosition = new Vector3(Random.Range(-250, 250), Random.Range(-400, -100), 0);

        CDT = CD.GetComponent<RectTransform>();
        CDT.localPosition = new Vector3(Random.Range(-250, 250), Random.Range(-400, -100), 0);

        LDT = LD.GetComponent<RectTransform>();
        LDT.localPosition = new Vector3(Random.Range(-250, 250), Random.Range(-400, -100), 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(RUT.localPosition.x + "__" + RUT.localPosition.y);
    }
    public void Click()
    {
        if (RUT.localPosition.x == 173 && RUT.localPosition.y == 420)
        {
            if (CUT.localPosition.x == -1 && CUT.localPosition.y == 420)
            {
                if (LUT.localPosition.x == -173 && LUT.localPosition.y == 420)
                {
                    if (RCT.localPosition.x == 173 && RCT.localPosition.y == 247)
                    {
                        if (CCT.localPosition.x == -1 && CCT.localPosition.y == 247)
                        {
                            if (LCT.localPosition.x == -173 && LCT.localPosition.y == 247)
                            {
                                if (RDT.localPosition.x == 173 && RDT.localPosition.y == 75.5f)
                                {
                                    if (CDT.localPosition.x == -1 && CDT.localPosition.y == 75.5f)
                                    {
                                        if (LDT.localPosition.x == -173 && LDT.localPosition.y == 75.5f)
                                        {
                                            mistake.text = "正解！";
                                            audioSource.PlayOneShot(seikai);
                                            complete.SetActive(false);
                                            titlebutton.SetActive(true);
                                        }
                                        else
                                        {
                                            mistake.text = "間違ってるよ！";
                                            mistake.color = new Color(255, 0, 0);
                                            audioSource.PlayOneShot(noseikai);
                                        }
                                    }
                                    else
                                    {
                                        mistake.text = "間違ってるよ！";
                                        mistake.color = new Color(255, 0, 0);
                                        audioSource.PlayOneShot(noseikai);
                                    }
                                }
                                else
                                {
                                    mistake.text = "間違ってるよ！";
                                    mistake.color = new Color(255, 0, 0);
                                    audioSource.PlayOneShot(noseikai);
                                }
                            }
                            else
                            {
                                mistake.text = "間違ってるよ！";
                                mistake.color = new Color(255, 0, 0);
                                audioSource.PlayOneShot(noseikai);
                            }
                        }
                        else
                        {
                            mistake.text = "間違ってるよ！";
                            mistake.color = new Color(255, 0, 0);
                            audioSource.PlayOneShot(noseikai);
                        }
                    }
                    else
                    {
                        mistake.text = "間違ってるよ！";
                        mistake.color = new Color(255, 0, 0);
                        audioSource.PlayOneShot(noseikai);
                    }
                }
                else
                {
                    mistake.text = "間違ってるよ！";
                    mistake.color = new Color(255, 0, 0);
                    audioSource.PlayOneShot(noseikai);
                }
            }
            else
            {
                mistake.text = "間違ってるよ！";
                mistake.color = new Color(255, 0, 0);
                audioSource.PlayOneShot(noseikai);
            }
        }
        else
        {
            mistake.text = "間違ってるよ！";
            mistake.color = new Color(255, 0, 0);
            audioSource.PlayOneShot(noseikai);
        }
    }
}
