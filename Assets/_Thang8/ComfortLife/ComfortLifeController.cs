using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComfortLifeController : MonoBehaviour
{
    [SerializeField] GameObject selectComfortLife;
    [SerializeField] GameObject mainComfortLife;
    [SerializeField] GameObject splashComfortLife;

    // Start is called before the first frame update
    void Start()
    {
        splashComfortLife.SetActive(true);
        selectComfortLife.SetActive(false);
        mainComfortLife.SetActive(false);
    }

    public void PressComfortLife(int id)
    {
        splashComfortLife.SetActive(false);
        selectComfortLife.SetActive(false);
        mainComfortLife.SetActive(false);

        if (id == 0)
        {
            selectComfortLife.SetActive(true);
        }
        else if (id == 1)
        {
            mainComfortLife.SetActive(true);
        }
    }
}
