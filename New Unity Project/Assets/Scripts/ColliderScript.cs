using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    private Testscript testScript;
   
    // Start is called before the first frame update
    void Start()
    {

        GameObject tank = GameObject.Find("Tank_Location");
        Testscript testScript = tank.GetComponent<Testscript>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            testScript.checkFire = true;
        }
        else
        {
            testScript.checkFire = false;
        }
    }
}
