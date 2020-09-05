using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag=="e")
        GameManager.instance_GameManger.Game_Over();
        if (other.gameObject.tag == "e1")
            UI_Manager.instance_.Update_UI_Reduce();
        if (other.gameObject.tag == "e3")
        {
            UI_Manager.instance_.Coin_Points();
            other.gameObject.SetActive(false);
        }
       
    }
   
}
