﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
//     [SerializeField] private float dashDistance = 5f;
//     [SerializeField] private float dashDuration = 0.5f;

//     private bool isDashing;
//     private float dashTimer;
//     private Vector2 dashOrigin;
//     private Vector2 dashDestination;
//     private Vector2 newPosition;
//     [SerializeField]private Transform playertransform;

//     public WbcMovement wbcMovement;
    

//     public void HandleAbility()
//     {
//         // if (Input.GetKeyDown(KeyCode.Space))
//         // {
//         dash();
//         // }
//         if (isDashing)
//         {
//             if (dashTimer < dashDuration)
//             {
//                 newPosition = Vector2.Lerp(dashOrigin, dashDestination, dashTimer / dashDuration);
//                 wbcMovement.MovePosition(newPosition);
//                 dashTimer += Time.deltaTime;
//             }
//             else
//             {
//                 StopDash();
//             }
//         }
//     }
//     private void dash()
//     {
//         isDashing = true;
//         dashTimer = 0f;
//         wbcMovement.NormalMovement = false;
//         dashOrigin = playertransform.position;

//         dashDestination = (Vector3) dashOrigin + (Vector3) wbcMovement.CurrentMovement.normalized * dashDistance;
//     }
//     private void StopDash()
//     {
//         isDashing = false;
//         wbcMovement.NormalMovement = true;
//     }
}
