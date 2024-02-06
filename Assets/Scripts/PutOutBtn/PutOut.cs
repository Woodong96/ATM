using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutOut : MonoBehaviour
{
    public GameObject Deposit;
    public GameObject Withdraw;
    public GameObject Remittance;
    public GameObject DepositSetting;
    public GameObject CheckMoney;
    public GameObject WithdrawSetting;
    public GameObject RemittanceSetting;
    // Start is called before the first frame update
    public void DepositBtnClick()
    {
        Deposit.SetActive(false);
        Withdraw.SetActive(false);
        Remittance.SetActive(false);
        DepositSetting.SetActive(true);
    }

    public void WithdrawBtnClick()
    {
        Deposit.SetActive(false);
        Withdraw.SetActive(false);
        Remittance.SetActive(false);
        WithdrawSetting.SetActive(true);
    }

    public void RemittanceBtnClick()
    {
        Deposit.SetActive(false);
        Withdraw.SetActive(false);
        Remittance.SetActive(false);
        RemittanceSetting.SetActive(true);
    }


    public void Back()
    {
        Deposit.SetActive(true);
        Withdraw.SetActive(true);
        Remittance.SetActive(true);
        DepositSetting.SetActive(false);
        WithdrawSetting.SetActive(false);
        RemittanceSetting.SetActive(false);
    }

    public void CheckMoneyOn()
    {
        CheckMoney.SetActive(true);
    } 
    
    public void CheckMoneyOff()
    {
        CheckMoney.SetActive(false);
    }



}
