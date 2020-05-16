using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPlayer : MonoBehaviour
{
    private Button button;
    [SerializeField]
    private string player;

    void Start()
    {
        button = GetComponent<Button>();        
        button.onClick.AddListener(() => GoGame());        
    }
    void GoGame()
    {

        PlayerPrefs.SetString("player", player);
        SceneManager.LoadScene("Game");
    }
}