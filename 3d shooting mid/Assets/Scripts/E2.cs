using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomMove : MonoBehaviour
{
    public float speed = 4;
    private float timer = 0;
    private float dir_y = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 3)
        {
            dir_y = Random.Range(0,360);
            timer = 0;
            transform.Rotate(new Vector3(0,dir_y,0));
        }
        transform.position += transform.forward * speed *timer;
    }

}