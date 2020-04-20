using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class T11 : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Next()
    {
        PlayerPrefs.SetInt("tutorial", 1);
        SceneManager.LoadScene("TitleScene");
    }

    public void Back()
    {
        SceneManager.LoadScene("T10");
    }
}
