using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance_GameManger;
    public AudioSource Audio_List;
    public int Sfx_int,button_int;
    private void Awake()
    {
        if (instance_GameManger == null)
        {
            instance_GameManger = this;
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
        //PlayerPrefs.DeleteAll();

        Time.timeScale = 1;
        Sfx_int = PlayerPrefs.GetInt("sfx");

        
    }
    
    public void Update()
    {
       
        SFX_Get();
       
        if (Input.GetKey(KeyCode.R))
        {
            Game_Over();
        }

       

    }

 
    public void Game_Over()
    {
        //SceneManager.LoadScene(1);
        Time.timeScale = 0;
        UI_Manager.instance_.Gameover_Panel();
    }

    public void SFX_Get()
    {
        
         
    }

    public void Sfx_Set(int i)
    {
 
        if (Sfx_int == 1)
        {

            Audio_List.Play();
            print("there!");
            Sfx_int = 2;
             

        }
        else if (Sfx_int == 2)
        {

            Audio_List.Pause();
            print("there2!");

            Sfx_int = 1;
           
        }
        i = Sfx_int;
        PlayerPrefs.SetInt("sfx", i);
        



    }
}
