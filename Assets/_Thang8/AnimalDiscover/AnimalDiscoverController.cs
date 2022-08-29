using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalDiscoverController : MonoBehaviour
{
    [SerializeField] GameObject splashGo;
    [SerializeField] GameObject mainGo;

    // Start is called before the first frame update
    void Start()
    {
        splashGo.SetActive(true);
        mainGo.SetActive(false);
    }

    public void PressMainAnimal()
    {
        splashGo.SetActive(false);
        mainGo.SetActive(true);
    }

    public void PressBackAnimal()
    {
        splashGo.SetActive(true);
        mainGo.SetActive(false);
    }
}
