using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int Speed = 60, Selection_int,Select_anime;
    public int Jump_Number = 20;
    public bool isJump_ = false;
    public float Time_M;
    public Swipe_c For_TouchsandDrags;
    public bool[] all_bools_Move;
    public int Timer_toDisable;
    public bool disable_controls;
    private void Start()
    {
        disable_controls = true;
        Selection_int = 3;
        Speed = 65;
        Timer_toDisable = 0;
       
    }

    void Update()
    {
       
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (disable_controls)
        {
            if (all_bools_Move[1] == false || all_bools_Move[0] == false)
            {
                Timer_toDisable = 0;
            }


            if (For_TouchsandDrags.swipe_left)
            {
                Animation_Control.reference_.Swipe_left(true);
                all_bools_Move[0] = true;
                all_bools_Move[1] = false;
            }
            else if (For_TouchsandDrags.swipe_right)
            {
                Animation_Control.reference_.Swipe_right(true);
                all_bools_Move[0] = false;
                all_bools_Move[1] = true;

            }
            else if (For_TouchsandDrags.tab)
            {
                Animation_Control.reference_.Idle();
                all_bools_Move[0] = false;
                all_bools_Move[1] = false;
                print("Tab!");

            }
            if (all_bools_Move[0] == true)
            {
                Animation_Control.reference_.Selection_Anime = 1;
                transform.Translate(Vector3.left * Jump_Number / 20);

            }
            else if (all_bools_Move[1] == true)
            {
                Animation_Control.reference_.Selection_Anime = 0;
                transform.Translate(-Vector3.left * Jump_Number / 20);

            }


            if (For_TouchsandDrags.swipe_down)
            {
                Animation_Control.reference_.Hey_isture_ = true;
                print("SlowMo");
                Time.timeScale = 0.2f;
                Speed = 60;
                Selection_int = 2;

            }
            else if (For_TouchsandDrags.swipe_up)
            {
                Animation_Control.reference_.Hey_isture_ = false;
                Time.timeScale = 1.0f;
                print("NO!SlowMo");
                Speed = 66;


            }
        }
    }


    private void OnTriggerStay(Collider other)
    {
        UI_Manager.instance_.Update_UI();
    }
    private void OnTriggerEnter(Collider other)
    {
        UI_Manager.instance_.Update_UI();
    }
    private void OnTriggerExit(Collider other)
    {
        UI_Manager.instance_.Update_UI();
    }
}
