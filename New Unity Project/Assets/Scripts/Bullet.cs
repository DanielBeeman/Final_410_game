using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float moveSpeed = 90f;

    Rigidbody rb;
    public float damage;
    public float t;
    
    GameObject[] target;
    GameObject enemyTarget;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        t = Time.time;
        rb = GetComponent<Rigidbody>();

        target = GameObject.FindGameObjectsWithTag("Enemy");
        for(int i = 0; i < target.Length; i++)
        {
            if (Vector3.Distance(target[i].transform.position, transform.position) <= 10)
            {
                enemyTarget = target[i];
            }
        }
        if (enemyTarget != null)
        {
            moveDirection = (enemyTarget.transform.position - transform.position).normalized * moveSpeed;
        }
        rb.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z);
        //Destroy(gameObject, 3f);

    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("Enemy hit!");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //print(Time.time);
        if (Time.time - t > .3)
        {
            Destroy(gameObject);
        }
    }
}
