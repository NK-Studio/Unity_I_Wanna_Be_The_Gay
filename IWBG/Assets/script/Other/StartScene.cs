using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    public Text SkipText;

    private void Start()
    {
        var KeyboardValue = GameManager.GetInstance.uip.player.Jump.GetBindingDisplayString(0);

        SkipText.text = $"Press '{KeyboardValue}' to Start";
        InputSystem.onDeviceChange += InputSystem_onDeviceChange;
        GameManager.GetInstance.uip.player.Jump.performed += _ =>
        {
            SceneManager.LoadScene("Load");
        };
    }

    private void OnEnable() => 
        GameManager.GetInstance.uip.player.Enable();

    private void OnDisable() => 
        GameManager.GetInstance.uip.player.Disable();

    private void InputSystem_onDeviceChange(InputDevice device, InputDeviceChange change)
    {
        switch (change)
        {
            case InputDeviceChange.Added:
                var GamepadValue = GameManager.GetInstance.uip.player.Jump.GetBindingDisplayString(1);
                SkipText.text = $"Press Gamepad '{GamepadValue}' to Start";
                break;
            case InputDeviceChange.Removed:
                var KeyboardValue = GameManager.GetInstance.uip.player.Jump.GetBindingDisplayString(0);
                SkipText.text = $"Press '{KeyboardValue}' to Start";
                break;
        }
    }
}
