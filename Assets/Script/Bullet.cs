using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody rigi;
    [SerializeField] private float vitesse;

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        rigi.velocity = transform.forward * vitesse;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
