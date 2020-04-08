using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attach_three : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((this.transform.localPosition.x > 163 && this.transform.localPosition.x < 183) && (this.transform.localPosition.y > 410 && this.transform.localPosition.y < 430))
        {
            this.transform.localPosition = new Vector3(173, 420, 0);
        }
        if ((this.transform.localPosition.x > -11 && this.transform.localPosition.x < 9) && (this.transform.localPosition.y > 410 && this.transform.localPosition.y < 430))
        {
            this.transform.localPosition = new Vector3(-1, 420, 0);
        }
        if ((this.transform.localPosition.x > -183 && this.transform.localPosition.x < -163) && (this.transform.localPosition.y > 410 && this.transform.localPosition.y < 430))
        {
            this.transform.localPosition = new Vector3(-173, 420, 0);
        }
        if ((this.transform.localPosition.x > 163 && this.transform.localPosition.x < 183) && (this.transform.localPosition.y > 237 && this.transform.localPosition.y < 257))
        {
            this.transform.localPosition = new Vector3(173, 247, 0);
        }
        if ((this.transform.localPosition.x > -11 && this.transform.localPosition.x < 9) && (this.transform.localPosition.y > 237 && this.transform.localPosition.y < 257))
        {
            this.transform.localPosition = new Vector3(-1, 247, 0);
        }
        if ((this.transform.localPosition.x > -183 && this.transform.localPosition.x < -163) && (this.transform.localPosition.y > 237 && this.transform.localPosition.y < 257))
        {
            this.transform.localPosition = new Vector3(-173, 247, 0);
        }
        if ((this.transform.localPosition.x > 163 && this.transform.localPosition.x < 183) && (this.transform.localPosition.y > 65.5f && this.transform.localPosition.y < 85.5f))
        {
            this.transform.localPosition = new Vector3(173, 75.5f, 0);
        }
        if ((this.transform.localPosition.x > -11 && this.transform.localPosition.x < 9) && (this.transform.localPosition.y > 65.5f && this.transform.localPosition.y < 85.5f))
        {
            this.transform.localPosition = new Vector3(-1, 75.5f, 0);
        }
        if ((this.transform.localPosition.x > -183 && this.transform.localPosition.x < -163) && (this.transform.localPosition.y > 65.5f && this.transform.localPosition.y < 85.5f))
        {
            this.transform.localPosition = new Vector3(-173, 75.5f, 0);
        }

    }
}
