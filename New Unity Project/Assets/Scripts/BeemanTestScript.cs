using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class BeemanTestScript : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    private float time = 0.0f;
    public float interpolationPeriod = 10.0f;

    //range that enemy must be in to be shot
    public float range = 10;
    public bool checkFire;
    GameObject[] newenemy;
    public int en_count = 0;
    private int spawn_count = 0;

    GameObject theTurret;
    GameObject theTurret2;
    GameObject theTurret3;
    GameObject theTurret4;
    GameObject theTurret5;
    Tank_Location_Script turret;
    Tank_Location_Script turret2;
    Tank_Location_Script turret3;
    Tank_Location_Script turret4;
    Tank_Location_Script turret5;


    void DoThisWhenAnEnemySpawns()
    {
        //creates a game object that finds any singular enemy with a tag enemy
        GameObject theEnemy = GameObject.FindWithTag("Enemy");

        //New enemy is an array of all enemies in the field. 
        newenemy = GameObject.FindGameObjectsWithTag("Enemy");
        //if (newenemy != null)
        //{
        spawn_count += 1;
        print("an enemy is spawned" + spawn_count);
        InvokeRepeating("Shoot", 0.3f, 0.1f);
        //}


        //Shoot();
        //if the array of enemies is not null
        /*
        if (newenemy != null && en_count < 2)
        {
            en_count += 1;
            //print("alive!");
            EnemyHealth enemy = theEnemy.GetComponent<EnemyHealth>();

            //print("should be shooting!");
            InvokeRepeating("Shoot", 0.3f, 0.1f);
            en_count -= 1;
        }

*/
    }

    private void OnDestroy()
    {

        Spawner.EnemySpawned -= DoThisWhenAnEnemySpawns;

    }


    // Start is called before the first frame update
    public void Start()
    {

        theTurret = GameObject.Find("Tank_Location");
        turret = theTurret.GetComponent<Tank_Location_Script>();


        theTurret2 = GameObject.Find("Tank_Location_2");
        turret2 = theTurret2.GetComponent<Tank_Location_Script>();

        theTurret3 = GameObject.Find("TurretTower");
        turret3 = theTurret3.GetComponent<Tank_Location_Script>();

        theTurret4 = GameObject.Find("TurretTower_2");
        turret4 = theTurret4.GetComponent<Tank_Location_Script>();

        theTurret5 = GameObject.Find("TurretTower_3");
        turret5 = theTurret5.GetComponent<Tank_Location_Script>();

        GameObject theTurret6 = GameObject.Find("TurretTower_4");
        Tank_Location_Script turret6 = theTurret6.GetComponent<Tank_Location_Script>();

        GameObject theTurret7 = GameObject.Find("TurretTower_5");
        Tank_Location_Script turret7 = theTurret7.GetComponent<Tank_Location_Script>();

        GameObject theTurret8 = GameObject.Find("Tank_Location_3");
        Tank_Location_Script turret8 = theTurret8.GetComponent<Tank_Location_Script>();

        GameObject theTurret9 = GameObject.Find("TurretTower_6");
        Tank_Location_Script turret9 = theTurret9.GetComponent<Tank_Location_Script>();

        GameObject theTurret10 = GameObject.Find("TurretTower_7");
        Tank_Location_Script turret10 = theTurret10.GetComponent<Tank_Location_Script>();

        GameObject theTurret11 = GameObject.Find("TurretTower_8");
        Tank_Location_Script turret11 = theTurret11.GetComponent<Tank_Location_Script>();

        GameObject theTurret12 = GameObject.Find("TurretTower_9");
        Tank_Location_Script turret12 = theTurret12.GetComponent<Tank_Location_Script>();

        GameObject theTurret13 = GameObject.Find("TurretTower_10");
        Tank_Location_Script turret13 = theTurret13.GetComponent<Tank_Location_Script>();

        GameObject theTurret14 = GameObject.Find("TurretTower_11");
        Tank_Location_Script turret14 = theTurret14.GetComponent<Tank_Location_Script>();

        GameObject theTurret15 = GameObject.Find("TurretTower_12");
        Tank_Location_Script turret15 = theTurret15.GetComponent<Tank_Location_Script>();

        GameObject theTurret16 = GameObject.Find("TurretTower_13");
        Tank_Location_Script turret16 = theTurret16.GetComponent<Tank_Location_Script>();

        GameObject theTurret17 = GameObject.Find("TurretTower_14");
        Tank_Location_Script turret17 = theTurret17.GetComponent<Tank_Location_Script>();


        Spawner.EnemySpawned += DoThisWhenAnEnemySpawns;

        checkFire = false;
        time += Time.deltaTime;



        //if (enemy2.alive == true)
        //{
        InvokeRepeating("Shoot", 0.3f, 0.1f);
        //}
    }

    public void Update()
    {

        //GameObject theEnemy = GameObject.FindWithTag("Enemy");

        //bulletPrefab = (Rigidbody)Resources.Load("Prefabs/Bullet", typeof(GameObject));

        //GameObject theEnemy2 = GameObject.Find("Enemy_2");

        //InvokeRepeating("Shoot", 0.3f, 0.1f);

        //EnemyHealth enemy2 = theEnemy2.GetComponent<EnemyHealth>();

        //if (theEnemy != null)
        //{
        //    EnemyHealth enemy = theEnemy.GetComponent<EnemyHealth>();
        //    print(enemy.alive);
        //    if (enemy.alive == true)
        //    {
        //        InvokeRepeating("Shoot", 0.3f, 0.1f);
        //    }
        //}
        //Shoot();
    }

    public void Shoot()
    {

        GameObject theEnemy = GameObject.FindWithTag("Enemy");
        EnemyHealth enemy = theEnemy.GetComponent<EnemyHealth>();

        if ((turret.isPlaced == true))
        {

            if (enemy.alive == true)
            {
                float dist; 
                dist = Vector3.Distance(turret.transform.position, enemy.transform.position);
                        //float dist2 = Vector3.Distance(turret.transform.position, theEnemy2.transform.position);
                
                if (dist <= 10)
                {
                    Instantiate(bulletPrefab, new Vector3(turret.transform.position.x, turret.transform.position.y + 3, turret.transform.position.z), gameObject.transform.rotation);
                }
            }
        }

        if ((turret2.isPlaced == true))
        {

            if (enemy.alive == true)
            {
                float dist = 100;
                for (int i = 0; i < newenemy.Length; i++)
                {
                    if (newenemy[i] != null)
                    {
                        dist = Vector3.Distance(turret2.transform.position, newenemy[i].transform.position);
                        //float dist2 = Vector3.Distance(turret.transform.position, theEnemy2.transform.position);

                        if (dist <= 10)
                        {
                            break;
                        }
                    }
                }
                if (dist <= 10)
                {
                    Instantiate(bulletPrefab, new Vector3(turret2.transform.position.x, turret2.transform.position.y + 3, turret2.transform.position.z), gameObject.transform.rotation);
                }
            }
        }


        if ((turret3.isPlaced == true))
        {

            if (enemy.alive == true)
            {
                float dist = 100;
                for (int i = 0; i < newenemy.Length; i++)
                {
                    if (newenemy[i] != null)
                    {
                        dist = Vector3.Distance(turret3.transform.position, newenemy[i].transform.position);
                        //float dist2 = Vector3.Distance(turret.transform.position, theEnemy2.transform.position);

                        if (dist <= 10)
                        {
                            break;
                        }
                    }
                }
                if (dist <= 10)
                {
                    Instantiate(bulletPrefab, new Vector3(turret3.transform.position.x, turret3.transform.position.y + 3, turret3.transform.position.z), gameObject.transform.rotation);
                }
            }
        }


        if ((turret4.isPlaced == true))
        {

            if (enemy.alive == true)
            {
                float dist = 100;
                for (int i = 0; i < newenemy.Length; i++)
                {
                    if (newenemy[i] != null)
                    {
                        dist = Vector3.Distance(turret4.transform.position, newenemy[i].transform.position);
                        //float dist2 = Vector3.Distance(turret.transform.position, theEnemy2.transform.position);

                        if (dist <= 10)
                        {
                            break;
                        }
                    }
                }
                if (dist <= 10)
                {
                    Instantiate(bulletPrefab, new Vector3(turret4.transform.position.x, turret4.transform.position.y + 3, turret4.transform.position.z), gameObject.transform.rotation);
                }
            }
        }

        if ((turret5.isPlaced == true))
        {

            if (newenemy != null)
            {
                float dist = 100;
                for (int i = 0; i < newenemy.Length; i++)
                {
                    if (newenemy[i] != null)
                    {
                        dist = Vector3.Distance(turret5.transform.position, newenemy[i].transform.position);
                        //float dist2 = Vector3.Distance(turret.transform.position, theEnemy2.transform.position);

                        if (dist <= 10)
                        {
                            break;
                        }
                    }
                }
                if (dist <= 10)
                {
                    Instantiate(bulletPrefab, new Vector3(turret5.transform.position.x, turret5.transform.position.y + 3, turret5.transform.position.z), gameObject.transform.rotation);
                }
            }
        }


        /*
        if ((enemyHealth.alive == true && turret2.isPlaced == true))
        {
            float dist = Vector3.Distance(turret2.transform.position, theEnemy.transform.position);

            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret2.transform.position.x, turret2.transform.position.y + 3, turret2.transform.position.z), gameObject.transform.rotation);
            }

        }

        if ((enemyHealth.alive == true && turret3.isPlaced == true))
        {
            float dist = Vector3.Distance(turret3.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret3.transform.position, theEnemy2.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret3.transform.position.x, turret3.transform.position.y + 3, turret3.transform.position.z), gameObject.transform.rotation);
            //}
            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret3.transform.position.x, turret3.transform.position.y + 3, turret3.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret4.isPlaced == true))
        {
            float dist = Vector3.Distance(turret4.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret4.transform.position, theEnemy2.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret4.transform.position.x, turret4.transform.position.y + 3, turret4.transform.position.z), gameObject.transform.rotation);
            //}

            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret4.transform.position.x, turret4.transform.position.y + 3, turret4.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret5.isPlaced == true))
        {
            float dist = 100;
            GameObject[] newenemy = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < newenemy.Length; i++)
            {
                dist = Vector3.Distance(turret5.transform.position, newenemy[i].transform.position);

                if (dist <= 10)
                {
                    break;
                    Instantiate(bulletPrefab, new Vector3(turret.transform.position.x, turret.transform.position.y + 3, turret.transform.position.z), gameObject.transform.rotation);
                }
            }
            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret5.transform.position.x, turret5.transform.position.y + 3, turret5.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret6.isPlaced == true))
        {
            float dist = Vector3.Distance(turret6.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret6.transform.position, theEnemy2.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret6.transform.position.x, turret6.transform.position.y + 3, turret6.transform.position.z), gameObject.transform.rotation);
            //}

            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret6.transform.position.x, turret6.transform.position.y + 3, turret6.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret7.isPlaced == true))
        {
            float dist = Vector3.Distance(turret7.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret7.transform.position, theEnemy2.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret7.transform.position.x, turret7.transform.position.y + 3, turret7.transform.position.z), gameObject.transform.rotation);
            //}

            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret7.transform.position.x, turret7.transform.position.y + 3, turret7.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret8.isPlaced == true))
        {
            float dist = Vector3.Distance(turret8.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret8.transform.position, theEnemy.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret8.transform.position.x, turret8.transform.position.y + 3, turret8.transform.position.z), gameObject.transform.rotation);
            //}

            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret8.transform.position.x, turret8.transform.position.y + 3, turret8.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret9.isPlaced == true))
        {
            float dist = Vector3.Distance(turret9.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret9.transform.position, theEnemy.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret9.transform.position.x, turret9.transform.position.y + 3, turret9.transform.position.z), gameObject.transform.rotation);
            //}
            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret9.transform.position.x, turret9.transform.position.y + 3, turret9.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret10.isPlaced == true))
        {
            float dist = Vector3.Distance(turret10.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret10.transform.position, theEnemy.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret10.transform.position.x, turret10.transform.position.y + 3, turret10.transform.position.z), gameObject.transform.rotation);
            //}
            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret10.transform.position.x, turret10.transform.position.y + 3, turret10.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret11.isPlaced == true))
        {
            float dist = Vector3.Distance(turret11.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret11.transform.position, theEnemy.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret11.transform.position.x, turret11.transform.position.y + 3, turret11.transform.position.z), gameObject.transform.rotation);
            //}
            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret11.transform.position.x, turret11.transform.position.y + 3, turret11.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret12.isPlaced == true))
        {
            float dist = Vector3.Distance(turret12.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret12.transform.position, theEnemy.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret12.transform.position.x, turret12.transform.position.y + 3, turret12.transform.position.z), gameObject.transform.rotation);
            //}
            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret12.transform.position.x, turret12.transform.position.y + 3, turret12.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret13.isPlaced == true))
        {
            float dist = Vector3.Distance(turret13.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret13.transform.position, theEnemy.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret13.transform.position.x, turret13.transform.position.y + 3, turret13.transform.position.z), gameObject.transform.rotation);
            //}
            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret13.transform.position.x, turret13.transform.position.y + 3, turret13.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret14.isPlaced == true))
        {
            float dist = Vector3.Distance(turret14.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret14.transform.position, theEnemy.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret14.transform.position.x, turret14.transform.position.y + 3, turret14.transform.position.z), gameObject.transform.rotation);
            //}
            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret14.transform.position.x, turret14.transform.position.y + 3, turret14.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret15.isPlaced == true))
        {
            float dist = Vector3.Distance(turret15.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret15.transform.position, theEnemy.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret15.transform.position.x, turret15.transform.position.y + 3, turret15.transform.position.z), gameObject.transform.rotation);
            //}
            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret15.transform.position.x, turret15.transform.position.y + 3, turret15.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret16.isPlaced == true))
        {
            float dist = Vector3.Distance(turret16.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret16.transform.position, theEnemy.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret16.transform.position.x, turret16.transform.position.y + 3, turret16.transform.position.z), gameObject.transform.rotation);
            //}
            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret16.transform.position.x, turret16.transform.position.y + 3, turret16.transform.position.z), gameObject.transform.rotation);
            }
        }

        if ((enemyHealth.alive == true && turret17.isPlaced == true))
        {
            float dist = Vector3.Distance(turret17.transform.position, theEnemy.transform.position);
            //float dist2 = Vector3.Distance(turret17.transform.position, theEnemy.transform.position);

            //if (dist2 <= 10)
            //{
            //    Instantiate(bulletPrefab, new Vector3(turret17.transform.position.x, turret17.transform.position.y + 3, turret17.transform.position.z), gameObject.transform.rotation);
            //}
            if (dist <= 10)
            {
                Instantiate(bulletPrefab, new Vector3(turret17.transform.position.x, turret17.transform.position.y + 3, turret17.transform.position.z), gameObject.transform.rotation);
            }
        }
}

*/

    }
}