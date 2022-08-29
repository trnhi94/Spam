using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadPhoneShopController : MonoBehaviour
{
    [SerializeField] GameObject splashGo;
    [SerializeField] GameObject mainGo;
    [SerializeField] GameObject payGo;

    // Start is called before the first frame update
    void Start()
    {
        splashGo.SetActive(true);
        mainGo.SetActive(false);
        payGo.SetActive(false);

    }

    public void PressMain()
    {
        splashGo.SetActive(false);
        mainGo.SetActive(true);
    }

    public void PressPay()
    {
        mainGo.SetActive(false);
        payGo.SetActive(true);
    }

    public void PressBack()
    {
        mainGo.SetActive(true);
        payGo.SetActive(false);
    }
}
