using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantLoverController : MonoBehaviour
{
    [SerializeField] GameObject selectPlantLover;
    [SerializeField] GameObject mainPlantLover;
    [SerializeField] GameObject splashPlantLover;

    // Start is called before the first frame update
    void Start()
    {
        splashPlantLover.SetActive(true);
        selectPlantLover.SetActive(false);
        mainPlantLover.SetActive(false);
    }

    public void PressPlantLover(int id)
    {
        splashPlantLover.SetActive(false);
        selectPlantLover.SetActive(false);
        mainPlantLover.SetActive(false);

        if (id == 0)
        {
            selectPlantLover.SetActive(true);
        }
        else if (id == 1)
        {
            mainPlantLover.SetActive(true);
        }
    }
}
