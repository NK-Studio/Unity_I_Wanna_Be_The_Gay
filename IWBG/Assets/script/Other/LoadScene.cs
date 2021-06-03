using System;
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
        GameManager.GetInstance.uip.System.SlideMove.performed += SlideMove_performed;
        GameManager.GetInstance.uip.player.Jump.performed += Next;
    }

    private void Next(InputAction.CallbackContext obj)
    {
        GameManager.CurrentGameIndex = Index;
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
        var KeyboardJumpValue = GameManager.GetInstance.uip.player.Jump.GetBindingDisplayString(0);
        var KeyboardSuicideValue = GameManager.GetInstance.uip.player.SelfKill.GetBindingDisplayString(0);

        DiscText.text = $"Press {KeyboardJumpValue} to Load, {KeyboardSuicideValue} to Delete File";
        InputSystem.onDeviceChange += InputSystem_onDeviceChange;

        //�ʱ�ȭ
        LoadButtonImage(0);
        InitInfoText();
    }

    private void OnEnable()
    {
        GameManager.GetInstance.uip.System.SlideMove.Enable();
        GameManager.GetInstance.uip.player.Enable();
    }

    private void OnDisable()
    {
        GameManager.GetInstance.uip.System.SlideMove.Disable();
        GameManager.GetInstance.uip.player.Disable();
    }

    private void InputSystem_onDeviceChange(InputDevice device, InputDeviceChange change)
    {
        switch (change)
        {
            case InputDeviceChange.Added:
                var GamepadJumpValue = GameManager.GetInstance.uip.player.Jump.GetBindingDisplayString(1);
                var GamepadSuicideValue = GameManager.GetInstance.uip.player.SelfKill.GetBindingDisplayString(1);

                DiscText.text = $"Press {GamepadJumpValue} to Load, {GamepadSuicideValue} to Delete File";
                break;
            case InputDeviceChange.Removed:
                var KeyboardJumpValue = GameManager.GetInstance.uip.player.Jump.GetBindingDisplayString(0);
                var KeyboardSuicideValue = GameManager.GetInstance.uip.player.SelfKill.GetBindingDisplayString(0);

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
        for (int i = 0; i <= 2; i++)
        {
            var data = GameManager.GetInstance.gameDatas[i];
            InfoTexts[i].text = $"Deaths : {data.DeathCount}\nDifficulty : {data.Difficulty.ToString()}";
        }
    }
}
