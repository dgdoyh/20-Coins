using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.CinemachineTriggerAction.ActionSettings;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameMode currGameMode = GameMode.PLAY;
    public static GameManager Singleton;

    private void Awake()
    {
        if (Singleton == null)
        {
            Singleton = this;

            // To keep the game manager when we switch the scenes
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void SwitchGameMode(GameMode newGameMode)
    {
        currGameMode = newGameMode;
    }

    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}

public enum GameMode
{
    PLAY,
    PAUSE
}