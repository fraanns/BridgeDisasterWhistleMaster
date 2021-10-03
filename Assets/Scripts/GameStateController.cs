using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
    public GameState currentGameState;

    private void Start()
    {
        currentGameState = GameState.MainMenu;

        UIManager.manager.OpenPanel<MainMenuPanel>(null, false);

        InputReader.input.EnableMenuInput();

        //StartGame();
    }

    public void StartMenu()
    {
        InputReader.input.EnableMenuInput();

        currentGameState = GameState.MainMenu;
    }

    public void StartGame()
    {
        InputReader.input.EnableGameplayInput();

        currentGameState = GameState.Gameplay;
    }

    public enum GameState
    {
        MainMenu,
        Gameplay
    }
}
