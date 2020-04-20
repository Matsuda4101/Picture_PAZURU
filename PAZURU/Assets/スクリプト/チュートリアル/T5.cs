using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class T5 : MonoBehaviour
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
        SceneManager.LoadScene("T6");
    }

    public void Back()
    {
        SceneManager.LoadScene("T4");
    }
}
