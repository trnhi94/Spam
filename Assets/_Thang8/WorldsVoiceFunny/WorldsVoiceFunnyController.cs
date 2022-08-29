using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldsVoiceFunnyController : MonoBehaviour
{
    [SerializeField] GameObject selectWVF;
    [SerializeField] GameObject mainWVF;
    [SerializeField] GameObject splashWVF;

    int tempvalue = 1;
    // Start is called before the first frame update
    void Start()
    {
        splashWVF.SetActive(true);
        selectWVF.SetActive(false);
        mainWVF.SetActive(false);
    }

    public void WorldsVoiceFunnyPress(int id)
    {
        splashWVF.SetActive(false);
        selectWVF.SetActive(false);
        mainWVF.SetActive(false);

        if (id == 0)
        {
            selectWVF.SetActive(true);
        }
        else if (id == 1)
        {
            mainWVF.SetActive(true);
        }

        Smart();
    }

    public void Smart()
    {
        if (!splashWVF.activeSelf)
        {
            if (!selectWVF.activeSelf)
            {
                if (mainWVF.activeSelf)
                {
                    if (tempvalue == 10)
                    {
                        tempvalue = 1;
                    }
                    else
                    {
                        tempvalue++;
                    }
                    
                }
            }
        }
    }
}
