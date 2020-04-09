using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_SE : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip click;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        audiosource.PlayOneShot(click);
    }
}
