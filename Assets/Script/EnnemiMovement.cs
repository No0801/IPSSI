using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnnemiMovement : MonoBehaviour
{
    public Transform target;
    private Rigidbody rigi;
    public float vitesse;
    public AnimationManager animationManager;
    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        animationManager.Move(rigi.velocity.magnitude);
    }

    private void FixedUpdate()
    {
        Vector3 dir = (target.position - transform.position).normalized;
        dir.y = 0;
        rigi.velocity = dir.normalized * vitesse;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
