// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/GameInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""5b8bff6a-b431-432f-85d0-fe5e10a7dd9f"",
            ""actions"": [
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""0ffd2f6c-d9dd-4f63-a186-86e8b42b5622"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""aadcf275-eef9-4151-9f84-a66a70ed874d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0942f08e-7926-4e59-947b-c98deef0a430"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveSelection"",
                    ""type"": ""Value"",
                    ""id"": ""c998da9f-8138-4c3f-8bf4-8ac099ff7b4c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bfebed14-a6e8-4a70-a422-295d4fd6c274"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37adca22-10c9-4873-b00e-76afff0aa68c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""220dadec-5c8d-4056-8bd1-04b533962250"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""093004eb-89d0-4c01-95de-a34758a94ee4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49aacf54-d728-4442-9cbe-826d5983106f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8f12acd-6514-4686-9ac5-038c60e649e6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""894ebadc-9b80-4b13-91ba-a47441b413d7"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab5526b0-1a65-40b1-b4f7-5e446195ac9b"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02b97657-9656-4102-a518-f3d319577f42"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard WASD"",
                    ""id"": ""6994ff89-849b-4ae7-ad9b-9847f1e093b1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""58d17ff1-eb20-4bba-8ad4-10f1dca07998"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e3f6ef2b-9172-4f0e-ac94-a4130986350b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4fbeb35e-2073-48de-bb1a-8c28af3eed8a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""306b9def-dfea-4e19-9617-b71ead671e7b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Arrows"",
                    ""id"": ""ff7c50b4-b559-412d-9cef-e5397d8ae9ca"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""847d0c46-99f7-4266-b8a8-a6dd520402a5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0bc47953-36d4-4473-9835-e0173b7e4d93"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bb4480e8-883c-4e16-9948-a9e3f187df07"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bc99c09f-e6f3-4860-8574-61e0bb87851e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Gameplay"",
            ""id"": ""bed83175-8e3c-46c2-8d29-e0e3d0e3bc8b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6276272e-4591-465a-b496-78d85aeaabf8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Whistle"",
                    ""type"": ""Button"",
                    ""id"": ""fd794f3a-31fd-40fe-a635-20467b7d1d2c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CompleteLevel"",
                    ""type"": ""Button"",
                    ""id"": ""cef59f39-1bf8-48b5-b42e-3bc3d61b3946"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d4ded392-58aa-4881-b7a2-a429ebe91403"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7020f04b-cb81-451b-9d96-6cd478ff9340"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bf717645-6d6a-48a2-9b85-5ced98bedb12"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7b324c33-544f-45b0-bdbc-793491a93f08"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1cf1b405-4b71-4b16-93a0-7f4ea5a8cd0a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2e1bebda-dacd-45f4-a755-b053f284ac76"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""e9de4823-2270-45f8-9756-0d356f9cf552"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""624727b4-0d91-43d1-9462-c316b0991e61"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b08937a0-1be7-4c34-befd-b0ed009ad4ed"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c60529a8-0400-4686-892f-9d50a77be89c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8edc2a95-2caa-4486-a74f-b0b23579b8e8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""994e0a2b-c196-4058-a922-2c4ccda56546"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Whistle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""651c21d9-c33b-47f9-b1f3-38a5da0c1e69"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Whistle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfcae566-5919-4756-95b1-f2377ef492a7"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CompleteLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef446491-5c53-45de-b5f6-b20636d95e5c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CompleteLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Confirm = m_Menu.FindAction("Confirm", throwIfNotFound: true);
        m_Menu_Cancel = m_Menu.FindAction("Cancel", throwIfNotFound: true);
        m_Menu_MouseMove = m_Menu.FindAction("MouseMove", throwIfNotFound: true);
        m_Menu_MoveSelection = m_Menu.FindAction("MoveSelection", throwIfNotFound: true);
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Whistle = m_Gameplay.FindAction("Whistle", throwIfNotFound: true);
        m_Gameplay_CompleteLevel = m_Gameplay.FindAction("CompleteLevel", throwIfNotFound: true);
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

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Confirm;
    private readonly InputAction m_Menu_Cancel;
    private readonly InputAction m_Menu_MouseMove;
    private readonly InputAction m_Menu_MoveSelection;
    public struct MenuActions
    {
        private @GameInput m_Wrapper;
        public MenuActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Confirm => m_Wrapper.m_Menu_Confirm;
        public InputAction @Cancel => m_Wrapper.m_Menu_Cancel;
        public InputAction @MouseMove => m_Wrapper.m_Menu_MouseMove;
        public InputAction @MoveSelection => m_Wrapper.m_Menu_MoveSelection;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Confirm.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnConfirm;
                @Cancel.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancel;
                @MouseMove.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMouseMove;
                @MouseMove.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMouseMove;
                @MouseMove.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMouseMove;
                @MoveSelection.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveSelection;
                @MoveSelection.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveSelection;
                @MoveSelection.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMoveSelection;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @MouseMove.started += instance.OnMouseMove;
                @MouseMove.performed += instance.OnMouseMove;
                @MouseMove.canceled += instance.OnMouseMove;
                @MoveSelection.started += instance.OnMoveSelection;
                @MoveSelection.performed += instance.OnMoveSelection;
                @MoveSelection.canceled += instance.OnMoveSelection;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Whistle;
    private readonly InputAction m_Gameplay_CompleteLevel;
    public struct GameplayActions
    {
        private @GameInput m_Wrapper;
        public GameplayActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Whistle => m_Wrapper.m_Gameplay_Whistle;
        public InputAction @CompleteLevel => m_Wrapper.m_Gameplay_CompleteLevel;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Whistle.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWhistle;
                @Whistle.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWhistle;
                @Whistle.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnWhistle;
                @CompleteLevel.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCompleteLevel;
                @CompleteLevel.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCompleteLevel;
                @CompleteLevel.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCompleteLevel;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Whistle.started += instance.OnWhistle;
                @Whistle.performed += instance.OnWhistle;
                @Whistle.canceled += instance.OnWhistle;
                @CompleteLevel.started += instance.OnCompleteLevel;
                @CompleteLevel.performed += instance.OnCompleteLevel;
                @CompleteLevel.canceled += instance.OnCompleteLevel;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IMenuActions
    {
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnMouseMove(InputAction.CallbackContext context);
        void OnMoveSelection(InputAction.CallbackContext context);
    }
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnWhistle(InputAction.CallbackContext context);
        void OnCompleteLevel(InputAction.CallbackContext context);
    }
}
