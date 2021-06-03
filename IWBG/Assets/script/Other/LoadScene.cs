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
        //����/������ ���� ���� ������
        var Horizontal = (int)obj.ReadValue<float>();
        var tempInt = Index;

        //-1 / 1�� ���ؼ� ����/������ �̵��� ó����
        tempInt += Horizontal;

        //0~2���̷� �ڸ�
        tempInt = Mathf.Clamp(tempInt, 0, 2);

        //�̹��� ����
        LoadButtonImage(tempInt);

        //���� ���� ó��
        Index = tempInt;
    }

    private void Start()
    {
        var KeyboardJumpValue = Manager.Get<GameManager>().uip.player.Jump.GetBindingDisplayString(0);
        var KeyboardSuicideValue = Manager.Get<GameManager>().uip.player.SelfKill.GetBindingDisplayString(0);

        DiscText.text = $"Press {KeyboardJumpValue} to Load, {KeyboardSuicideValue} to Delete File";
        InputSystem.onDeviceChange += InputSystem_onDeviceChange;

        //�ʱ�ȭ
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
        //���� ��ư �̹����� ����Ʈ �̹����� ����
        LoadButtonImages[Index].sprite = LoadButtonSprs[0];

        //Ÿ���� �̹��� ��ư�� ������ ��ư���� ����
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
