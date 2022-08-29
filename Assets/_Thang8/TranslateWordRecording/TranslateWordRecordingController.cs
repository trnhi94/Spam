using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslateWordRecordingController : MonoBehaviour
{
    [SerializeField] GameObject selectTWR;
    [SerializeField] GameObject mainTWR;
    [SerializeField] GameObject splashTWR;

    float damge = 100;
    int moeny = 0;

    [SerializeField] Sprite[] SprList;
    [SerializeField] Image imgTap;

    // Start is called before the first frame update
    void Start()
    {
        splashTWR.SetActive(true);
        selectTWR.SetActive(false);
        mainTWR.SetActive(false);
    }

    public void PressTranslateWordRecording(int id)
    {
        splashTWR.SetActive(false);
        selectTWR.SetActive(false);
        mainTWR.SetActive(false);

        if (id == 0)
        {
            selectTWR.SetActive(true);
            ChangeSpr();
        }
        else if (id == 1)
        {
            mainTWR.SetActive(true);
        }
        GetNameSpr();
    }

    public void ChangeSpr()
    {
        var rand = Random.Range(0, SprList.Length);

        imgTap.sprite = SprList[rand];
    }

    public void GetNameSpr()
    {
        Debug.Log(imgTap.name);
    }
}
