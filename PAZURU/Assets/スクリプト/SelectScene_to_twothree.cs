using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene_to_twothree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Two()
    {
        SceneManager.LoadScene("TwoTwoScene");
    }

    public void Three()
    {
        SceneManager.LoadScene("ThreeThreeScene");
    }
}
