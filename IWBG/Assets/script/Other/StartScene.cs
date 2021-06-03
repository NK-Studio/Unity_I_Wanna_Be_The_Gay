using GameplayIngredients;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    public Text SkipText;

    private void Start()
    {
        var KeyboardValue = Manager.Get<GameManager>().uip.player.Jump.GetBindingDisplayString(0);
        
        SkipText.text = $"Press '{KeyboardValue}' to Start";
        InputSystem.onDeviceChange += InputSystem_onDeviceChange;
    }

    private void InputSystem_onDeviceChange(InputDevice device, InputDeviceChange change)
    {
        switch (change)
        {
            case InputDeviceChange.Added: 
                var GamepadValue = Manager.Get<GameManager>().uip.player.Jump.GetBindingDisplayString(1);
                SkipText.text = $"Press Gamepad '{GamepadValue}' to Start";
                break;
            case InputDeviceChange.Removed:
                var KeyboardValue = Manager.Get<GameManager>().uip.player.Jump.GetBindingDisplayString(0);
                SkipText.text = $"Press '{KeyboardValue}' to Start";
                break;
        }
    }
}
