using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{

    public static PlayerInputs instance;

    public InputAction MoveAction;
    public InputAction TargetAction;
    public InputAction DodgeAction;
    public InputAction JumpAction;

    public Vector2 MovementInput
    {
        get { return MoveAction.ReadValue<Vector2>(); }
    }

    public bool DodgeButton
    {
        get { return DodgeAction.triggered; }
    }

    public bool TargetButton
    {
        get { return TargetAction.triggered; }
    }

    public bool JumpButton
    {
        get { return JumpAction.triggered; }
    }

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(this.gameObject);
        }
        //MovementInput = new Vector2(0, 0);
        
        
    }

    private void Start()
    {
        MoveAction.Enable();
        DodgeAction.Enable();
        JumpAction.Enable();
    }

}
