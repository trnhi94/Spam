using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeautySalonHairController : MonoBehaviour
{
    [SerializeField] GameObject selectBSH;
    [SerializeField] GameObject mainBSH;
    [SerializeField] GameObject splashBSH;

    int tempNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        splashBSH.SetActive(true);
        selectBSH.SetActive(false);
        mainBSH.SetActive(false);
    }

    public void BeautySalonHairPress(int id)
    {
        splashBSH.SetActive(false);
        selectBSH.SetActive(false);
        mainBSH.SetActive(false);

        if (id == 0)
        {
            selectBSH.SetActive(true);
        }
        else if (id == 1)
        {
            mainBSH.SetActive(true);
        }
        GetRadomNumberValue();

    }

    public void GetRadomNumberValue()
    {
        tempNumber = 0;
        for (int i = 0; i < 10; i++)
        {
            var random = Random.Range(1, 50);
            tempNumber += random;
        }
        Debug.Log(tempNumber);

    }
}
