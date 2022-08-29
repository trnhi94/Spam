using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GentelmenBarberController : MonoBehaviour
{
    [SerializeField] GameObject selectGB;
    [SerializeField] GameObject mainGB;
    [SerializeField] GameObject splashGB;

    bool isCheckGB = false;

    // Start is called before the first frame update
    void Start()
    {
        splashGB.SetActive(true);
        selectGB.SetActive(false);
        mainGB.SetActive(false);
    }

    public void GentelmenBarberPress(int id)
    {
        splashGB.SetActive(false);
        selectGB.SetActive(false);
        mainGB.SetActive(false);

        if (id == 0)
        {
            selectGB.SetActive(true);
            GetAndSetCheckGB();
        }
        else if (id == 1)
        {
            mainGB.SetActive(true);
            GetAndSetCheckGB();
        }
    }

    public void GetAndSetCheckGB()
    {
        if (isCheckGB)
        {
            isCheckGB = false;
        }
        else
        {
            isCheckGB = true;
        }
    }
}
