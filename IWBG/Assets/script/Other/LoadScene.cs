using GameplayIngredients;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Text DiscText;

    public Text[] InfoTexts;

    public Sprite[] LoadButtonSprs;

    public Image[] LoadButtonImages;

    private int Index = 0;

    private void Awake()
    {
        Manager.Get<GameManager>().uip.System.SlideMove.performed += SlideMove_performed;
        Manager.Get<GameManager>().uip.player.Jump.performed += Next;
    }

    private void Next(InputAction.CallbackContext obj)
    {
        Manager.Get<GameManager>().CurrentGameIndex = Index;
        SceneManager.LoadScene("beginning");
    }

    private void SlideMove_performed(InputAction.CallbackContext obj)
    {
        //왼쪽/오른쪽 누른 것을 가져옴
        var Horizontal = (int)obj.ReadValue<float>();
        var tempInt = Index;

        //-1 / 1을 더해서 왼쪽/오른쪽 이동을 처리함
        tempInt += Horizontal;

        //0~2사이로 자름
        tempInt = Mathf.Clamp(tempInt, 0, 2);

        //이미지 대응
        LoadButtonImage(tempInt);

        //실제 값에 처리
        Index = tempInt;
    }

    private void Start()
    {
        var KeyboardJumpValue = Manager.Get<GameManager>().uip.player.Jump.GetBindingDisplayString(0);
        var KeyboardSuicideValue = Manager.Get<GameManager>().uip.player.SelfKill.GetBindingDisplayString(0);

        DiscText.text = $"Press {KeyboardJumpValue} to Load, {KeyboardSuicideValue} to Delete File";
        InputSystem.onDeviceChange += InputSystem_onDeviceChange;

        //초기화
        LoadButtonImage(0);
        InitInfoText();
    }

    private void InputSystem_onDeviceChange(InputDevice device, InputDeviceChange change)
    {
        switch (change)
        {
            case InputDeviceChange.Added:
                var GamepadJumpValue = Manager.Get<GameManager>().uip.player.Jump.GetBindingDisplayString(1);
                var GamepadSuicideValue = Manager.Get<GameManager>().uip.player.SelfKill.GetBindingDisplayString(1);

                DiscText.text = $"Press {GamepadJumpValue} to Load, {GamepadSuicideValue} to Delete File";
                break;
            case InputDeviceChange.Removed:
                var KeyboardJumpValue = Manager.Get<GameManager>().uip.player.Jump.GetBindingDisplayString(0);
                var KeyboardSuicideValue = Manager.Get<GameManager>().uip.player.SelfKill.GetBindingDisplayString(0);

                DiscText.text = $"Press {KeyboardJumpValue} to Load, {KeyboardSuicideValue} to Delete File";
                break;
        }
    }

    private void LoadButtonImage(int id)
    {
        //이전 버튼 이미지는 디폴트 이미지로 변경
        LoadButtonImages[Index].sprite = LoadButtonSprs[0];

        //타겟의 이미지 버튼을 선택한 버튼으로 변경
        LoadButtonImages[id].sprite = LoadButtonSprs[1];
    }

    private void InitInfoText()
    {
        foreach (var i in InfoTexts)
        {
            i.text = string.Format("Deaths : {0}\nDifficulty : {1}", 0, "Undefined");
        }
    }
}
