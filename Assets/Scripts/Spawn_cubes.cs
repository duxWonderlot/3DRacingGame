using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_cubes : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Shatter_Control_Transfrom;
    private void Start()
    {
        //Shatter_Control_Transfrom[0].SetActive(false);
        //Shatter_Control_Transfrom[1].SetActive(false);
        //Shatter_Control_Transfrom[2].SetActive(false);
        //Shatter_Control_Transfrom[3].SetActive(false);
        //Shatter_Control_Transfrom[4].SetActive(false);

         
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //this.transform.position = Shatter_Control_Transfrom.gameObject.transform.position;
            //Shatter_Control_Transfrom[0].SetActive(true);
            //Shatter_Control_Transfrom[1].SetActive(true);
            //Shatter_Control_Transfrom[2].SetActive(true);
            //Shatter_Control_Transfrom[3].SetActive(true);
            //Shatter_Control_Transfrom[4].SetActive(true);
           
        }
    }

}
