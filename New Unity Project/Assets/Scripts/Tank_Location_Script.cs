using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tank_Location_Script : MonoBehaviour
{
    public int count;
   // CoinTotalScript coins;


    public Color startColor;
    public Color mouseOverColor;
    public Color mouseOverAlreadyPlaced;
    bool mouseOver = false;
    public static GameManager Instance;

    public Testscript ts;
    public bool isPlaced = false;

    // Start is called before the first frame update
    void Start()
    {

        //coins = GetComponent<CoinTotalScript>();
        //coins.coinDecrementer(GameManager.towersPlaced);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        mouseOver = true;
        if (count == 1)
        {
            GetComponent<Renderer>().material.SetColor("_Color", mouseOverAlreadyPlaced);
        }

        else
        {
            GetComponent<Renderer>().material.SetColor("_Color", mouseOverColor);
            //Debug.Log(count);
            if ((Input.GetMouseButtonDown(0) & (count < 1)) & (GameManager.coinsLeft >= 100))
            {

                count += 1;
                PlaceTower();
            }
        }

    }

    private void OnMouseExit()
    {
        mouseOver = false;
        GetComponent<Renderer>().material.SetColor("_Color", startColor);
    }

    private void PlaceTower()
    { 
        Instantiate(GameManager.Instance.towerPrefab, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
        isPlaced = true;
        GameManager.towersPlaced += 1;
        GameManager.coinsLeft = GameManager.coinsLeft - 100;
        //print(GameManager.towersPlaced);
        //coins.coinDecrementer(GameManager.towersPlaced);
        //Debug.Log(transform.position);

        //GameObject bullet = GameObject.Find("Bullet");
        //Testscript ts = bullet.GetComponent<Testscript>();
        //Debug.Log(ts);
        //ts.Shoot();


        //ts.Shoot();


    }
    /*
    void coinDecrementer()
    {

       
        coins = 400 - (count * 100);
        coinText.text = "Count: " + coins.ToString();
        Debug.Log("hiiiii");
       
        //GameManager.coinsLeft -= 100;
        //Instance.coinText.text = GameManager.coinsLeft.ToString() + " coins";
    }

    */
}
