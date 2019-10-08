using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour
{
    [SerializeField]
    private bool canMove = false;

    [SerializeField]
    private float speed = 0;
    private Vector2 direction = new Vector2(0,0);

    private enum MoveState { Idle, MovingLeft, MovingRight, Jumping, Falling };
    MoveState CurrentMoveState = MoveState.Idle;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        CheckForInteraction();
        CheckForStateChange();
    }

    private void CheckForInteraction()
    {
        //if clicked with move tool
            //canMove= true
    }

    void CheckForStateChange()
    {
        if (canMove)
        {
            //getClickCoordinates
            //depending on location of pointer click, set CurrentMoveState
        }

    }

    void UpdateMoveState()
    {
        switch (CurrentMoveState)
        {
            case MoveState.Idle: Idle();
                break;
            case MoveState.MovingLeft: Move(new Vector2(-1, 0));
                break;
            case MoveState.MovingRight: Move(new Vector2(1, 0));
                break;
            case MoveState.Jumping: Move(new Vector2(0, 1));
                break;
            case MoveState.Falling:  Move(new Vector2(0, -1));
                break;
            default: Idle();
                break;
        }
    }

    private void Move(Vector2 direction)
    {
        this.direction += direction;
    }

    void Idle()
    {
        speed = 0;
        //play idle animation loop (sitting/cleaning/laying down)

    }

    


}
