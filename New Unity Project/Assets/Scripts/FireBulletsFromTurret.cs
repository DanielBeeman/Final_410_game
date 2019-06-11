using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletsFromTurret : MonoBehaviour
{
    public Rigidbody bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Instantiate(bulletPrefab, gameObject.transform.position, gameObject.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
