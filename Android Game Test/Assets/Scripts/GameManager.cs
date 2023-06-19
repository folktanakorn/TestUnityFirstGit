using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject TextWin;
    public GameObject RestartButton;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        score++;
        if (score >= 5)
        {
            Win();
        }
    }

     void Win()
    {
        TextWin.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
