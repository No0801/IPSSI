using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Bullet bullet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Bullet b = Instantiate(bullet);
        b.transform.position = transform.position;
        b.transform.forward = transform.forward;
        Destroy(b,5f);
    }
}
