using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    Rigidbody rb;
    public Mario2 mario;
    public float speed;
    GameObject bullet;
    // Use this for initialization
    void Start()
    {
		mario = FindObjectOfType<Mario2> ();
        bullet = Resources.Load("bullet") as GameObject;
        InvokeRepeating("Bullets", 2, 5);
    }

    void Bullets()
    {
		//shooting of bullet
        GameObject projectile = Instantiate(bullet) as GameObject;
		projectile.transform.position = transform.position + new Vector3 (0,1,0);
        transform.Translate(-1 * Vector2.right * speed * Time.deltaTime);
        rb = projectile.GetComponent<Rigidbody>();
        Destroy(projectile, 5);
		rb.velocity = (mario.transform.position - transform.position) * 0.25f;
    }
  

}
