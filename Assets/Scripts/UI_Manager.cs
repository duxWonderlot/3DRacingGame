using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class UI_Manager : MonoBehaviour
{
    public static UI_Manager instance_;
    public Slider exp;
    public int Max_Exp, progress,high_pro;
    public Text Number;
    public Image img_notifiy;
    public TextMeshProUGUI HightScore;
    public GameObject GO_panel;
    public GameObject Alert;
    public float timer;
    public Player reference;
    private bool On;
    
    private void Awake()
    {
        if (instance_ == null)
        {
            instance_ = this;
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
        //PlayerPrefs.DeleteAll();
        high_pro = PlayerPrefs.GetInt("HightScore");
        GO_panel.SetActive(false);
        Alert.SetActive(false);
    }
    private void Start()
    {
        progress = 0;
        Max_Exp = 100;
        timer = 0;
    }
    private void Update()
    {
        exp.maxValue = Max_Exp;
        Number.text = "" + progress;
        HightScore.text = "" + high_pro;
        if (progress >high_pro)
        {
            high_pro = progress;
          
            PlayerPrefs.SetInt("HightScore", high_pro);

            On = true;

        }

        if (On)
        {
            Alert.SetActive(true);
            timer += 1 * Time.deltaTime;
            
        }
        if (timer >= 0.8f)
        {
            Alert.SetActive(false);
        }
         

    }
    public void Update_UI()
    {
        exp.value += 3;
        if (exp.value >= Max_Exp)
        {
            Max_Exp += 100;
            progress += 1;
            exp.value = 0;
        }
    }
    public void Update_UI_Reduce()
    {
        exp.value -= 6;
        
    }
    public void Coin_Points()
    {
        exp.value += 50;

    }

    public void Gameover_Panel()
    {

       // high_pro = progress;
       //PlayerPrefs.SetInt("HightScore", high_pro);
     reference.disable_controls = false;
     GO_panel.SetActive(true);
    }
 
    public void Restart()
    {
        SceneManager.LoadSceneAsync(1);
    }

    
}
