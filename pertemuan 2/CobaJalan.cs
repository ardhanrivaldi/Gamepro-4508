using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CobaJalan : MonoBehaviour
{
    public float movespeed;
    int status;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    //transfrom.Translate(movespeed, 0, 0); //bisa diganti kode ini
    transform.position = new Vector3(transform.position.x + movespeed, transform.position.y);

    }
}
