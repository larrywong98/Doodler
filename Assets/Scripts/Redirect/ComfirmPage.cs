﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComfirmPage : MonoBehaviour
{
    public Button m_Btn;
    public Transform transClose;
    void Start(){
        m_Btn.onClick.AddListener(showConfirm);
    }
    public void showConfirm()
    {
        // Debug.Log("to loading");
        transClose.parent.parent.GetChild(2).gameObject.SetActive(false);
        transClose.parent.parent.GetChild(1).gameObject.SetActive(false);
        transClose.GetChild(0).gameObject.SetActive(true);
        transClose.GetChild(1).gameObject.SetActive(true);
        for(int i=0;i<4;i++){
            transClose.GetChild(1).GetChild(i).gameObject.SetActive(true);
        }
      
        
        // Loader.Load(Loader.Scene.Level1);
    }
}
