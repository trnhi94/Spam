using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartBankController : MonoBehaviour
{
    [SerializeField] GameObject selectSmartBank;
    [SerializeField] GameObject mainSmartBank;

    // Start is called before the first frame update
    void Start()
    {
        selectSmartBank.SetActive(true);
        mainSmartBank.SetActive(false);
    }

    public void PressSmartBank(int id)
    {
        selectSmartBank.SetActive(false);
        mainSmartBank.SetActive(false);

        if (id == 0)
        {
            selectSmartBank.SetActive(true);
        }
        else if (id == 1)
        {
            mainSmartBank.SetActive(true);
        }
    }
}
