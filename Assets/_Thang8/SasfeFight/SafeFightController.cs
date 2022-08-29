using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeFightController : MonoBehaviour
{
    [SerializeField] GameObject selectSafeFight;
    [SerializeField] GameObject mainSafeFight;
    [SerializeField] GameObject splashSafeFight;

    // Start is called before the first frame update
    void Start()
    {
        splashSafeFight.SetActive(true);
        selectSafeFight.SetActive(false);
        mainSafeFight.SetActive(false);
    }

    public void PressSafeFight(int id)
    {
        splashSafeFight.SetActive(false);
        selectSafeFight.SetActive(false);
        mainSafeFight.SetActive(false);

        if (id == 0)
        {
            selectSafeFight.SetActive(true);
        }
        else if (id == 1)
        {
            mainSafeFight.SetActive(true);
        }
    }
}
