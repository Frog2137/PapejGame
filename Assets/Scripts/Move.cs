using UnityEngine;

public class Move : MonoBehaviour
{

    public Movement move;
    float horizontal = 0f;
    float speed = 40f;
    bool jump = false;
    bool crouch = false;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal")*speed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }


        if(Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if(Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    void FixedUpdate()
    {
        move.Move(horizontal * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

}
