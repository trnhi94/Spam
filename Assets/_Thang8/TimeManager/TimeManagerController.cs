using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManagerController : MonoBehaviour
{
    [SerializeField] GameObject selectTimeManager;
    [SerializeField] GameObject mainTimeManager;
    [SerializeField] GameObject splashTimeManager;

    // Start is called before the first frame update
    void Start()
    {
        splashTimeManager.SetActive(true);
        selectTimeManager.SetActive(false);
        mainTimeManager.SetActive(false);
    }

    public void PressTimeManager(int id)
    {
        splashTimeManager.SetActive(false);
        selectTimeManager.SetActive(false);
        mainTimeManager.SetActive(false);

        if (id == 0)
        {
            selectTimeManager.SetActive(true);
        }
        else if (id == 1)
        {
            mainTimeManager.SetActive(true);
        }
    }
}
