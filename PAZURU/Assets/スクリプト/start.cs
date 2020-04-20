using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = PlayerPrefs.GetInt("tutorial", 0);
        if (i == 0)
        {
            SceneManager.LoadScene("T1");
        }
        else
        {
            SceneManager.LoadScene("Titlescene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
