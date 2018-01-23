using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

	// variable declarations
	public PlatformLength PlatformA;
	public UpDown PlatformB;
	public PlatformLength PlatformD;
	public LeftRight PlatformC;
	public PlatformLength PlatformE;
	public Gold au;
	public PlatformLength end;
	public GameObject Deathzone;
	public GameObject Sniperpowerup;
	public GameObject Hulkpowerup;
	public GameObject Moneypowerup;
	public GameObject Teleportpowerup;
	public GameObject LongJumppowerup;
	public enemy3 Patrol;
	public enemy4 Bomb;
	public GameObject throws;
	public GameObject Ghosts;
	public GameObject Exploders;

	public GameObject player;

	public PlatformLength A;
	public LeftRight B;
	public UpDown C;
	public Gold coin;
	public GameObject Deathzoner;
	public GameObject Sniper;
	public GameObject Hulk;
	public GameObject Money;
	public GameObject Teleport;
	public GameObject LongJump;
	public enemy3 Patroler;
	public enemy4 Bomber;
	public GameObject thrower;
	public GameObject Ghost;
	public GameObject Exploder;

	public float chance;
	public float chance2;
	public float chance3;
	public float chance4;
	public int count = 0;
	public float count2 = 0;
	public float x = 0;
	public float total = 0;
	public float level_size = 0;
	public int endcheck = 0;
	public int enemycheck = 0;

	public float id_num = 1;
		
	//this code generates the sections of size 5 based on chance. It selects from 5 platforms and then sets
	// the position based on x. Then it loops through and through chance places gold, powerups and enemies
	// once they are made 10 different sections, the endzone spawns.
	void Start () {

		while (count < 5) {

			chance = Random.value;

			if (chance < 0.2) {

				A = Instantiate (PlatformA, new Vector3 (x, 0, 0), Quaternion.identity) as PlatformLength;
				A.tag = id_num.ToString ();

				while (count2 < 5) {
					
					chance2 = Random.value;

					if (chance2 < 0.45) {
					

						coin = Instantiate (au, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as Gold;
						coin.transform.parent = A.transform;
						count2 = count2 + 1;


					} else if (chance2 >= 0.45 && chance2 < 0.5) {

						chance3 = Random.value;

						if (chance3 < 0.2) {

							Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
							Sniper.transform.parent = A.transform;
							count2 = count2 + 1;

						} else if (chance3 >= 0.2 && chance3 < 0.4) {

							Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
							Hulk.transform.parent = A.transform;
							count2 = count2 + 1;
						} else if (chance3 >= 0.4 && chance3 < 0.6) {

							Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
							Money.transform.parent = A.transform;
							count2 = count2 + 1;
						} else if (chance3 >= 0.6 && chance3 < 0.8) {

							LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
							LongJump.transform.parent = A.transform;
							count2 = count2 + 1;
						} else if (chance3 >= 0.8) {

							Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
							Teleport.transform.parent = A.transform;
							count2 = count2 + 1;
						}
							
					} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

						chance4 = Random.value;

						if (chance4 < 0.2) {

							Patroler = Instantiate (Patrol, new Vector3 (x, 1.25f, 0), Quaternion.identity) as enemy3;
							Patroler.min = x - 4.5f;
							Patroler.max = x + 4.5f;
							Patroler.transform.parent = A.transform;
							enemycheck = 1;

							count2 = count2 + 1;

						} else if (chance4 >= 0.2 && chance4 < 0.4) {

							Bomber = Instantiate (Bomb, new Vector3 (x, 6.25f, 0), Quaternion.identity) as enemy4;
							Bomber.min = x - 4.5f;
							Bomber.max = x + 4.5f;
							Bomber.transform.parent = A.transform;
							count2 = count2 + 1;
							enemycheck = 1;

						} else if (chance4 >= 0.4 && chance4 < 0.6) {

							thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
							count2 = count2 + 1;
							enemycheck = 1;
							thrower.transform.parent = A.transform;

						} else if (chance4 >= 0.6 && chance4 < 0.8) {

							Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
							count2 = count2 + 1;
							enemycheck = 1;
							Ghost.transform.parent = A.transform;

						} else if (chance4 >= 0.8) {

							Exploder = Instantiate (Exploders, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
							count2 = count2 + 1;
							enemycheck = 1;
							Exploder.tag = id_num.ToString ();
							//Exploder.transform.parent = A.transform;

						}
							
						//enemy
					} else if (chance2 >= 0.65 && chance2 < 0.7) {

						Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
						Deathzoner.transform.parent = A.transform;
						count2 = count2 + 1;

					} else if (chance2 > 0.7) {

						//do nothing
						count2 = count2+1;

					}
				}
				enemycheck = 0;
				count2 = 0;
				x = x + A.length + 1;

				count = count + 1;

			} else if (chance >= 0.20 && chance < 0.4) {

				if (C == null) {

					C = Instantiate (PlatformB, new Vector3 (x, 0, 0), Quaternion.identity) as UpDown;
					C.tag = id_num.ToString ();
					while (count2 < 5) {

						chance2 = Random.value;

						if (chance2 < 0.45) {


							coin = Instantiate (au, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as Gold;
							coin.transform.parent = C.transform;
							count2 = count2 + 1;


						} else if (chance2 >= 0.45 && chance2 < 0.5) {

							chance3 = Random.value;

							if (chance3 < 0.2) {

								Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Sniper.transform.parent = C.transform;
								count2 = count2 + 1;

							} else if (chance3 >= 0.2 && chance3 < 0.4) {

								Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Hulk.transform.parent = C.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.4 && chance3 < 0.6) {

								Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Money.transform.parent = C.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.6 && chance3 < 0.8) {

								LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								LongJump.transform.parent = C.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.8) {

								Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Teleport.transform.parent = C.transform;
								count2 = count2 + 1;
							}
						} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

							chance4 = Random.value;

							if (chance4 < 0.2) {

								Patroler = Instantiate (Patrol, new Vector3 (x, 1.25f, 0), Quaternion.identity) as enemy3;
								Patroler.min = x - 4.5f;
								Patroler.max = x + 4.5f;
								Patroler.transform.parent = C.transform;
								enemycheck = 1;

								count2 = count2 + 1;

							} else if (chance4 >= 0.2 && chance4 < 0.4) {

								Bomber = Instantiate (Bomb, new Vector3 (x, 6.25f, 0), Quaternion.identity) as enemy4;
								Bomber.min = x - 4.5f;
								Bomber.max = x + 4.5f;
								Bomber.transform.parent = C.transform;
								count2 = count2 + 1;
								enemycheck = 1;

							} else if (chance4 >= 0.4 && chance4 < 0.6) {

								thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								thrower.transform.parent = C.transform;

							} else if (chance4 >= 0.6 && chance4 < 0.8) {

								Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Ghost.transform.parent = C.transform;

							} else if (chance4 >= 0.8) {

								Exploder = Instantiate (Exploders, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Exploder.tag = id_num.ToString ();
	
							//enemy
							}
						} else if (chance2 >= 0.65 && chance2 < 0.7) {

							Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
							Deathzoner.transform.parent = C.transform;
							count2 = count2 + 1;

						} else if (chance2 > 0.7) {

							//do nothing
							count2 = count2+1;

						}
					}
					enemycheck = 0;
					count2 = 0;
					x = x + C.length + 1;

					count = count + 1;

				} else if (C.speed == 1.0f) {

					C = Instantiate (PlatformB, new Vector3 (x, 4, 0), Quaternion.identity) as UpDown;
					C.tag = id_num.ToString ();
					while (count2 < 5) {

						chance2 = Random.value;

						if (chance2 < 0.45) {


							coin = Instantiate (au, new Vector3 (x - 2 + count2, 5f, 0), Quaternion.identity) as Gold;
							coin.transform.parent = C.transform;
							count2 = count2 + 1;


						} else if (chance2 >= 0.45 && chance2 < 0.5) {

							chance3 = Random.value;

							if (chance3 < 0.2) {

								Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 5f, 0), Quaternion.identity) as GameObject;
								Sniper.transform.parent = C.transform;
								count2 = count2 + 1;

							} else if (chance3 >= 0.2 && chance3 < 0.4) {

								Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 5f, 0), Quaternion.identity) as GameObject;
								Hulk.transform.parent = C.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.4 && chance3 < 0.6) {

								Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 5f, 0), Quaternion.identity) as GameObject;
								Money.transform.parent = C.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.6 && chance3 < 0.8) {

								LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 5f, 0), Quaternion.identity) as GameObject;
								LongJump.transform.parent = C.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.8) {

								Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 5f, 0), Quaternion.identity) as GameObject;
								Teleport.transform.parent = C.transform;
								count2 = count2 + 1;
							}
							//powerup
						} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

							chance4 = Random.value;

							if (chance4 < 0.2) {

								Patroler = Instantiate (Patrol, new Vector3 (x, 5.25f, 0), Quaternion.identity) as enemy3;
								Patroler.min = x - 4.5f;
								Patroler.max = x + 4.5f;
								Patroler.transform.parent = C.transform;
								enemycheck = 1;

								count2 = count2 + 1;

							} else if (chance4 >= 0.2 && chance4 < 0.4) {

								Bomber = Instantiate (Bomb, new Vector3 (x, 10.25f, 0), Quaternion.identity) as enemy4;
								Bomber.min = x - 4.5f;
								Bomber.max = x + 4.5f;
								Bomber.transform.parent = C.transform;
								count2 = count2 + 1;
								enemycheck = 1;

							} else if (chance4 >= 0.4 && chance4 < 0.6) {

								thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 5.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								thrower.transform.parent = C.transform;

							} else if (chance4 >= 0.6 && chance4 < 0.8) {

								Ghost = Instantiate (Ghosts ,new Vector3 (x - 2 + count2, 5.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Ghost.transform.parent = C.transform;

							} else if (chance4 >= 0.8) {

								Exploder = Instantiate (Exploders, new Vector3 (x - 2 + count2, 5.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Exploder.tag = id_num.ToString ();

								//enemy
							}
							//enemy
						} else if (chance2 >= 0.65 && chance2 < 0.7) {

							Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 5.25f, 0), Quaternion.identity) as GameObject;
							Deathzoner.transform.parent = C.transform;
							count2 = count2 + 1;

						} else if (chance2 > 0.7) {

							//do nothing
							count2 = count2+1;

						}
					}
					enemycheck = 0;
					count2 = 0;
					x = x + C.length + 1;
					C.speed = -1.0f;
					count = count + 1;


				} else if (C.speed == -1.0f) {

					C = Instantiate (PlatformB, new Vector3 (x, 0, 0), Quaternion.identity) as UpDown;
					C.tag = id_num.ToString ();
					while (count2 < 5) {

						chance2 = Random.value;

						if (chance2 < 0.45) {

							coin = Instantiate (au, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as Gold;
							coin.transform.parent = C.transform;
							count2 = count2 + 1;


						} else if (chance2 >= 0.45 && chance2 < 0.5) {

							chance3 = Random.value;

							if (chance3 < 0.2) {

								Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Sniper.transform.parent = C.transform;
								count2 = count2 + 1;

							} else if (chance3 >= 0.2 && chance3 < 0.4) {

								Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Hulk.transform.parent = C.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.4 && chance3 < 0.6) {

								Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Money.transform.parent = C.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.6 && chance3 < 0.8) {

								LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								LongJump.transform.parent = C.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.8) {

								Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Teleport.transform.parent = C.transform;
								count2 = count2 + 1;
							}
							//powerup
						} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

							chance4 = Random.value;

							if (chance4 < 0.2) {

								Patroler = Instantiate (Patrol, new Vector3 (x, 1.25f, 0), Quaternion.identity) as enemy3;
								Patroler.min = x - 4.5f;
								Patroler.max = x + 4.5f;
								Patroler.transform.parent = C.transform;
								enemycheck = 1;

								count2 = count2 + 1;

							} else if (chance4 >= 0.2 && chance4 < 0.4) {

								Bomber = Instantiate (Bomb, new Vector3 (x, 6.25f, 0), Quaternion.identity) as enemy4;
								Bomber.min = x - 4.5f;
								Bomber.max = x + 4.5f;
								Bomber.transform.parent = C.transform;
								count2 = count2 + 1;
								enemycheck = 1;

							} else if (chance4 >= 0.4 && chance4 < 0.6) {

								thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								thrower.transform.parent = C.transform;

							} else if (chance4 >= 0.6 && chance4 < 0.8) {

								Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Ghost.transform.parent = C.transform;

							} else if (chance4 >= 0.8) {

								Exploder = Instantiate (Exploders, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Exploder.tag = id_num.ToString ();

								//enemy
							}
							//enemy
						} else if (chance2 >= 0.65 && chance2 < 0.7) {

							Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
							Deathzoner.transform.parent = C.transform;
							count2 = count2 + 1;

						} else if (chance2 > 0.7) {

							//do nothing
							count2 = count2+1;

						}
					}
					enemycheck = 0;
					count2 = 0;
					x = x + C.length + 1;
					count = count + 1;


				}

			} else if (chance >= 0.4 && chance < 0.6) {

				if (B == null) {

					B = Instantiate (PlatformC, new Vector3 (x, 0, 0), Quaternion.identity) as LeftRight;
					B.tag = id_num.ToString ();
					while (count2 < 5) {

						chance2 = Random.value;

						if (chance2 < 0.45) {

							coin = Instantiate (au, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as Gold;
							coin.transform.parent = B.transform;
							count2 = count2 + 1;


						} else if (chance2 >= 0.45 && chance2 < 0.5) {

							chance3 = Random.value;

							if (chance3 < 0.2) {

								Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Sniper.transform.parent = B.transform;
								count2 = count2 + 1;

							} else if (chance3 >= 0.2 && chance3 < 0.4) {

								Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Hulk.transform.parent = B.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.4 && chance3 < 0.6) {

								Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Money.transform.parent = B.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.6 && chance3 < 0.8) {

								LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								LongJump.transform.parent = B.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.8) {

								Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Teleport.transform.parent = B.transform;
								count2 = count2 + 1;
							}
							//powerup
						} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {
							
							if (chance4 < 0.5) {

								thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								thrower.transform.parent = B.transform;

							} else if (chance4 >= 0.5) {

								Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Ghost.transform.parent = B.transform;

							}
							//enemy
						} else if (chance2 >= 0.65 && chance2 < 0.7) {

							Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
							Deathzoner.transform.parent = B.transform;
							count2 = count2 + 1;

						} else if (chance2 > 0.7) {

							//do nothing
							count2 = count2+1;

						}
					}
					enemycheck = 0;
					count2 = 0;
					count = count + 1;
					B.min = x;
					B.max = x + 4;

					x = x + B.length + 4 + 1;


				} else if (B.speed == 1.0f) {

					B = Instantiate (PlatformC, new Vector3 (x + 4, 0, 0), Quaternion.identity) as LeftRight;
					B.tag = id_num.ToString ();
					while (count2 < 5) {

						chance2 = Random.value;

						if (chance2 < 0.45) {

							coin = Instantiate (au, new Vector3 (x - 2 + count2 + 4, 1f, 0), Quaternion.identity) as Gold;
							coin.transform.parent = B.transform;
							count2 = count2 + 1;


						} else if (chance2 >= 0.45 && chance2 < 0.5) {

							chance3 = Random.value;

							if (chance3 < 0.2) {

								Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2 + 4, 1f, 0), Quaternion.identity) as GameObject;
								Sniper.transform.parent = B.transform;
								count2 = count2 + 1;

							} else if (chance3 >= 0.2 && chance3 < 0.4) {

								Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2 + 4, 1f, 0), Quaternion.identity) as GameObject;
								Hulk.transform.parent = B.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.4 && chance3 < 0.6) {

								Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2 + 4, 1f, 0), Quaternion.identity) as GameObject;
								Money.transform.parent = B.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.6 && chance3 < 0.8) {

								LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2 + 4, 1f, 0), Quaternion.identity) as GameObject;
								LongJump.transform.parent = B.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.8) {

								Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2 + 4, 1f, 0), Quaternion.identity) as GameObject;
								Teleport.transform.parent = B.transform;
								count2 = count2 + 1;
							}
							//powerup
						} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {
							
							if (chance4 < 0.5) {

								thrower = Instantiate (throws, new Vector3 (x - 2 + count2 + 4, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								thrower.transform.parent = B.transform;

							} else if (chance4 >= 0.5) {

								Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2 + 4, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Ghost.transform.parent = B.transform;

							}
							//enemy
						} else if (chance2 >= 0.65 && chance2 < 0.7) {

							Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2 + 4, 1.25f, 0), Quaternion.identity) as GameObject;
							Deathzoner.transform.parent = B.transform;
							count2 = count2 + 1;

						} else if (chance2 > 0.7) {

							//do nothing
							count2 = count2+1;

						}
					}
					enemycheck = 0;
					count2 = 0;

					count2 = 0;
					count = count + 1;
					B.min = x;
					B.max = x + 4;

					B.speed = -1.0f;

					x = x + B.length + 4 + 1;


				} else if (B.speed == -1.0f) {

					B = Instantiate (PlatformC, new Vector3 (x, 0, 0), Quaternion.identity) as LeftRight;
					B.tag = id_num.ToString ();
					while (count2 < 5) {

						chance2 = Random.value;

						if (chance2 < 0.45) {

							coin = Instantiate (au, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as Gold;
							coin.transform.parent = B.transform;
							count2 = count2 + 1;


						} else if (chance2 >= 0.45 && chance2 < 0.5) {

							chance3 = Random.value;

							if (chance3 < 0.2) {

								Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Sniper.transform.parent = B.transform;
								count2 = count2 + 1;

							} else if (chance3 >= 0.2 && chance3 < 0.4) {

								Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Hulk.transform.parent = B.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.4 && chance3 < 0.6) {

								Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Money.transform.parent = B.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.6 && chance3 < 0.8) {

								LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								LongJump.transform.parent = B.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.8) {

								Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Teleport.transform.parent = B.transform;
								count2 = count2 + 1;
							}
		
							//powerup
						} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {
							
							if (chance4 < 0.5) {

								thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								thrower.transform.parent = B.transform;

							} else if (chance4 >= 0.5) {

								Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Ghost.transform.parent = B.transform;

							}
							//enemy
						} else if (chance2 >= 0.65 && chance2 < 0.7) {

							Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
							Deathzoner.transform.parent = B.transform;
							count2 = count2 + 1;

						} else if (chance2 > 0.7) {

							//do nothing
							count2 = count2+1;

						}
					}
					enemycheck = 0;
					count2 = 0;
					count = count + 1;
					B.min = x;
					B.max = x + 4;

					x = x + B.length + 4 + 1;

				}
			} else if (chance >= 0.6 && chance < 0.8) {

				A = Instantiate (PlatformD, new Vector3 (x, 0, 0), Quaternion.identity) as PlatformLength;
				A.tag = id_num.ToString ();
				while (count2 < 5) {

					chance2 = Random.value;

					if (chance2 < 0.45) {

						coin = Instantiate (au, new Vector3 (x - 2 + count2, 2f, 0), Quaternion.identity) as Gold;
						coin.transform.parent = A.transform;
						count2 = count2 + 1;


					} else if (chance2 >= 0.45 && chance2 < 0.5) {

						chance3 = Random.value;

						if (chance3 < 0.2) {

							Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 2f, 0), Quaternion.identity) as GameObject;
							Sniper.transform.parent = A.transform;
							count2 = count2 + 1;

						} else if (chance3 >= 0.2 && chance3 < 0.4) {

							Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 2f, 0), Quaternion.identity) as GameObject;
							Hulk.transform.parent = A.transform;
							count2 = count2 + 1;
						} else if (chance3 >= 0.4 && chance3 < 0.6) {

							Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 2f, 0), Quaternion.identity) as GameObject;
							Money.transform.parent = A.transform;
							count2 = count2 + 1;
						} else if (chance3 >= 0.6 && chance3 < 0.8) {

							LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 2f, 0), Quaternion.identity) as GameObject;
							LongJump.transform.parent = A.transform;
							count2 = count2 + 1;
						} else if (chance3 >= 0.8) {

							Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 2f, 0), Quaternion.identity) as GameObject;
							Teleport.transform.parent = A.transform;
							count2 = count2 + 1;
						}
						//powerup
					} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

						chance4 = Random.value;

						if (chance4 < 0.2) {

							Patroler = Instantiate (Patrol, new Vector3 (x, 2.25f, 0), Quaternion.identity) as enemy3;
							Patroler.min = x - 4.5f;
							Patroler.max = x + 4.5f;
							Patroler.transform.parent = A.transform;
							enemycheck = 1;

							count2 = count2 + 1;

						} else if (chance4 >= 0.2 && chance4 < 0.4) {

							Bomber = Instantiate (Bomb, new Vector3 (x, 7.25f, 0), Quaternion.identity) as enemy4;
							Bomber.min = x - 4.5f;
							Bomber.max = x + 4.5f;
							Bomber.transform.parent = A.transform;
							count2 = count2 + 1;
							enemycheck = 1;

						} else if (chance4 >= 0.4 && chance4 < 0.6) {

							thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 2.25f, 0), Quaternion.identity) as GameObject;
							count2 = count2 + 1;
							enemycheck = 1;
							thrower.transform.parent = A.transform;

						} else if (chance4 >= 0.6 && chance4 < 0.8) {

							Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 2.25f, 0), Quaternion.identity) as GameObject;
							count2 = count2 + 1;
							enemycheck = 1;
							Ghost.transform.parent = A.transform;

						} else if (chance4 >= 0.8) {

							Exploder = Instantiate (Exploders, new Vector3 (x - 2 + count2, 2.25f, 0), Quaternion.identity) as GameObject;
							count2 = count2 + 1;
							enemycheck = 1;
							Exploder.tag = id_num.ToString ();

							//enemy
						}
						//enemy
					} else if (chance2 >= 0.65 && chance2 < 0.7) {

						Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 2.25f, 0), Quaternion.identity) as GameObject;
						Deathzoner.transform.parent = A.transform;
						count2 = count2 + 1;

					} else if (chance2 > 0.7) {

						//do nothing
						count2 = count2+1;

					}
				}
				enemycheck = 0;
				count2 = 0;
				x = x + A.length + 1;

				count = count + 1;
			} else if (chance >= 0.8) {

				A = Instantiate (PlatformE, new Vector3 (x, 0, 0), Quaternion.identity) as PlatformLength;
				A.tag = id_num.ToString ();
				while (count2 < 5) {

					chance2 = Random.value;

					if (chance2 < 0.45) {

						coin = Instantiate (au, new Vector3 (x - 2 + count2, 3f, 0), Quaternion.identity) as Gold;
						coin.transform.parent = A.transform;
						count2 = count2 + 1;


					} else if (chance2 >= 0.45 && chance2 < 0.5) {

						chance3 = Random.value;

						if (chance3 < 0.2) {

							Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 3f, 0), Quaternion.identity) as GameObject;
							Sniper.transform.parent = A.transform;
							count2 = count2 + 1;

						} else if (chance3 >= 0.2 && chance3 < 0.4) {

							Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 3f, 0), Quaternion.identity) as GameObject;
							Hulk.transform.parent = A.transform;
							count2 = count2 + 1;
						} else if (chance3 >= 0.4 && chance3 < 0.6) {

							Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 3f, 0), Quaternion.identity) as GameObject;
							Money.transform.parent = A.transform;
							count2 = count2 + 1;
						} else if (chance3 >= 0.6 && chance3 < 0.8) {

							LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 3f, 0), Quaternion.identity) as GameObject;
							LongJump.transform.parent = A.transform;
							count2 = count2 + 1;
						} else if (chance3 >= 0.8) {

							Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 3f, 0), Quaternion.identity) as GameObject;
							Teleport.transform.parent = A.transform;
							count2 = count2 + 1;
						}
						//powerup
					} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

						chance4 = Random.value;

						if (chance4 < 0.2) {

							Patroler = Instantiate (Patrol, new Vector3 (x, 3.25f, 0), Quaternion.identity) as enemy3;
							Patroler.min = x - 4.5f;
							Patroler.max = x + 4.5f;
							Patroler.transform.parent = A.transform;
							enemycheck = 1;

							count2 = count2 + 1;

						} else if (chance4 >= 0.2 && chance4 < 0.4) {

							Bomber = Instantiate (Bomb, new Vector3 (x, 8.25f, 0), Quaternion.identity) as enemy4;
							Bomber.min = x - 4.5f;
							Bomber.max = x + 4.5f;
							Bomber.transform.parent = A.transform;
							count2 = count2 + 1;
							enemycheck = 1;

						} else if (chance4 >= 0.4 && chance4 < 0.6) {

							thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 3.25f, 0), Quaternion.identity) as GameObject;
							count2 = count2 + 1;
							enemycheck = 1;
							thrower.transform.parent = A.transform;

						} else if (chance4 >= 0.6 && chance4 < 0.8) {

							Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 3.25f, 0), Quaternion.identity) as GameObject;
							count2 = count2 + 1;
							enemycheck = 1;
							Ghost.transform.parent = A.transform;

						} else if (chance4 >= 0.8) {

							Exploder = Instantiate (Exploders, new Vector3 (x - 2 + count2, 3.25f, 0), Quaternion.identity) as GameObject;
							count2 = count2 + 1;
							enemycheck = 1;
							Exploder.tag = id_num.ToString ();

							//enemy
						}
						//enemy
					} else if (chance2 >= 0.65 && chance2 < 0.7) {

						Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 3.25f, 0), Quaternion.identity) as GameObject;
						Deathzoner.transform.parent = A.transform;
						count2 = count2 + 1;

					} else if (chance2 > 0.7) {

						//do nothing
						count2 = count2+1;

					}
				}
				enemycheck = 0;
				count2 = 0;
				x = x + A.length + 1;

				count = count + 1;
			}


		}
		level_size = x;
		count = 0;
		id_num = id_num + 1;

	}

	void Update () {

		if (player.transform.position.x >= (total + (level_size / 2)) && id_num <= 10) {

			while (count < 5) {

				chance = Random.value;

				if (chance < 0.2) {

					A = Instantiate (PlatformA, new Vector3 (x, 0, 0), Quaternion.identity) as PlatformLength;
					A.tag = id_num.ToString ();

					while (count2 < 5) {

						chance2 = Random.value;

						if (chance2 < 0.45) {


							coin = Instantiate (au, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as Gold;
							coin.transform.parent = A.transform;
							count2 = count2 + 1;


						} else if (chance2 >= 0.45 && chance2 < 0.5) {

							chance3 = Random.value;

							if (chance3 < 0.2) {

								Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Sniper.transform.parent = A.transform;
								count2 = count2 + 1;

							} else if (chance3 >= 0.2 && chance3 < 0.4) {

								Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Hulk.transform.parent = A.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.4 && chance3 < 0.6) {

								Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Money.transform.parent = A.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.6 && chance3 < 0.8) {

								LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								LongJump.transform.parent = A.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.8) {

								Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
								Teleport.transform.parent = A.transform;
								count2 = count2 + 1;
							}

						} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

							chance4 = Random.value;

							if (chance4 < 0.2) {

								Patroler = Instantiate (Patrol, new Vector3 (x, 1.25f, 0), Quaternion.identity) as enemy3;
								Patroler.min = x - 4.5f;
								Patroler.max = x + 4.5f;
								Patroler.transform.parent = A.transform;
								enemycheck = 1;

								count2 = count2 + 1;

							} else if (chance4 >= 0.2 && chance4 < 0.4) {

								Bomber = Instantiate (Bomb, new Vector3 (x, 6.25f, 0), Quaternion.identity) as enemy4;
								Bomber.min = x - 4.5f;
								Bomber.max = x + 4.5f;
								Bomber.transform.parent = A.transform;
								count2 = count2 + 1;
								enemycheck = 1;

							} else if (chance4 >= 0.4 && chance4 < 0.6) {

								thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								thrower.transform.parent = A.transform;

							} else if (chance4 >= 0.6 && chance4 < 0.8) {

								Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Ghost.transform.parent = A.transform;

							} else if (chance4 >= 0.8) {

								Exploder = Instantiate (Exploders, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Exploder.tag = id_num.ToString ();
								//Exploder.transform.parent = A.transform;

							}

							//enemy
						} else if (chance2 >= 0.65 && chance2 < 0.7) {

							Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
							Deathzoner.transform.parent = A.transform;
							count2 = count2 + 1;

						} else if (chance2 > 0.7) {

							//do nothing
							count2 = count2+1;

						}
					}
					enemycheck = 0;
					count2 = 0;
					x = x + A.length + 1;

					count = count + 1;

				} else if (chance >= 0.20 && chance < 0.4) {

					if (C == null) {

						C = Instantiate (PlatformB, new Vector3 (x, 0, 0), Quaternion.identity) as UpDown;
						C.tag = id_num.ToString ();
						while (count2 < 5) {

							chance2 = Random.value;

							if (chance2 < 0.45) {


								coin = Instantiate (au, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as Gold;
								coin.transform.parent = C.transform;
								count2 = count2 + 1;


							} else if (chance2 >= 0.45 && chance2 < 0.5) {

								chance3 = Random.value;

								if (chance3 < 0.2) {

									Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Sniper.transform.parent = C.transform;
									count2 = count2 + 1;

								} else if (chance3 >= 0.2 && chance3 < 0.4) {

									Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Hulk.transform.parent = C.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.4 && chance3 < 0.6) {

									Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Money.transform.parent = C.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.6 && chance3 < 0.8) {

									LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									LongJump.transform.parent = C.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.8) {

									Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Teleport.transform.parent = C.transform;
									count2 = count2 + 1;
								}
							} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

								chance4 = Random.value;

								if (chance4 < 0.2) {

									Patroler = Instantiate (Patrol, new Vector3 (x, 1.25f, 0), Quaternion.identity) as enemy3;
									Patroler.min = x - 4.5f;
									Patroler.max = x + 4.5f;
									Patroler.transform.parent = C.transform;
									enemycheck = 1;

									count2 = count2 + 1;

								} else if (chance4 >= 0.2 && chance4 < 0.4) {

									Bomber = Instantiate (Bomb, new Vector3 (x, 6.25f, 0), Quaternion.identity) as enemy4;
									Bomber.min = x - 4.5f;
									Bomber.max = x + 4.5f;
									Bomber.transform.parent = C.transform;
									count2 = count2 + 1;
									enemycheck = 1;

								} else if (chance4 >= 0.4 && chance4 < 0.6) {

									thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									thrower.transform.parent = C.transform;

								} else if (chance4 >= 0.6 && chance4 < 0.8) {

									Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									Ghost.transform.parent = C.transform;

								} else if (chance4 >= 0.8) {

									Exploder = Instantiate (Exploders, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									Exploder.tag = id_num.ToString ();

									//enemy
								}
							} else if (chance2 >= 0.65 && chance2 < 0.7) {

								Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								Deathzoner.transform.parent = C.transform;
								count2 = count2 + 1;

							} else if (chance2 > 0.7) {

								//do nothing
								count2 = count2+1;

							}
						}
						enemycheck = 0;
						count2 = 0;
						x = x + C.length + 1;

						count = count + 1;

					} else if (C.speed == 1.0f) {

						C = Instantiate (PlatformB, new Vector3 (x, 4, 0), Quaternion.identity) as UpDown;
						C.tag = id_num.ToString ();
						while (count2 < 5) {

							chance2 = Random.value;

							if (chance2 < 0.45) {


								coin = Instantiate (au, new Vector3 (x - 2 + count2, 5f, 0), Quaternion.identity) as Gold;
								coin.transform.parent = C.transform;
								count2 = count2 + 1;


							} else if (chance2 >= 0.45 && chance2 < 0.5) {

								chance3 = Random.value;

								if (chance3 < 0.2) {

									Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 5f, 0), Quaternion.identity) as GameObject;
									Sniper.transform.parent = C.transform;
									count2 = count2 + 1;

								} else if (chance3 >= 0.2 && chance3 < 0.4) {

									Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 5f, 0), Quaternion.identity) as GameObject;
									Hulk.transform.parent = C.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.4 && chance3 < 0.6) {

									Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 5f, 0), Quaternion.identity) as GameObject;
									Money.transform.parent = C.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.6 && chance3 < 0.8) {

									LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 5f, 0), Quaternion.identity) as GameObject;
									LongJump.transform.parent = C.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.8) {

									Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 5f, 0), Quaternion.identity) as GameObject;
									Teleport.transform.parent = C.transform;
									count2 = count2 + 1;
								}
								//powerup
							} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

								chance4 = Random.value;

								if (chance4 < 0.2) {

									Patroler = Instantiate (Patrol, new Vector3 (x, 5.25f, 0), Quaternion.identity) as enemy3;
									Patroler.min = x - 4.5f;
									Patroler.max = x + 4.5f;
									Patroler.transform.parent = C.transform;
									enemycheck = 1;

									count2 = count2 + 1;

								} else if (chance4 >= 0.2 && chance4 < 0.4) {

									Bomber = Instantiate (Bomb, new Vector3 (x, 10.25f, 0), Quaternion.identity) as enemy4;
									Bomber.min = x - 4.5f;
									Bomber.max = x + 4.5f;
									Bomber.transform.parent = C.transform;
									count2 = count2 + 1;
									enemycheck = 1;

								} else if (chance4 >= 0.4 && chance4 < 0.6) {

									thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 5.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									thrower.transform.parent = C.transform;

								} else if (chance4 >= 0.6 && chance4 < 0.8) {

									Ghost = Instantiate (Ghosts ,new Vector3 (x - 2 + count2, 5.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									Ghost.transform.parent = C.transform;

								} else if (chance4 >= 0.8) {

									Exploder = Instantiate (Exploders, new Vector3 (x - 2 + count2, 5.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									Exploder.tag = id_num.ToString ();

									//enemy
								}
								//enemy
							} else if (chance2 >= 0.65 && chance2 < 0.7) {

								Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 5.25f, 0), Quaternion.identity) as GameObject;
								Deathzoner.transform.parent = C.transform;
								count2 = count2 + 1;

							} else if (chance2 > 0.7) {

								//do nothing
								count2 = count2+1;

							}
						}
						enemycheck = 0;
						count2 = 0;
						x = x + C.length + 1;
						C.speed = -1.0f;
						count = count + 1;


					} else if (C.speed == -1.0f) {

						C = Instantiate (PlatformB, new Vector3 (x, 0, 0), Quaternion.identity) as UpDown;
						C.tag = id_num.ToString ();
						while (count2 < 5) {

							chance2 = Random.value;

							if (chance2 < 0.45) {

								coin = Instantiate (au, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as Gold;
								coin.transform.parent = C.transform;
								count2 = count2 + 1;


							} else if (chance2 >= 0.45 && chance2 < 0.5) {

								chance3 = Random.value;

								if (chance3 < 0.2) {

									Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Sniper.transform.parent = C.transform;
									count2 = count2 + 1;

								} else if (chance3 >= 0.2 && chance3 < 0.4) {

									Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Hulk.transform.parent = C.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.4 && chance3 < 0.6) {

									Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Money.transform.parent = C.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.6 && chance3 < 0.8) {

									LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									LongJump.transform.parent = C.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.8) {

									Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Teleport.transform.parent = C.transform;
									count2 = count2 + 1;
								}
								//powerup
							} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

								chance4 = Random.value;

								if (chance4 < 0.2) {

									Patroler = Instantiate (Patrol, new Vector3 (x, 1.25f, 0), Quaternion.identity) as enemy3;
									Patroler.min = x - 4.5f;
									Patroler.max = x + 4.5f;
									Patroler.transform.parent = C.transform;
									enemycheck = 1;

									count2 = count2 + 1;

								} else if (chance4 >= 0.2 && chance4 < 0.4) {

									Bomber = Instantiate (Bomb, new Vector3 (x, 6.25f, 0), Quaternion.identity) as enemy4;
									Bomber.min = x - 4.5f;
									Bomber.max = x + 4.5f;
									Bomber.transform.parent = C.transform;
									count2 = count2 + 1;
									enemycheck = 1;

								} else if (chance4 >= 0.4 && chance4 < 0.6) {

									thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									thrower.transform.parent = C.transform;

								} else if (chance4 >= 0.6 && chance4 < 0.8) {

									Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									Ghost.transform.parent = C.transform;

								} else if (chance4 >= 0.8) {

									Exploder = Instantiate (Exploders, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									Exploder.tag = id_num.ToString ();

									//enemy
								}
								//enemy
							} else if (chance2 >= 0.65 && chance2 < 0.7) {

								Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								Deathzoner.transform.parent = C.transform;
								count2 = count2 + 1;

							} else if (chance2 > 0.7) {

								//do nothing
								count2 = count2+1;

							}
						}
						enemycheck = 0;
						count2 = 0;
						x = x + C.length + 1;
						count = count + 1;


					}

				} else if (chance >= 0.4 && chance < 0.6) {

					if (B == null) {

						B = Instantiate (PlatformC, new Vector3 (x, 0, 0), Quaternion.identity) as LeftRight;
						B.tag = id_num.ToString ();
						while (count2 < 5) {

							chance2 = Random.value;

							if (chance2 < 0.45) {

								coin = Instantiate (au, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as Gold;
								coin.transform.parent = B.transform;
								count2 = count2 + 1;


							} else if (chance2 >= 0.45 && chance2 < 0.5) {

								chance3 = Random.value;

								if (chance3 < 0.2) {

									Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Sniper.transform.parent = B.transform;
									count2 = count2 + 1;

								} else if (chance3 >= 0.2 && chance3 < 0.4) {

									Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Hulk.transform.parent = B.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.4 && chance3 < 0.6) {

									Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Money.transform.parent = B.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.6 && chance3 < 0.8) {

									LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									LongJump.transform.parent = B.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.8) {

									Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Teleport.transform.parent = B.transform;
									count2 = count2 + 1;
								}
								//powerup
							} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

								if (chance4 < 0.5) {

									thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									thrower.transform.parent = B.transform;

								} else if (chance4 >= 0.5) {

									Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									Ghost.transform.parent = B.transform;

								}
								//enemy
							} else if (chance2 >= 0.65 && chance2 < 0.7) {

								Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								Deathzoner.transform.parent = B.transform;
								count2 = count2 + 1;

							} else if (chance2 > 0.7) {

								//do nothing
								count2 = count2+1;

							}
						}
						enemycheck = 0;
						count2 = 0;
						count = count + 1;
						B.min = x;
						B.max = x + 4;

						x = x + B.length + 4 + 1;


					} else if (B.speed == 1.0f) {

						B = Instantiate (PlatformC, new Vector3 (x + 4, 0, 0), Quaternion.identity) as LeftRight;
						B.tag = id_num.ToString ();
						while (count2 < 5) {

							chance2 = Random.value;

							if (chance2 < 0.45) {

								coin = Instantiate (au, new Vector3 (x - 2 + count2 + 4, 1f, 0), Quaternion.identity) as Gold;
								coin.transform.parent = B.transform;
								count2 = count2 + 1;


							} else if (chance2 >= 0.45 && chance2 < 0.5) {

								chance3 = Random.value;

								if (chance3 < 0.2) {

									Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2 + 4, 1f, 0), Quaternion.identity) as GameObject;
									Sniper.transform.parent = B.transform;
									count2 = count2 + 1;

								} else if (chance3 >= 0.2 && chance3 < 0.4) {

									Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2 + 4, 1f, 0), Quaternion.identity) as GameObject;
									Hulk.transform.parent = B.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.4 && chance3 < 0.6) {

									Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2 + 4, 1f, 0), Quaternion.identity) as GameObject;
									Money.transform.parent = B.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.6 && chance3 < 0.8) {

									LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2 + 4, 1f, 0), Quaternion.identity) as GameObject;
									LongJump.transform.parent = B.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.8) {

									Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2 + 4, 1f, 0), Quaternion.identity) as GameObject;
									Teleport.transform.parent = B.transform;
									count2 = count2 + 1;
								}
								//powerup
							} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

								if (chance4 < 0.5) {

									thrower = Instantiate (throws, new Vector3 (x - 2 + count2 + 4, 1.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									thrower.transform.parent = B.transform;

								} else if (chance4 >= 0.5) {

									Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2 + 4, 1.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									Ghost.transform.parent = B.transform;

								}
								//enemy
							} else if (chance2 >= 0.65 && chance2 < 0.7) {

								Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2 + 4, 1.25f, 0), Quaternion.identity) as GameObject;
								Deathzoner.transform.parent = B.transform;
								count2 = count2 + 1;

							} else if (chance2 > 0.7) {

								//do nothing
								count2 = count2+1;

							}
						}
						enemycheck = 0;
						count2 = 0;

						count2 = 0;
						count = count + 1;
						B.min = x;
						B.max = x + 4;

						B.speed = -1.0f;

						x = x + B.length + 4 + 1;


					} else if (B.speed == -1.0f) {

						B = Instantiate (PlatformC, new Vector3 (x, 0, 0), Quaternion.identity) as LeftRight;
						B.tag = id_num.ToString ();
						while (count2 < 5) {

							chance2 = Random.value;

							if (chance2 < 0.45) {

								coin = Instantiate (au, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as Gold;
								coin.transform.parent = B.transform;
								count2 = count2 + 1;


							} else if (chance2 >= 0.45 && chance2 < 0.5) {

								chance3 = Random.value;

								if (chance3 < 0.2) {

									Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Sniper.transform.parent = B.transform;
									count2 = count2 + 1;

								} else if (chance3 >= 0.2 && chance3 < 0.4) {

									Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Hulk.transform.parent = B.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.4 && chance3 < 0.6) {

									Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Money.transform.parent = B.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.6 && chance3 < 0.8) {

									LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									LongJump.transform.parent = B.transform;
									count2 = count2 + 1;
								} else if (chance3 >= 0.8) {

									Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 1f, 0), Quaternion.identity) as GameObject;
									Teleport.transform.parent = B.transform;
									count2 = count2 + 1;
								}

								//powerup
							} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

								if (chance4 < 0.5) {

									thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									thrower.transform.parent = B.transform;

								} else if (chance4 >= 0.5) {

									Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
									count2 = count2 + 1;
									enemycheck = 1;
									Ghost.transform.parent = B.transform;

								}
								//enemy
							} else if (chance2 >= 0.65 && chance2 < 0.7) {

								Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 1.25f, 0), Quaternion.identity) as GameObject;
								Deathzoner.transform.parent = B.transform;
								count2 = count2 + 1;

							} else if (chance2 > 0.7) {

								//do nothing
								count2 = count2+1;

							}
						}
						enemycheck = 0;
						count2 = 0;
						count = count + 1;
						B.min = x;
						B.max = x + 4;

						x = x + B.length + 4 + 1;

					}
				} else if (chance >= 0.6 && chance < 0.8) {

					A = Instantiate (PlatformD, new Vector3 (x, 0, 0), Quaternion.identity) as PlatformLength;
					A.tag = id_num.ToString ();
					while (count2 < 5) {

						chance2 = Random.value;

						if (chance2 < 0.45) {

							coin = Instantiate (au, new Vector3 (x - 2 + count2, 2f, 0), Quaternion.identity) as Gold;
							coin.transform.parent = A.transform;
							count2 = count2 + 1;


						} else if (chance2 >= 0.45 && chance2 < 0.5) {

							chance3 = Random.value;

							if (chance3 < 0.2) {

								Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 2f, 0), Quaternion.identity) as GameObject;
								Sniper.transform.parent = A.transform;
								count2 = count2 + 1;

							} else if (chance3 >= 0.2 && chance3 < 0.4) {

								Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 2f, 0), Quaternion.identity) as GameObject;
								Hulk.transform.parent = A.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.4 && chance3 < 0.6) {

								Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 2f, 0), Quaternion.identity) as GameObject;
								Money.transform.parent = A.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.6 && chance3 < 0.8) {

								LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 2f, 0), Quaternion.identity) as GameObject;
								LongJump.transform.parent = A.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.8) {

								Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 2f, 0), Quaternion.identity) as GameObject;
								Teleport.transform.parent = A.transform;
								count2 = count2 + 1;
							}
							//powerup
						} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

							chance4 = Random.value;

							if (chance4 < 0.2) {

								Patroler = Instantiate (Patrol, new Vector3 (x, 2.25f, 0), Quaternion.identity) as enemy3;
								Patroler.min = x - 4.5f;
								Patroler.max = x + 4.5f;
								Patroler.transform.parent = A.transform;
								enemycheck = 1;

								count2 = count2 + 1;

							} else if (chance4 >= 0.2 && chance4 < 0.4) {

								Bomber = Instantiate (Bomb, new Vector3 (x, 7.25f, 0), Quaternion.identity) as enemy4;
								Bomber.min = x - 4.5f;
								Bomber.max = x + 4.5f;
								Bomber.transform.parent = A.transform;
								count2 = count2 + 1;
								enemycheck = 1;

							} else if (chance4 >= 0.4 && chance4 < 0.6) {

								thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 2.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								thrower.transform.parent = A.transform;

							} else if (chance4 >= 0.6 && chance4 < 0.8) {

								Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 2.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Ghost.transform.parent = A.transform;

							} else if (chance4 >= 0.8) {

								Exploder = Instantiate (Exploders, new Vector3 (x - 2 + count2, 2.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Exploder.tag = id_num.ToString ();

								//enemy
							}
							//enemy
						} else if (chance2 >= 0.65 && chance2 < 0.7) {

							Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 2.25f, 0), Quaternion.identity) as GameObject;
							Deathzoner.transform.parent = A.transform;
							count2 = count2 + 1;

						} else if (chance2 > 0.7) {

							//do nothing
							count2 = count2+1;

						}
					}
					enemycheck = 0;
					count2 = 0;
					x = x + A.length + 1;

					count = count + 1;
				} else if (chance >= 0.8) {

					A = Instantiate (PlatformE, new Vector3 (x, 0, 0), Quaternion.identity) as PlatformLength;
					A.tag = id_num.ToString ();
					while (count2 < 5) {

						chance2 = Random.value;

						if (chance2 < 0.45) {

							coin = Instantiate (au, new Vector3 (x - 2 + count2, 3f, 0), Quaternion.identity) as Gold;
							coin.transform.parent = A.transform;
							count2 = count2 + 1;


						} else if (chance2 >= 0.45 && chance2 < 0.5) {

							chance3 = Random.value;

							if (chance3 < 0.2) {

								Sniper = Instantiate (Sniperpowerup, new Vector3 (x - 2 + count2, 3f, 0), Quaternion.identity) as GameObject;
								Sniper.transform.parent = A.transform;
								count2 = count2 + 1;

							} else if (chance3 >= 0.2 && chance3 < 0.4) {

								Hulk = Instantiate (Hulkpowerup, new Vector3 (x - 2 + count2, 3f, 0), Quaternion.identity) as GameObject;
								Hulk.transform.parent = A.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.4 && chance3 < 0.6) {

								Money = Instantiate (Moneypowerup, new Vector3 (x - 2 + count2, 3f, 0), Quaternion.identity) as GameObject;
								Money.transform.parent = A.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.6 && chance3 < 0.8) {

								LongJump = Instantiate (LongJumppowerup, new Vector3 (x - 2 + count2, 3f, 0), Quaternion.identity) as GameObject;
								LongJump.transform.parent = A.transform;
								count2 = count2 + 1;
							} else if (chance3 >= 0.8) {

								Teleport = Instantiate (Teleportpowerup, new Vector3 (x - 2 + count2, 3f, 0), Quaternion.identity) as GameObject;
								Teleport.transform.parent = A.transform;
								count2 = count2 + 1;
							}
							//powerup
						} else if (chance2 >= 0.5 && chance2 < 0.65 && enemycheck == 0) {

							chance4 = Random.value;

							if (chance4 < 0.2) {

								Patroler = Instantiate (Patrol, new Vector3 (x, 3.25f, 0), Quaternion.identity) as enemy3;
								Patroler.min = x - 4.5f;
								Patroler.max = x + 4.5f;
								Patroler.transform.parent = A.transform;
								enemycheck = 1;

								count2 = count2 + 1;

							} else if (chance4 >= 0.2 && chance4 < 0.4) {

								Bomber = Instantiate (Bomb, new Vector3 (x, 8.25f, 0), Quaternion.identity) as enemy4;
								Bomber.min = x - 4.5f;
								Bomber.max = x + 4.5f;
								Bomber.transform.parent = A.transform;
								count2 = count2 + 1;
								enemycheck = 1;

							} else if (chance4 >= 0.4 && chance4 < 0.6) {

								thrower = Instantiate (throws, new Vector3 (x - 2 + count2, 3.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								thrower.transform.parent = A.transform;

							} else if (chance4 >= 0.6 && chance4 < 0.8) {

								Ghost = Instantiate (Ghosts, new Vector3 (x - 2 + count2, 3.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Ghost.transform.parent = A.transform;

							} else if (chance4 >= 0.8) {

								Exploder = Instantiate (Exploders, new Vector3 (x - 2 + count2, 3.25f, 0), Quaternion.identity) as GameObject;
								count2 = count2 + 1;
								enemycheck = 1;
								Exploder.tag = id_num.ToString ();

								//enemy
							}
							//enemy
						} else if (chance2 >= 0.65 && chance2 < 0.7) {

							Deathzoner = Instantiate (Deathzone, new Vector3 (x - 2 + count2, 3.25f, 0), Quaternion.identity) as GameObject;
							Deathzoner.transform.parent = A.transform;
							count2 = count2 + 1;

						} else if (chance2 > 0.7) {

							//do nothing
							count2 = count2+1;

						}
					}
					enemycheck = 0;
					count2 = 0;
					x = x + A.length + 1;

					count = count + 1;
				}


			}
			total = total + level_size;
			level_size = x - total;
			count = 0;
			id_num = id_num + 1;
		} else if (id_num == 11 && endcheck == 0) {

			Instantiate (end, new Vector3 (x, 0, 0), Quaternion.identity);
			endcheck = 1;
			//id_num = id_num + 1;
		}

	}
}
