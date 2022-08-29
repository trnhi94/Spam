using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenFurnitureController : MonoBehaviour
{
    [SerializeField] GameObject selectGreenFurniture;
    [SerializeField] GameObject mainGreenFurniture;
    [SerializeField] GameObject splashGreenFurniture;

    // Start is called before the first frame update
    void Start()
    {
        splashGreenFurniture.SetActive(true);
        selectGreenFurniture.SetActive(false);
        mainGreenFurniture.SetActive(false);
    }

    public void PressGreenFurniture(int id)
    {
        splashGreenFurniture.SetActive(false);
        selectGreenFurniture.SetActive(false);
        mainGreenFurniture.SetActive(false);

        if (id == 0)
        {
            selectGreenFurniture.SetActive(true);
        }
        else if (id == 1)
        {
            mainGreenFurniture.SetActive(true);
        }
    }
}
