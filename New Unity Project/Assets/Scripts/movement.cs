using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{

    public Rigidbody rb;

    private Transform[] target = new Transform[4];

    public float speed;

    private int current;

    public Text gameOver;

    GameObject theGround;
    Testscript groundTestScript;

    // Start is called before the first frame update
    void Start()
    {
        theGround = GameObject.Find("Ground");
        groundTestScript = theGround.GetComponent<Testscript>();

        GameObject enemyMovement1 = GameObject.Find("EnemyMovement_1");
        GameObject enemyMovement2 = GameObject.Find("EnemyMovement_2");
        GameObject enemyMovement3 = GameObject.Find("EnemyMovement_3");
        GameObject enemyMovement4 = GameObject.Find("EnemyMovement_4");

        gameOver = GameObject.Find("gameOver").GetComponent<Text>();

        target[0] = enemyMovement1.transform;
        target[1] = enemyMovement2.transform;
        target[2] = enemyMovement3.transform;
        target[3] = enemyMovement4.transform;


        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        { 
            current = (current + 1) % target.Length;
        }

        //Jake code for moving object.
        // transform.Translate(Vector3.forward * speed);

        //rb.AddForce(movement * speed);
    }

    // Jake code for deleting ball if we hit the blue circle.

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Endpoint"))
        {
            gameObject.SetActive(false);

            GameManager.lives -= 1;
            print(GameManager.lives);
            if (GameManager.lives == 0)
            {
                gameOver.text = "Game Over!";
            }


        }
    }

}
