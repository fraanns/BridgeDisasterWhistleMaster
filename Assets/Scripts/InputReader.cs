using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;


public class InputReader : MonoBehaviour, GameInput.IGameplayActions, GameInput.IMenuActions
{
    public static InputReader input;

    private GameInput gameInput;

    public Vector2 moveDirection;

    // Gameplay
    public event UnityAction whistleStartEvent = delegate { };
    public event UnityAction whistleEndEvent = delegate { };
    public event UnityAction levelCompleteEvent = delegate { };
    

    // Menus
    public event UnityAction moveSelectionEvent = delegate { };
    public event UnityAction menuMouseMoveEvent = delegate { };
    public event UnityAction menuConfirmEvent = delegate { };
    public event UnityAction menuCancelEvent = delegate { };

    void Awake()
    {
        input = this;

        if (gameInput == null)
        {
            gameInput = new GameInput();
            gameInput.Menu.SetCallbacks(this);
            gameInput.Gameplay.SetCallbacks(this);
        }
    }

    public void OnCancel(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            menuCancelEvent();
    }

    public void OnConfirm(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            menuConfirmEvent();
    }



    public void OnMouseMove(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            menuMouseMoveEvent();
    }

    public void OnMoveSelection(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            moveSelectionEvent();
    }



   



    public void EnableGameplayInput()
    {
        gameInput.Menu.Disable();

        gameInput.Gameplay.Enable();
    }

    public void EnableMenuInput()
    {
        gameInput.Gameplay.Disable();

        gameInput.Menu.Enable();
    }

    public void DisableAllInput()
    {
        gameInput.Gameplay.Disable();
        gameInput.Menu.Disable();
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }

    public void OnWhistle(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                whistleStartEvent.Invoke();
                break;
            case InputActionPhase.Canceled:
                whistleEndEvent.Invoke();
                break;
        }
    }

    public void OnCompleteLevel(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                levelCompleteEvent.Invoke();
                break;
        }
    }
}
