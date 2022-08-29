using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkSalonController : MonoBehaviour
{
    [SerializeField] GameObject selectPinkSalon;
    [SerializeField] GameObject mainPinkSalon;
    [SerializeField] GameObject splashPinkSalon;

    // Start is called before the first frame update
    void Start()
    {
        splashPinkSalon.SetActive(true);
        selectPinkSalon.SetActive(false);
        mainPinkSalon.SetActive(false);
    }

    public void PressComfortLife(int id)
    {
        splashPinkSalon.SetActive(false);
        selectPinkSalon.SetActive(false);
        mainPinkSalon.SetActive(false);

        if (id == 0)
        {
            selectPinkSalon.SetActive(true);
        }
        else if (id == 1)
        {
            mainPinkSalon.SetActive(true);
        }
    }
}
