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
    private Vector2 moveTranslation;

    private Vector2 destination;

    private Ray ray;
    private RaycastHit hit;

    private enum MoveState { Idle, MovingLeft, MovingRight, Jumping, Falling };
    MoveState CurrentMoveState;

    private void Awake()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        CurrentMoveState = MoveState.Idle;
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
        CheckIfDestinationReached();
    }
    /// <summary>
    /// Cat can only be interacted with if Idling and if in move mode
    /// </summary>
    private void CheckForInteraction() 
    {
        if(CurrentMoveState == MoveState.Idle && Manager.Instance.getMoveMode().isEnabled())
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Cat")
                {
                    Debug.Log("This is a Player");
                    // change move tool pointer into destination pointer
                    canMove = true;
                }
                else
                {
                    Debug.Log("This isn't a Player");
                }
            }
  
        }
    }

    void CheckForStateChange() 
    {
        if (canMove && Input.GetMouseButtonDown(0)) //if left click and can move cat
        {
            destination = Input.mousePosition;
            canMove = false; //cant move until current move is finished

            if ((transform.position.y + 400) < destination.y) //if clicked above cat by certain amount
            {
                CurrentMoveState = MoveState.Jumping;
            }

            else if (transform.position.x < destination.x) //if clicked right of cat
            {
                CurrentMoveState = MoveState.MovingRight;
            }

            else if (transform.position.x > destination.x) //if clicked left of cat
            {
                CurrentMoveState = MoveState.MovingLeft;
            }

            UpdateMoveState();
        }

    }

    void CheckIfDestinationReached()
    {
        //if destination reached
            //CurrentMoveState = MoveState.Idle;
    }

    void UpdateMoveState()
    {
        switch (CurrentMoveState)
        {
            case MoveState.Idle: Idle();
                break;
            case MoveState.MovingLeft: MovingLeft();
                break;
            case MoveState.MovingRight: MovingRight();
                break;
            case MoveState.Jumping: Jumping();
                break;
            case MoveState.Falling: Falling();
                break;
            default: Idle();
                break;
        }
    }

    private void Move(Vector2 direction)
    {
        //time corrected movement
        moveTranslation = new Vector2(direction.x, direction.y) * Time.deltaTime * speed;

        //move
        transform.position += new Vector3(moveTranslation.x, moveTranslation.y);
    }

    void Idle()
    {
        speed = 0;
        //play idle animation loop (sitting/cleaning/laying down)
        //or add more move states

    }

    void Jumping()
    {
        //jump animation
        Move(new Vector2(0, 1));
    }

    void Falling()
    {
        //falling animation
        Move(new Vector2(0, -1));
    }

    void MovingRight()
    {
        //right animation
        Move(new Vector2(1, 0));
    }

    void MovingLeft()
    {
        //flip right animation?
        Move(new Vector2(-1, 0));
    }

    


}
