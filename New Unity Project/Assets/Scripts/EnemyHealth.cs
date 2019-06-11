using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

    public int healthPoints = 100;
    public Bullet bullet;

    private float currentHealthPoints;
    public bool alive;
    public Text gameOver;
    private int count = 0;
    public GameObject pre_enemy;
    GameObject[] enemiesAlive;
    public GameObject expl;
    public AudioClip audclp;

    public RectTransform health_bar;

    // Start is called before the first frame update
    void Start()
    {


        // bullet = (Bullet)Resources.Load("Prefabs/Bullet", typeof(GameObject));

        //pre_enemy = (GameObject)Resources.Load("Prefabs/Enemy", typeof(GameObject));

        //health_bar = (RectTransform)Resources.Load("Prefabs/Enemy/HealthBarCanvas/Background/Foreground", typeof(GameObject));
        gameOver = GameObject.Find("gameOver").GetComponent<Text>();
        currentHealthPoints = healthPoints;
        alive = true;
        //code to call function to spawn new enemies.
        /*
        if (count < 3)
        {
            InvokeRepeating("spawnEnemy", 5.0f, 8.0f);

        }
        */
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loseHp(Bullet b)
    {
        currentHealthPoints = currentHealthPoints - b.damage;
        if (currentHealthPoints <= 0)
        {
            alive = false;
            Destroy(gameObject);

            //explode at the enemy location.
            Instantiate(expl, transform.position, transform.rotation);

            //play the explosion sound where the enemy is
            Instantiate(audclp);

            //this maintains a list of all enemies alive in the scene. 
            enemiesAlive =  GameObject.FindGameObjectsWithTag("Enemy");

            //This checks if zero enemies are to still be spawned, and if all enemies in the scene are dead. 
            if (GameManager.enemies == 0 && enemiesAlive.Length == 1)
            {
                gameOver.text = "You win!";
            }
            GameManager.coinsLeft += 25;
            //gameObject.SetActive(false);
        }

        health_bar.sizeDelta = new Vector2(currentHealthPoints*2, health_bar.sizeDelta.y);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            loseHp(bullet);
        }
    }

    public void spawnEnemy()
    {
        Instantiate(pre_enemy, new Vector3(-.5f, .5f, -6.1f), pre_enemy.transform.rotation);
        count++;
    }
}
