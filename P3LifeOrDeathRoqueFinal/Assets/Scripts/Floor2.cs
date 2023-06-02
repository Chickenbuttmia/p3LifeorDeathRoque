using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor2 : MonoBehaviour
{
    public float speed = 30;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    private float leftBound = -15;
    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}

