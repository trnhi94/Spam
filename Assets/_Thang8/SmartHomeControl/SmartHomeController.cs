using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartHomeController : MonoBehaviour
{
    [SerializeField] GameObject splashSHC;
    [SerializeField] GameObject selectSHC;
    [SerializeField] GameObject mainSHC;

    // Start is called before the first frame update
    void Start()
    {
        splashSHC.SetActive(true);
        selectSHC.SetActive(false);
        mainSHC.SetActive(false);
    }

    public void PressSmartHomeController(int id)
    {
        splashSHC.SetActive(false);
        selectSHC.SetActive(false);
        mainSHC.SetActive(false);

        if (id == 0)
        {
            selectSHC.SetActive(true);
        }
        else if (id == 1)
        {
            mainSHC.SetActive(true);
        }
    }
}
