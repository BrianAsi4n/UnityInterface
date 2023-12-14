using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    MainMenu,
    InGame,
    Paussed,
    GameOver
}

public class EnumExam : MonoBehaviour
{
    public GameState CurrentState;
    // Start is called before the first frame update
    void Start()
    {
        CurrentState = GameState.MainMenu;
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentState == GameState.MainMenu)
        {
            // hien thi UI Menu

        }else if(CurrentState == GameState.InGame)
        {
            //ẩn UI Menu 
            //hiện In Game UI
        }
    }
}
