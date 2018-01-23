using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{

    public float moveForce = 0f;
    private Rigidbody rbody;
    public GameObject bullet;
    public Transform gun;
    public float shootRate = 0f;
    public float shootForce = 0f;
    private float shootRateTimeStamp = 0f;
    public float destroy_timer = 5.0f;
    public float expiryTime = 5.0f;


    // Use this for initialization
    void Start()
    {


        Invoke("Destroy", 5);
        rbody = GetComponent<Rigidbody>();

    }


    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal") * moveForce;
        float v = Input.GetAxisRaw("Vertical") * moveForce;

       // rbody.velocity = new Vector3(h, v, 0);

        //add script to trigger firing the projctiles 

        if (Time.time > shootRateTimeStamp)
        {
            //bullet will shoot toward mario
            GameObject go = (GameObject)Instantiate(bullet, gun.position, gun.rotation);
            go.GetComponent<Rigidbody>().AddForce(gun.forward * shootForce);
            shootRateTimeStamp = Time.time + shootRate;

        }

        Destroy(gameObject, expiryTime);

    }


}
