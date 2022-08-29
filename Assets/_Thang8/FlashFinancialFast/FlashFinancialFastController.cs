using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashFinancialFastController : MonoBehaviour
{
    [SerializeField] GameObject selectFFF;
    [SerializeField] GameObject mainFFF;
    [SerializeField] GameObject splashFFF;

    [SerializeField] Sprite[] SprList;
    [SerializeField] Image imgTapTap;

    // Start is called before the first frame update
    void Start()
    {
        splashFFF.SetActive(true);
        selectFFF.SetActive(false);
        mainFFF.SetActive(false);
    }

    public void PressFFF(int id)
    {
        splashFFF.SetActive(false);
        selectFFF.SetActive(false);
        mainFFF.SetActive(false);

        if (id == 0)
        {
            selectFFF.SetActive(true);
            ChangeSpr();
        }
        else if (id == 1)
        {
            mainFFF.SetActive(true);
            CheckActive();
        }
    }

    public void ChangeSpr()
    {
        var rand = Random.Range(0, SprList.Length);

        imgTapTap.sprite = SprList[rand];
    }

    public void CheckActive()
    {
        if (!splashFFF.activeSelf)
        {
            if (!selectFFF.activeSelf)
            {
                if (mainFFF.activeSelf)
                {
                    Debug.Log("WINNER");
                }
            }

        }
    }
}
