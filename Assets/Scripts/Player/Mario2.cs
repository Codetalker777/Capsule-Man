using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mario2 : MonoBehaviour
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
	public Vector3 position;
	public int check = 0;
	public GameObject popupdie;
	public GameObject Finish;
	public GameObject telecharges;
	public int enemieskilled = 0;

	public AudioSource lasersound;
	public AudioSource jumpsound;
	public AudioSource teleportsound;
	public AudioSource jumpon;


	LineRenderer line;
	void Start()
	{
		// checking save data
		if (PlayerPrefs.HasKey ("Speed") == true) {

			speed = PlayerPrefs.GetFloat ("Speed");
		} else {

			PlayerPrefs.SetFloat ("Speed", 0.1f);
		}

		if (PlayerPrefs.HasKey ("Health") == true) {

			health = PlayerPrefs.GetFloat ("Health");
		} else {

			PlayerPrefs.SetFloat ("Speed", 100f);
		}

		if (PlayerPrefs.HasKey ("CoinBoost") == false) {

			PlayerPrefs.SetInt ("CoinBoost", 2);

		}

		Time.timeScale = 1;
		line = gameObject.GetComponent<LineRenderer>();
		line.enabled = false;
		rb = GetComponent<Rigidbody>();
		orignalspeed = speed;
		popupdie.SetActive(false);
		Finish.SetActive (false);
		telecharges.SetActive (false);

		// checking for zero gravity power
		if (PlayerPrefs.HasKey ("Zerogravity") == true) {

			if (PlayerPrefs.HasKey ("OnOffZero") == true) {

				if (PlayerPrefs.GetInt ("OnOffZero") == 1 && PlayerPrefs.GetInt ("Zerogravity") == 1) {

					rb.useGravity = false;

				}

			} else {

				PlayerPrefs.SetInt ("OnOffZero", 0);
			}

		} else {

			PlayerPrefs.SetInt ("Zerogravity", 0);

		}

	}

	void Update()
	{


		if (Time.timeScale == 1) {


			// death
			if (health <= 0|| transform.position.y < -20.0f) {

				Debug.Log ("Die!!!");
				popupdie.SetActive (true);
				Time.timeScale = 0;
			}
			// movement
			float moveHorizontal = Input.GetAxis("Horizontal");
			float moveVertical = Input.GetAxis("Vertical");

			transform.Translate(moveHorizontal * speed, 0, 0);

			if (PlayerPrefs.GetInt ("Zerogravity") == 1 && PlayerPrefs.GetInt ("OnOffZero") == 1) {

				transform.Translate (0, moveVertical * speed, 0);

			}

			// sprint
			if (Input.GetKey(KeyCode.LeftControl))
			{
				speed = 2*orignalspeed;
			}
			else
			{
				speed = orignalspeed;
			}

			// destroy enemy through hit from above
			RaycastHit hit;
			Vector3 pcenter = this.transform.position + this.GetComponent<CapsuleCollider>().center;
			Debug.DrawRay(pcenter, Vector3.down * 1.3f, Color.red, 1);
			if (Physics.Raycast(pcenter, Vector3.down, out hit, 1.3f))
			{
				if (hit.transform.gameObject.tag != "player")
				{
					onGround = true;
				}
				if (hit.transform.gameObject.tag == "enemy" || hit.transform.gameObject.GetComponent<Exploder>() != null)
				{
					Destroy(hit.transform.gameObject);
					onGround = false;
					jumpon.Play ();
					enemieskilled = enemieskilled + 1;
				}
				if (hit.transform.gameObject.tag == "Ending") {

					Debug.Log ("Here");
					Finish.SetActive (true);
					Time.timeScale = 0;
				}
			}
			else
			{
				onGround = false;
			}

			// jumping
			if (Input.GetKeyDown("space") && !onGround && secondjump)
			{
				jumpsound.Play ();
				this.GetComponent<Rigidbody>().AddForce(Vector3.up * jump);
				secondjump = false;
			}
			if (Input.GetKeyDown("space") && onGround)
			{
				jumpsound.Play ();
				this.GetComponent<Rigidbody>().AddForce(Vector3.up * jump);
				secondjump = true;
			}

			// long jump
			if (longjump == true) {
				jump = 350;
				StartCoroutine (Jump (10));
			} else if (longjump == false) {
				jump = 200;
			}
			if (moneyp == true)
			{
				StartCoroutine(Money(10));
			}

			if (hulkmode == true  )
			{
				hulkhealth = health;
				StartCoroutine(Hulk(10));

				//Debug.Log(hulkmode);
			}

			if (hulkmode == false && teleport == false) {

				invincible = false;
			}

			if (teleport == true) {

				StartCoroutine (Teleportation (1));
			} else if (teleport == false && hulkmode == false && sniper == false && moneyp == false && longjump == false) {

				transform.GetComponent<Renderer>().material.color = Color.white;

			}
			if (teleportpower == 0) {

				teleport = false;
				telecharges.SetActive (false);
			}

			// teleport
			if (Input.GetMouseButtonDown(0))
			{

				if (teleport == true && teleportpower>0)
				{
					teleportsound.Play ();
					Vector3 mouseP = Input.mousePosition;
					mouseP.z = 10;
					mouseP = Camera.main.ScreenToWorldPoint(mouseP);
					transform.position = mouseP;

					invincible = true;
					hulkhealth = health;
					StartCoroutine(AfterTeleportation(2));
					teleportpower -= 1;
					onGround = true;   // resetting double jump

				}
			}
			//laser
			if (sniper == true)
			{
				StartCoroutine(Sniper(30));
				if (Input.GetMouseButtonDown(0))
				{
					lasersound.Play ();
					Vector3 mouseP = Input.mousePosition;
					mouseP.z = 10;
					mouseP = Camera.main.ScreenToWorldPoint(mouseP);
					Debug.Log(mouseP);
					RaycastHit hit2;
					Debug.DrawRay(transform.position, (mouseP - transform.position) * 10, Color.red, 2);
					line.enabled = true;
					//line.SetPosition(0,transform.position);
					if (check == 0) {

						position = transform.position;
						check = 1;
					}
					line.SetPosition(1, (mouseP - position) * 10);

					StartCoroutine(Laser(1));    


					RaycastHit[] hits;
					hits = Physics.RaycastAll(transform.position, (mouseP - transform.position) * 10);

					for (int i = 0; i < hits.Length; i++) {

						if (hits[i].transform.gameObject.tag == "enemy" || hits[i].transform.gameObject.GetComponent<Exploder>() != null) {

							enemieskilled = enemieskilled + 1;
							Destroy(hits[i].transform.gameObject);
						}

					}

				}
			}

		}


	}


	IEnumerator AfterTeleportation (int howangry) {

		hulkhealth = health;
		invincible = true;
		yield return new WaitForSeconds(howangry);
		invincible = false;

	}

	IEnumerator Teleportation (int howangry) {

		transform.GetComponent<Renderer> ().material.color = Color.black;
		yield return new WaitForSeconds(howangry);

	}

	IEnumerator Hulk(int howangry)
	{

		transform.GetComponent<Renderer>().material.color = Color.green;
		invincible = true;
		yield return new WaitForSeconds(howangry);
		if (hulkmode == true) {
			transform.GetComponent<Renderer>().material.color = Color.white;
			hulkmode = false;
			invincible = false;
		}
		//Debug.Log("Frame is over");


	}
	IEnumerator Money(int howangry)
	{

		transform.GetComponent<Renderer>().material.color = Color.yellow;
		yield return new WaitForSeconds(howangry);
		if (moneyp == true) {
			transform.GetComponent<Renderer>().material.color = Color.white;
			moneyp = false;
		}

		//Debug.Log("Frame is over");


	}
	IEnumerator Sniper(int howangry)
	{

		transform.GetComponent<Renderer>().material.color = Color.red;

		yield return new WaitForSeconds(howangry);
		if (sniper == true) {

			transform.GetComponent<Renderer>().material.color = Color.white;
			sniper = false;
		}
		//Debug.Log("Frame is over");


	}
	IEnumerator Laser(int howangry)
	{

		yield return new WaitForSeconds(howangry);
		line.enabled = false;
		check = 0;



	}
	IEnumerator Jump(int howangry)
	{
		transform.GetComponent<Renderer>().material.color = Color.blue;
		yield return new WaitForSeconds(howangry);
		if (longjump == true) {
			transform.GetComponent<Renderer>().material.color = Color.white;
			longjump = false;
		}
		//Debug.Log("Frame is over");


	}
		

		
}



