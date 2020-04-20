using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class T2 : MonoBehaviour
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
        SceneManager.LoadScene("T3");
    }

    public void Back()
    {
        SceneManager.LoadScene("T1");
    }
}
