using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class login : MonoBehaviour
{
    public TMPro.TMP_InputField inputLogin;
    public TMPro.TMP_InputField inputPass;

    public GameObject login_form;
    public GameObject admin;
    public GameObject authorized;

    public GameObject EventBtn;

    public string passwordToEdit = "My Password";

    private string ourlogin = "admin";
    private string ourpassword= "1234";

    public void openKeyboard(){
        passwordToEdit = GUI.PasswordField(new Rect(10, 10, 200, 20), passwordToEdit, "*"[0], 25);
        Debug.Log("Hi");
    }

    public void LogInBtn(){
        if (inputLogin.text == ourlogin && inputPass.text == ourpassword){
            login_form.SetActive(false);
            admin.SetActive(false);
            authorized.SetActive(true);
            EventBtn.SetActive(true);
        }
        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }

}
