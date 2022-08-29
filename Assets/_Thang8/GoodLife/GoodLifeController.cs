using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodLifeController : MonoBehaviour
{
    [SerializeField] GameObject selectGoodLife;
    [SerializeField] GameObject mainGoodLife;

    // Start is called before the first frame update
    void Start()
    {
        selectGoodLife.SetActive(true);
        mainGoodLife.SetActive(false);
    }

    public void PressGoodLife(int id)
    {
        selectGoodLife.SetActive(false);
        mainGoodLife.SetActive(false);

        if (id == 0)
        {
            selectGoodLife.SetActive(true);
        }
        else if (id == 1)
        {
            mainGoodLife.SetActive(true);
        }
    }
}
