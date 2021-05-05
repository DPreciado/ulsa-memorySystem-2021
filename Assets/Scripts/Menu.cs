using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField]
    Button btnNewGame;
    [SerializeField]
    Button btnLoadGame;
    [SerializeField]
    Button btnQuit;

    // Start is called before the first frame update
    void Start()
    {
        btnNewGame.onClick.AddListener(NewGameClick);
        btnLoadGame.onClick.AddListener(LoadGameClick);
        btnQuit.onClick.AddListener(Quit);
    }

    void NewGameClick()
    {
        Debug.Log("new game");
    }

    void LoadGameClick()
    {
        Debug.Log("Load Game");
    }

    void Quit()
    {
        Application.Quit();
    }
}
