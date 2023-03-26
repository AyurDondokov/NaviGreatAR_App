using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alert_button : MonoBehaviour
{
    public GameObject login_form;
    public GameObject Alert_massage;
    public GameObject danger_event;
    public Image status;

    float timeLeft = 5.0f;

    public void danger(){
        login_form.SetActive(false);
        danger_event.SetActive(false);
        Alert_massage.SetActive(true);
        status.color = Color.red;
    }

    public void AdminUI()
    {
        login_form.SetActive(false);
        danger_event.SetActive(false);
    }

    public void alertBtn(){
        login_form.SetActive(true);
    }

    public void FakeBtn(){
        login_form.SetActive(true);
    }

    public void login_form_open(){
        if (login_form.activeSelf == false){
            login_form.SetActive(true);
        }
    }

    public void hide_login_form(){
        if(login_form.activeSelf == true){
            login_form.SetActive(false);
        }
    }

    public void hide_alert(){
        if(Alert_massage.activeSelf == true){
            Alert_massage.SetActive(false);
        }
    }

    private void Update(){
        if(Alert_massage.activeSelf == true){
            timeLeft -=Time.deltaTime;
        }

        if(timeLeft < 0){
            Alert_massage.SetActive(false);
        }

    }
}
