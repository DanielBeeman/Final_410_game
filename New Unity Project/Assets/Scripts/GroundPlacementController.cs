//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GroundPlacementController : MonoBehaviour
//{
//    [SerializeField]
//    private GameObject placeableObjectPrefab;

//    [SerializeField]
//    private KeyCode newObjectHotkey = KeyCode.A;

//    [SerializeField]
//    private GameObject bullet;

//    private GameObject currentPlaceableObject;

//    private GameObject mesh;

//    private int clickCount;



//    float firerate;
//    float nextFire;

//    private void Start()
//    {
//        firerate = 1f;
//        nextFire = Time.time;
//    }


//    // Update is called once per frame
//    private void Update()
//    {

//        CheckIfTimeToFire();

//        HandleNewObjectHotkey();

//        if (currentPlaceableObject != null)
//        {
//            MoveCurrentPlaceableObjectToMouse();
//            ReleaseIfClicked();
//        }
//    }

//    private void CheckIfTimeToFire()
//    {
//        if (Time.time > nextFire)
//        {
//            Instantiate(bullet, transform.position, Quaternion.identity);
//            nextFire = Time.time + firerate;
//        }
//    }

//    private void ReleaseIfClicked()
//    {
//        if (Input.GetMouseButtonDown(0))
//        {
//            //GetComponent<Rigidbody>().useGravity = false;
//            currentPlaceableObject = null;
//        }
//    }

//    private void MoveCurrentPlaceableObjectToMouse()
//    {
//        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

//        RaycastHit hitInfo;

//        GetComponent<MeshCollider>().enabled = true;

//        //GetComponent<Rigidbody>().useGravity = true;

//        if (Physics.Raycast(ray, out hitInfo))
//        {
//            currentPlaceableObject.transform.position = hitInfo.point;
//        }

//    }

//    private void HandleNewObjectHotkey()
//    {
//        if (Input.GetKeyDown(newObjectHotkey))
//        {
//            clickCount += 1;

//            if (clickCount >= 3)
//            {
//                return;
//            }

//            if (currentPlaceableObject == null)
//            {
//                currentPlaceableObject = Instantiate(placeableObjectPrefab);
//            }
//            else
//            {
//                Destroy(currentPlaceableObject);
//            }
//        }
//    }
//}
