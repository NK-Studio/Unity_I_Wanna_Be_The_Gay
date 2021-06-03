using GameplayIngredients;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Manager
{
    public UIP uip { get; private set; }

    private void Awake()
    {
        uip = new UIP();
        SceneManager.activeSceneChanged += SceneManager_activeSceneChanged;
        uip.System.FullScreen.performed += _ => { Screen.fullScreen = !Screen.fullScreen;};
        uip.System.GameEnd.performed += _ => { Application.Quit(); };
    }

    private void SceneManager_activeSceneChanged(Scene current, Scene next)
    {
        switch (next.buildIndex)
        {
            case 0:
                uip.player.Jump.performed += _ => { SceneManager.LoadScene("Load"); };
                break;
        }
    }
    
    private void OnEnable() => uip.Enable();

    private void OnDisable() => uip.Disable();
}
