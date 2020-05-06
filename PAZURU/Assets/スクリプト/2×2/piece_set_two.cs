using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class piece_set_two : MonoBehaviour
{
    public GameObject RU;
    public GameObject RD;
    public GameObject LU;
    public GameObject LD;

    public Text mistake;
    public GameObject titlebutton;
    public GameObject complete;

    RectTransform RUT;
    RectTransform RDT;
    RectTransform LUT;
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

        RDT = RD.GetComponent<RectTransform>();
        RDT.localPosition = new Vector3(Random.Range(-250, 250), Random.Range(-400, -100), 0);

        LUT = LU.GetComponent<RectTransform>();
        LUT.localPosition = new Vector3(Random.Range(-250, 250), Random.Range(-400, -100), 0);

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
        if (RUT.localPosition.x == 105 && RUT.localPosition.y == 298)
        {
            if (RDT.localPosition.x == -102 && RDT.localPosition.y == 298)
            {
                if (LUT.localPosition.x == 105 && LUT.localPosition.y == 93)
                {
                    if (LDT.localPosition.x == -102 && LUT.localPosition.y == 93)
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
    public void ToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
