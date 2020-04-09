using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece_drop : MonoBehaviour
{
    int rotate;

    // Start is called before the first frame update
    void Start()
    {
        rotate = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.y < -7)
        {
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        this.transform.Rotate(0, 0, rotate);
        this.transform.Translate(0, -0.03f, 0,Space.World);
    }
}
