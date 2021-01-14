using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumBehaviour : MonoBehaviour
{
   
   Rigidbody2D pendulumRb;
   public float moveSpeed,leftAngle,rightAngle;
   int auxMovementState;

    void Start()
    {
        pendulumRb = GetComponent<Rigidbody2D>();
        auxMovementState = 1;
    }

    
    void Update()
    {
        MovePendulum();
       
    }
    public void VerifyMoveDirection()
    {
        if(transform.rotation.z >rightAngle)
        {
            auxMovementState = 0;
        }
        else if (transform.rotation.z<leftAngle)
        {
            auxMovementState = 1;
        }

    }
    public void MovePendulum()
    {
        VerifyMoveDirection();
        if(auxMovementState==1)
        {
            pendulumRb.angularVelocity = moveSpeed;
        }
        else if( auxMovementState == 0)
        {
            pendulumRb.angularVelocity = -moveSpeed;
        }
    }
       


}
