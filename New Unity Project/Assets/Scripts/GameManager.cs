using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{

    //Is temporary, will be replaced later.
    [SerializeField]
    public GameObject towerPrefab;
    public static int towersPlaced = 0;
    public Text coinText;
    public static int coinsLeft = 500;
    public static int lives = 3;
    public static int enemies = 10;

    //public static object Instance { get; internal set; }

    public GameObject TowerPrefab
    {
        get
        {
            return towerPrefab;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
