using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController: MonoBehaviour
{

    public static PlayerController instance;
    [SerializeField]
    private GameObject uno;
    [SerializeField]    
    private GameObject dos;
    [SerializeField]
    private GameObject tres;
    [SerializeField]
    private GameObject cuarto;
    [SerializeField]
    private GameObject quinto;
    [HideInInspector]
    public int lifes;
    [SerializeField]
    private Text txtLifes;
    [HideInInspector]
    public int points;
    [SerializeField]
    private Text txtPoints;

    private void Awake()
    {
        makeInstance();
    }

    void Start() 
    {        
        lifes = 5;
        points = 0;
        string monster = PlayerPrefs.GetString("player");        
        GameObject monsterGO = new GameObject();
        if(monster == "1" ){
            monsterGO = uno;
        }
        if(monster == "2"){
            monsterGO = dos;
        }
        if(monster == "3"){ 
            monsterGO = tres;
        }
        if(monster == "4"){
            monsterGO = cuarto;
        }
        if (monster == "5") {
            monsterGO = quinto;
        }
        Instantiate(monsterGO, transform.position, Quaternion.identity);
    }

    private void Update()
    {
        txtLifes.text = "Vidas: " + lifes.ToString();
        txtPoints.text = "Puntaje: " + points.ToString();
        if (lifes <= 0) {
            SceneManager.LoadScene("GameOver");
        }
    }

    void makeInstance() {
        if (instance == null) {
            instance = this;
        }
    }
}
