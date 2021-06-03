// GENERATED AUTOMATICALLY FROM 'Assets/Other/UIP.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @UIP : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @UIP()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UIP"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""25711300-ea93-4b18-bb39-2431c6e08714"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""5eaed644-cff1-4201-81fc-0801e93c8e41"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""202cf5bc-4ad1-4444-bc85-2da4ae27ba8f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""5cdb058c-a110-4144-9bfa-633bdb139233"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelfKill"",
                    ""type"": ""Button"",
                    ""id"": ""30468fad-7627-40db-8ebc-74ec04ed6168"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f380759f-6e43-4176-a06c-ce7e22f3b722"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""feb3b684-3312-49d6-b2a2-9130bc5b43cc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""default"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""14d9ba95-76c8-486d-834c-35accdf9908b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""default"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3aee4bc7-f7f7-4228-8f67-d846c0dd6967"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9db2ae82-c471-437b-ae44-6432ebcc93f1"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e6b561aa-aef9-446e-9d01-4c4351ee3655"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d6cbeae7-0308-4b65-aca4-c4388d1f5656"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""default"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ceec72d-4e74-43cc-8979-b57bfa97e866"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""141beb63-7f8e-49ce-9c75-3a5b9b7492e5"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""default"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84e3ffee-89c3-419d-85e8-95d0a03b9d60"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd2bb727-9b8f-48ff-8261-4e94def188b1"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""default"",
                    ""action"": ""SelfKill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e493425e-b0fd-4d1f-af88-8cd795b2dda8"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""SelfKill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""System"",
            ""id"": ""7e0668e4-80fd-4b9e-bf7a-292d476a2ab0"",
            ""actions"": [
                {
                    ""name"": ""GameEnd"",
                    ""type"": ""Button"",
                    ""id"": ""76940c14-6aa6-46f8-a88e-1ed171b1459b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FullScreen"",
                    ""type"": ""Button"",
                    ""id"": ""21b092be-c317-4f3b-9ace-cebe50889f0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SlideMove"",
                    ""type"": ""Value"",
                    ""id"": ""b00f2bda-5853-4523-b952-79abe41b5872"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c0017c7e-4684-421f-b9a2-e7f912815ac2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""default"",
                    ""action"": ""GameEnd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35308f83-bc23-4f17-87a6-83ec527f5871"",
                    ""path"": ""<Keyboard>/f4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""default"",
                    ""action"": ""FullScreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""15af4f0e-8ae2-49d9-aa90-4fd4ed2c3a9a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlideMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fa8236e7-8ccc-4403-8e41-ced46fbe11b8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""default"",
                    ""action"": ""SlideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""21f7c041-4fa9-4038-af51-ec8a1e44e41c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""default"",
                    ""action"": ""SlideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b1c9dffc-534b-4d39-96d5-b6b8c35b1956"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlideMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3ee40d93-e29f-4e66-b0fd-f6c64b12b7ac"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""SlideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5b18b402-1dc6-48b4-a635-dac9d9c86c38"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""SlideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d751b340-edb9-4980-b9ba-d2239b46913e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlideMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7ce1894e-932b-4b78-b25b-e6878d290f3b"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""SlideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5657950a-5a4a-4fc8-b94a-7089d2bf53fc"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""SlideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""default"",
            ""bindingGroup"": ""default"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""gamepad"",
            ""bindingGroup"": ""gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_move = m_player.FindAction("move", throwIfNotFound: true);
        m_player_Jump = m_player.FindAction("Jump", throwIfNotFound: true);
        m_player_Attack = m_player.FindAction("Attack", throwIfNotFound: true);
        m_player_SelfKill = m_player.FindAction("SelfKill", throwIfNotFound: true);
        // System
        m_System = asset.FindActionMap("System", throwIfNotFound: true);
        m_System_GameEnd = m_System.FindAction("GameEnd", throwIfNotFound: true);
        m_System_FullScreen = m_System.FindAction("FullScreen", throwIfNotFound: true);
        m_System_SlideMove = m_System.FindAction("SlideMove", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // player
    private readonly InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_player_move;
    private readonly InputAction m_player_Jump;
    private readonly InputAction m_player_Attack;
    private readonly InputAction m_player_SelfKill;
    public struct PlayerActions
    {
        private @UIP m_Wrapper;
        public PlayerActions(@UIP wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player_move;
        public InputAction @Jump => m_Wrapper.m_player_Jump;
        public InputAction @Attack => m_Wrapper.m_player_Attack;
        public InputAction @SelfKill => m_Wrapper.m_player_SelfKill;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @SelfKill.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelfKill;
                @SelfKill.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelfKill;
                @SelfKill.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelfKill;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @SelfKill.started += instance.OnSelfKill;
                @SelfKill.performed += instance.OnSelfKill;
                @SelfKill.canceled += instance.OnSelfKill;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);

    // System
    private readonly InputActionMap m_System;
    private ISystemActions m_SystemActionsCallbackInterface;
    private readonly InputAction m_System_GameEnd;
    private readonly InputAction m_System_FullScreen;
    private readonly InputAction m_System_SlideMove;
    public struct SystemActions
    {
        private @UIP m_Wrapper;
        public SystemActions(@UIP wrapper) { m_Wrapper = wrapper; }
        public InputAction @GameEnd => m_Wrapper.m_System_GameEnd;
        public InputAction @FullScreen => m_Wrapper.m_System_FullScreen;
        public InputAction @SlideMove => m_Wrapper.m_System_SlideMove;
        public InputActionMap Get() { return m_Wrapper.m_System; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SystemActions set) { return set.Get(); }
        public void SetCallbacks(ISystemActions instance)
        {
            if (m_Wrapper.m_SystemActionsCallbackInterface != null)
            {
                @GameEnd.started -= m_Wrapper.m_SystemActionsCallbackInterface.OnGameEnd;
                @GameEnd.performed -= m_Wrapper.m_SystemActionsCallbackInterface.OnGameEnd;
                @GameEnd.canceled -= m_Wrapper.m_SystemActionsCallbackInterface.OnGameEnd;
                @FullScreen.started -= m_Wrapper.m_SystemActionsCallbackInterface.OnFullScreen;
                @FullScreen.performed -= m_Wrapper.m_SystemActionsCallbackInterface.OnFullScreen;
                @FullScreen.canceled -= m_Wrapper.m_SystemActionsCallbackInterface.OnFullScreen;
                @SlideMove.started -= m_Wrapper.m_SystemActionsCallbackInterface.OnSlideMove;
                @SlideMove.performed -= m_Wrapper.m_SystemActionsCallbackInterface.OnSlideMove;
                @SlideMove.canceled -= m_Wrapper.m_SystemActionsCallbackInterface.OnSlideMove;
            }
            m_Wrapper.m_SystemActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GameEnd.started += instance.OnGameEnd;
                @GameEnd.performed += instance.OnGameEnd;
                @GameEnd.canceled += instance.OnGameEnd;
                @FullScreen.started += instance.OnFullScreen;
                @FullScreen.performed += instance.OnFullScreen;
                @FullScreen.canceled += instance.OnFullScreen;
                @SlideMove.started += instance.OnSlideMove;
                @SlideMove.performed += instance.OnSlideMove;
                @SlideMove.canceled += instance.OnSlideMove;
            }
        }
    }
    public SystemActions @System => new SystemActions(this);
    private int m_defaultSchemeIndex = -1;
    public InputControlScheme defaultScheme
    {
        get
        {
            if (m_defaultSchemeIndex == -1) m_defaultSchemeIndex = asset.FindControlSchemeIndex("default");
            return asset.controlSchemes[m_defaultSchemeIndex];
        }
    }
    private int m_gamepadSchemeIndex = -1;
    public InputControlScheme gamepadScheme
    {
        get
        {
            if (m_gamepadSchemeIndex == -1) m_gamepadSchemeIndex = asset.FindControlSchemeIndex("gamepad");
            return asset.controlSchemes[m_gamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnSelfKill(InputAction.CallbackContext context);
    }
    public interface ISystemActions
    {
        void OnGameEnd(InputAction.CallbackContext context);
        void OnFullScreen(InputAction.CallbackContext context);
        void OnSlideMove(InputAction.CallbackContext context);
    }
}
