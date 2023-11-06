using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi_Spawner : MonoBehaviour
{

    [SerializeField] private EnnemiMovement ennemi;
    [SerializeField] private Transform target;
    [SerializeField] private float timer;

    private float t;
    
    // Update is called once per frame
    void Update()
    {
        if(t < 0)
        {
            var e = Instantiate(ennemi);
            e.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            e.target= target;
            t = timer;
        }

        t -= Time.deltaTime;
    }
}
