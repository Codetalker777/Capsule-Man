using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionScript : MonoBehaviour
{

    public GameObject enemy2;
    public float power = 10.0f;
    public float radius = 1.0f;
    public float upforce = 1.0f;

    // Use this for initialization
    void Start()
    {
        
            Invoke("Detonate", 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Detonate", 5);
    }

    void Detonate()
    {
        Vector3 explosionPosition = enemy2.transform.position;
        // overlapSphere with 2 parameters the position of the explosion and the radius of the sphere
        // Colliders store all coldiers of game objets within this radius 
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(power, explosionPosition, radius, upforce, ForceMode.Impulse);
            }
        }
    }
}

