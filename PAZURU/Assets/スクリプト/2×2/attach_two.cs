using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attach_two : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((this.transform.localPosition.x > 95 && this.transform.localPosition.x < 115) && (this.transform.localPosition.y > 288 && this.transform.localPosition.y < 308))
        {
            this.transform.localPosition = new Vector3(105, 298, 0);
        }
        if ((this.transform.localPosition.x > -112 && this.transform.localPosition.x < -92) && (this.transform.localPosition.y > 288 && this.transform.localPosition.y < 308))
        {
            this.transform.localPosition = new Vector3(-102, 298, 0);
        }
        if ((this.transform.localPosition.x > -112 && this.transform.localPosition.x < -92) && (this.transform.localPosition.y > 83 && this.transform.localPosition.y < 103))
        {
            this.transform.localPosition = new Vector3(-102, 93, 0);
        }
        if ((this.transform.localPosition.x > 95 && this.transform.localPosition.x < 115) && (this.transform.localPosition.y > 83 && this.transform.localPosition.y < 103))
        {
            this.transform.localPosition = new Vector3(105, 93, 0);
        }
    }
}
