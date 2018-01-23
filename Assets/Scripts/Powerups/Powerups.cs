using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour {
    public Mario mario;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "GreenPower")
        {
            mario.hulkmode = true;

        }
        if (col.tag == "RedPower")
        {
            mario.sniper = true;
        }
        if (col.tag == "YellowPower")
        {
            mario.moneyp = true;
        }
        if (col.tag == "BluePower")
        {
            mario.longjump = true;
        }
        if (col.tag == "BlackPower")
        {
            mario.teleportpower=5;
        }
    }
    
}

