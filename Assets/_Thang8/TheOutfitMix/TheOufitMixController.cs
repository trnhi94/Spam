using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheOufitMixController : MonoBehaviour
{
    [SerializeField] GameObject splashGo;
    [SerializeField] GameObject mainGo;
    [SerializeField] GameObject main2Go;

    // Start is called before the first frame update
    void Start()
    {
        splashGo.SetActive(true);
        mainGo.SetActive(false);
        main2Go.SetActive(false);
    }

    public void PressMainOutfit()
    {
        splashGo.SetActive(false);
        mainGo.SetActive(true);
        main2Go.SetActive(false);

    }

    public void PressMain2Outfit()
    {
        splashGo.SetActive(false);
        mainGo.SetActive(false);
        main2Go.SetActive(true);

    }

    public void PressBackMainTheOutfit()
    {
        mainGo.SetActive(true);
        main2Go.SetActive(false);
    }
}
