﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DentriticTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public Transform dialogueTransform;
    public Transform player;
    public Transform transformCanvas;
    public Request request;
    public GameObject quest;
    // public static int isTriggered=0;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && 
           Vector2.Distance(transform.position,player.position)<1.5f){
            dialogueTransform.GetChild(0).gameObject.SetActive(true);
            transformCanvas.GetChild(0).gameObject.SetActive(false);
            transformCanvas.GetChild(1).gameObject.SetActive(false);
            // dialogueTransform.GetChild(1).gameObject.SetActive(true);
            TriggerDialogue();
        }
    }
   
    public void TriggerDialogue ()
    {
        FullControl.isTriggered=1;
    	FindObjectOfType<DialogueManager>().StartDialogue(dialogue,2);
    }
    public void AddRequest(){
        if(Request.awaitingRequest.Count==0){
            Debug.Log("print no more requests");
            return ;
        }
        // int ranVal=Random.Range(0,Request.awaitingRequest.Count);
        // countNumRequests=countNumRequests+1;
        // if(request.tableRequestsHash[ranVal]==1) return;
        // Debug.Log(ranVal);
        // while(countNumRequests<=Request.awaitingRequest.Count && Request.tableRequestsHash[ranVal]==1){
        //     ranVal=Random.Range(0,Request.awaitingRequest.Count);
        // }
        request.AddRow(Request.awaitingRequest[Request.ranVal][0],
                       Request.awaitingRequest[Request.ranVal][1],
                       Request.awaitingRequest[Request.ranVal][2],
                       Request.awaitingRequest[Request.ranVal][3]);
        Request.awaitingRequest.Remove(Request.awaitingRequest[Request.ranVal]);
        // Request.ranVal=Request.ranVal+1;
    }
}
