using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiServiceHappyController : MonoBehaviour
{
    [SerializeField] GameObject selectTaxi;
    [SerializeField] GameObject mainTaxi;
    [SerializeField] GameObject splashTaxi;

    int demoRand = 100;

    [SerializeField] Transform trans;

    // Start is called before the first frame update
    void Start()
    {
        splashTaxi.SetActive(false);
        selectTaxi.SetActive(true);
        mainTaxi.SetActive(false);
    }

    public void TaxiServiceHappyPress(int id)
    {
        splashTaxi.SetActive(false);
        selectTaxi.SetActive(false);
        mainTaxi.SetActive(false);

        if (id == 0)
        {
            selectTaxi.SetActive(true);
            TaxiOld();
        }
        else if (id == 1)
        {
            mainTaxi.SetActive(true);
            TaxiNew();
        }

    }

    void TaxiNew()
    {
        demoRand = 0;
        trans.position = Vector3.zero;
    }

    int TaxiOld()
    {
        var random = Random.Range(0, 2);

        demoRand += random;

        if (demoRand == 100)
        {
            Debug.Log("OH NO");

            return 1;
        }
        else
        {
            Debug.Log("YEAHHHHHHHHHH");
            return 0;
        }

    }
}
