using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastBusDayController : MonoBehaviour
{
    [SerializeField] GameObject selectFBD;
    [SerializeField] GameObject mainFBD;
    [SerializeField] GameObject splashFBD;

    bool isCheckOker = false;

    // Start is called before the first frame update
    void Start()
    {
        splashFBD.SetActive(true);
        selectFBD.SetActive(false);
        mainFBD.SetActive(false);
    }

    public void FastBusDayPress(int id)
    {
        splashFBD.SetActive(false);
        selectFBD.SetActive(false);
        mainFBD.SetActive(false);

        if (id == 0)
        {
            selectFBD.SetActive(true);
            SetTropical();
        }
        else if (id == 1)
        {
            mainFBD.SetActive(true);
            SetTropical();
        }
    }

    public void SetTropical()
    {
        if (isCheckOker)
        {
            isCheckOker = false;
        }
        else
        {
            isCheckOker = true;
        }
    }
}
