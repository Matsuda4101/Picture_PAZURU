using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public GameObject[] piece;
    float time=0;
    int random;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if ((int)time  == 2)
        {
            time = 0;
            random = Random.Range(0, 3);
            Instantiate(piece[random], new Vector2(Random.Range(-3f,3f),7),Quaternion.identity);
        }
        Debug.Log(time);
    }
}
