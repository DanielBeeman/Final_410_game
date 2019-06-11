using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{

    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public int count;
    public Text gameOver;
    public float spwndel;


    public static event Action EnemySpawned;

    Vector3 height = new Vector3(0.0f, 0.5f, 0.0f);
    public GameObject StartLocation;


    // Start is called before the first frame update
    void Start()
    {
        gameOver = GameObject.Find("gameOver").GetComponent<Text>();
        gameOver.text = "Enemies will spawn in 5 seconds!";
        //InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        Invoke("SpawnObject", spawnDelay);
    }

    public void SpawnObject()
    {
        gameOver.text = "";
        if (GameManager.enemies > 0)
        {
            spwndel = UnityEngine.Random.Range(2.0f, 6.0f);
            GameManager.enemies -= 1;
            GameObject clone = (GameObject)Instantiate(spawnee, StartLocation.transform.position + height, StartLocation.transform.rotation);
            EnemySpawned();
            Invoke("SpawnObject", spwndel);
        }
        //print(spwndel);




    }


}
