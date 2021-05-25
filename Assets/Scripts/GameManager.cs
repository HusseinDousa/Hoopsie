using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private playerController _Player;
    private UiManager _Manager;
    private rimScore _Victory;
    private bool _isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        _Player = GameObject.Find("Basketball").GetComponent<playerController>();
        _Manager = GameObject.Find("Canvas").GetComponent<UiManager>();
        _Victory = GameObject.Find("Rim_Goal").GetComponent<rimScore>();
    }

    // Update is called once per frame
    void Update()
    {
        TimesUp();
        GameWon();

        if (Input.GetKeyDown(KeyCode.R) && (_isGameOver == true || _Victory._gameWon == true))
        {
            SceneManager.LoadScene(1); // Current Game Scene
        }
    }

    void TimesUp()
    {
        if (_Manager._timeRemaining == 0f)
        {
            _Player.moveSpeed = 0f;
        }
    }

    void GameWon()
    {
        if (_Victory._gameWon == true)
        {
            _Player.moveSpeed = 0f;
        }
    }

    public void GameOver()
    {
        _isGameOver = true;
    }
}
