using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
   
    public static PlayerInputs Instance;

    MainInputAction mainInputAction;
    Vector2 movementVector;

    public event EventHandler OnInteractPressed;

    void Awake()
    {
        

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        
        mainInputAction = new MainInputAction();
        mainInputAction.Enable();

        
        mainInputAction.Player.Movement.performed += movementInput;
        mainInputAction.Player.Movement.canceled += movementInput;

        mainInputAction.Player.Interact.started += interactInput;
        
    }


    private void interactInput(InputAction.CallbackContext context)
    {
        OnInteractPressed?.Invoke(this,EventArgs.Empty);
    }

    private void movementInput(InputAction.CallbackContext context)
    {
        movementVector = context.ReadValue<Vector2>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnDisable()
    {
        mainInputAction.Disable();
    }

    public Vector2 GetMovementInput => movementVector;

}
