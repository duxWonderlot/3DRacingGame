using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Control : MonoBehaviour
{
    public Animator anime;
    
    public static Animation_Control reference_;
    public int Selection_Anime;
    public bool Hey_isture_, HeyMoveLeft;
    private void Awake()
    {
        if (reference_ == null)
        {
            reference_ = this;
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private void Start()
    {
        Jump_Update(false);
    }
    void Update()
    {

        //RaycastHit hit;
        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit))
        //{
        //    Jump_Update(false);
        //}
        //else
        //{
        //    Jump_Update(true);
        //}
        
        Jump_Update(Hey_isture_);
        
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Jump_Update(true);
        //}
        //else
        //{
        //    Jump_Update(false);
        //}
        ////left
        //anime.SetBool("swipe", false);
        //anime.SetBool("swipe2", false);
        //if (Input.GetKey(KeyCode.A))
        //{
        //    anime.SetBool("swipe", true);
        //}
        ////right
        //else if (Input.GetKey(KeyCode.D))
        //{
        //    anime.SetBool("swipe2", true);
        //}
        //if (Input.GetKeyUp(KeyCode.A))
        //{
        //    anime.SetBool("swipe", false);

        //}
        ////right
        //else if (Input.GetKeyUp(KeyCode.D))
        //{

        //    anime.SetBool("swipe2", false);
        //}
       
    }
    public void Jump_Update(bool istrue)
    {
        anime.SetBool("jumpq", istrue);
    }

    public void Swipe_left(bool isture)
    {

        anime.SetBool("swipe", true);
 
    }
    public void Swipe_right(bool isture)
    {

 
        anime.SetBool("swipe2", isture);
     
    }
    public void Idle()
    {
        anime.SetBool("swipe", false);

        anime.SetBool("swipe2", false);
    }
}
