using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public GameObject endGame;
    public AudioSource throwBall;

    public float timeBeforeEnd = 10;
    public float ballCount = 20;
    public Text ballLimit;

    private bool canShoot;
    private IEnumerator coroutine;

    void Start()
    {
        ballLimit.text = ballCount + ("");

        canShoot = true;
    }

   public void Shoot()
    {
        if (canShoot)
        {
                GameObject insBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
                Rigidbody insBulletRig = insBullet.GetComponent<Rigidbody>();
                insBulletRig.AddForce(transform.forward * speed);

                ballCount -= 1;
                if (ballCount <= 0)
                {
                    StartCoroutine(Timer());
                    canShoot = false;
                }

                throwBall.Play();
        }
    }

    void Update()
    {


        ballLimit.text = ballCount + ("");
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(7);
        GameOver();

    }

    void GameOver()
    {       
        endGame.SetActive(true);
        Time.timeScale = 0;
        //Destroy(ballLimit);
    }
}
