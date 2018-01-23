using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    Gold gold;
    private int tempcoinworth;
    public float speed=1;
    public float health = 100;
    public float hulkhealth;
    private Rigidbody rb;
    public Renderer rend;
    private float orignalspeed;
    public bool onGround = true;
    public int jump = 150;
    private IEnumerator Coroutine;
    private bool secondjump = true;
    public bool hulkmode = false;
    public int teleportpower = 5;
    public bool moneyp = false;
    public bool sniper = false;
    public bool teleport = false;
    public bool longjump = false;
    public bool invincible = false;
    LineRenderer line;
    void Start()
    {
        line = gameObject.GetComponent<LineRenderer>();
        line.enabled = false;
        rb = GetComponent<Rigidbody>();
        orignalspeed = speed;

    }

    void Update()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
         
        transform.Translate(moveHorizontal * speed, 0, 0);

        RaycastHit hit;
        Vector3 pcenter = this.transform.position + this.GetComponent<CapsuleCollider>().center;
        Debug.DrawRay(pcenter, Vector3.down * 1.3f, Color.red, 1);
        if (Physics.Raycast(pcenter, Vector3.down, out hit, 1.3f))
        {
            if (hit.transform.gameObject.tag != "player")
            {
                onGround = true;
            }
            if (hit.transform.gameObject.tag == "enemy")
            {
                Destroy(GameObject.FindWithTag("enemy"));
                onGround = false;
            }
        }
        else
        {
            onGround = false;
        }
        if (longjump == true)
        {
            StartCoroutine(Jump(10));
            longjump = false;
        }
        if (moneyp == true)
        {
            StartCoroutine(Money(10));
            moneyp = false;
        }
        
        if (Input.GetKey(KeyCode.LeftControl))
        {
            speed = 2*orignalspeed;
        }
        else
        {
            speed = orignalspeed;
        }
        if (hulkmode == true  )
        {
            invincible = true;
            hulkhealth = health;
            StartCoroutine(Hulk(10));
            hulkmode = false;
            
            //Debug.Log(hulkmode);
        }
        if (Input.GetKeyDown("space") && !onGround && secondjump)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jump);
            secondjump = false;
        }
        if (Input.GetKeyDown("space") && onGround)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jump);
            secondjump = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            
            if (teleport == true && teleportpower>0)
            {
                Vector3 mouseP = Input.mousePosition;
                mouseP.z = 10;
                mouseP = Camera.main.ScreenToWorldPoint(mouseP);
                transform.position = mouseP;

                invincible = true;
                hulkhealth = health;
                StartCoroutine(Hulk(2));
                teleportpower -= 1;
                onGround = true;   // resetting double jump

            }
        }
            if (sniper == true)
            {
            teleport = false;
            StartCoroutine(Sniper(10));
            if (Input.GetMouseButtonDown(0))
                {
                    
                    Vector3 mouseP = Input.mousePosition;
                    mouseP.z = 10;
                    mouseP = Camera.main.ScreenToWorldPoint(mouseP);
                    Debug.Log(mouseP);
                    RaycastHit hit2;
                    Debug.DrawRay(transform.position, mouseP * 10000f, Color.red, 1);
                    line.enabled = true;
                   // line.SetPosition(0,transform.position);
                    line.SetPosition(1, mouseP*1000);
                    StartCoroutine(Laser(2));    

                    if (Physics.Raycast(transform.position, mouseP, out hit2))
                    {

                        if (hit2.transform.gameObject.tag == "enemy")
                        {
                            Destroy(GameObject.FindWithTag("enemy"));
                        }
                    }


                }
            }
        

    }
    IEnumerator Hulk(int howangry)
    {
        
            transform.GetComponent<Renderer>().material.color = Color.green;
            invincible = true;
            yield return new WaitForSeconds(howangry);
            transform.GetComponent<Renderer>().material.color = Color.white;
            invincible = false;
            //Debug.Log("Frame is over");
            
        
    }
    IEnumerator Money(int howangry)
    {

        transform.GetComponent<Renderer>().material.color = Color.yellow;
        yield return new WaitForSeconds(howangry);
        transform.GetComponent<Renderer>().material.color = Color.white;
        
        //Debug.Log("Frame is over");


    }
    IEnumerator Sniper(int howangry)
    {

        transform.GetComponent<Renderer>().material.color = Color.red;

        yield return new WaitForSeconds(howangry);
        transform.GetComponent<Renderer>().material.color = Color.white;
        teleport = true;
        sniper = false;
        //Debug.Log("Frame is over");


    }
    IEnumerator Laser(int howangry)
    {

        
        yield return new WaitForSeconds(howangry);
        line.enabled = false;
        


    }
    IEnumerator Jump(int howangry)
    {
        jump = 350;
        transform.GetComponent<Renderer>().material.color = Color.blue;
        yield return new WaitForSeconds(howangry);
        transform.GetComponent<Renderer>().material.color = Color.white;
        longjump = false;
        jump = 200;
        //Debug.Log("Frame is over");


    }
}
        

