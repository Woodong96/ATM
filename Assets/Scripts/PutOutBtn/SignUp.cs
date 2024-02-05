using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignUp : MonoBehaviour
{
    public GameObject SignUpPage;

    public void Sign_Up()
    {
        SignUpPage.SetActive(true);
    }

    public void Cancel_Sign_Up()
    {
        SignUpPage.SetActive(false);
    }
}
