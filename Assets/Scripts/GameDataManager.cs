using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameDataManager : MonoBehaviour
{
    public static GameDataManager Instance;
    public TMP_InputField inputField;
    public Text bestScore;
    public static string playerName;

private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
    
    public void SetPlayerName()
    {
        playerName = inputField.text;
        //Here I need to pass this to a text in-game and then save it into a json file.
    }

    //void AddName(string pN)
    //{
    //  playerName = menuScript.input;
    //pN = playerName;
    //ScoreText.text = $" {playerName} Score : {m_Points}";
    //}
}
