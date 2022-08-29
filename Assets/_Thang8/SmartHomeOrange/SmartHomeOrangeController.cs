using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartHomeOrangeController : MonoBehaviour
{
    [SerializeField] GameObject selectSHO;
    [SerializeField] GameObject mainSHO;
    [SerializeField] GameObject splashSHO;

    int tempvalue = 1;
    // Start is called before the first frame update
    void Start()
    {
        splashSHO.SetActive(true);
        selectSHO.SetActive(false);
        mainSHO.SetActive(false);
    }

    public void SmartHomeOrangePress(int id)
    {
        splashSHO.SetActive(false);
        selectSHO.SetActive(false);
        mainSHO.SetActive(false);

        if (id == 0)
        {
            MayBeOrange();

            selectSHO.SetActive(true);
        }
        else if (id == 1)
        {
            MayBeOrange();

            mainSHO.SetActive(true);
        }
    }

    public void MayBeOrange()
    {
        tempvalue = 0;
        for (int i = 0; i < 10; i++)
        {
            var random = Random.Range(1, 50);
            tempvalue += random;
        }

        Debug.Log(tempvalue);
    }

}
