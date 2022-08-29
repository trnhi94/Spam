using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartHealthTrackingController : MonoBehaviour
{
    [SerializeField] GameObject selectSHT;
    [SerializeField] GameObject mainSHT;
    [SerializeField] GameObject splashSHT;


    int numberValue = 0;

    [SerializeField] Transform DemoTrans;

    // Start is called before the first frame update
    void Start()
    {
        splashSHT.SetActive(true);
        selectSHT.SetActive(false);
        mainSHT.SetActive(false);
    }

    public void SmartHealthTrackingPress(int id)
    {
        splashSHT.SetActive(false);
        selectSHT.SetActive(false);
        mainSHT.SetActive(false);

        if (id == 0)
        {
            selectSHT.SetActive(true);
            ResetTrans();
        }
        else if (id == 1)
        {
            mainSHT.SetActive(true);

            numberValue = 0;
            numberValue = ManyManyMuch();

            Debug.Log(numberValue);
        }

    }

    public int ManyManyMuch()
    {
        int sup = 0;
        for (int i = 0; i < 10; i++)
        {
            var random = Random.Range(0, 100);

            sup += random;
        }

        return sup;
    }


    public void ResetTrans()
    {
        var randomTrans = Random.Range(0, 4);

        switch (randomTrans)
        {
            case 0:
                DemoTrans.position = Vector3.zero;
                break;
            case 1:
                DemoTrans.position = Vector3.back;
                break;
            case 2:
                DemoTrans.position = Vector3.up;
                break;
            default:
                DemoTrans.position = Vector3.down;
                break;
        }
    }
}
