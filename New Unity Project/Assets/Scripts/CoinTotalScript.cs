using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTotalScript : MonoBehaviour
{
    public int coincount;
    public Text coinText;
    public Text livesText;
    public Text enemiesText;
    public static GameManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        //coincount = 400;
    }

    // Update is called once per frame
    void Update()
    {

            coinText.text = GameManager.coinsLeft.ToString() + " coins";
            livesText.text = GameManager.lives.ToString() + " lives left";
            enemiesText.text = GameManager.enemies.ToString() + " enemies left";

    }
    /*
    public void coinDecrementer()
    {
        coincount = 400 - (count * 100);

        coinText.text = coincount.ToString() + " coins";
    }
    */
}
