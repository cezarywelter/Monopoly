using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState state;

    public static event Action<GameState> OnGameStateChanged;

    public GameObject mainPlayer;

    public List<Buying>listofstones;

    private void Awake()
    {
        if (GameManager.Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        UpdateGameState(GameState.IsAvailable);
        
    }

    public void UpdateGameState(GameState newState)
    {
        state = newState;

        switch (newState)
        {
            case GameState.IsAvailable:
                break;
            case GameState.Wallet:
                break;
            case GameState.SelectProperties:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);

        }

        OnGameStateChanged?.Invoke(newState);
    }
}

public enum GameState
{
    SelectProperties,
    Wallet,
    IsAvailable
}
