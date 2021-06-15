using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewParalax : MonoBehaviour
{
    private float lenght;
    private float startPos;
    private Transform cam;
    public float paralaxEffect;

    void Start()
    {
        startPos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
        cam = Camera.main.transform;
    }
    void Update()
    {
        float rePos = cam.transform.position.x * (1f - paralaxEffect);
        float distance = cam.transform.position.x * paralaxEffect;
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        if(rePos > startPos + lenght)
        {
           startPos += lenght;
        }
        else if(rePos < startPos - lenght)
        {
           startPos -= lenght;
        }
    }
}
