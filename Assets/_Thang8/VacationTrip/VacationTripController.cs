using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacationTripController : MonoBehaviour
{
    [SerializeField] GameObject selectVacationTrip;
    [SerializeField] GameObject mainVacationTrip;
    [SerializeField] GameObject splashVacationTrip;

    bool isCheckOker = false;

    // Start is called before the first frame update
    void Start()
    {
        splashVacationTrip.SetActive(true);
        selectVacationTrip.SetActive(false);
        mainVacationTrip.SetActive(false);
    }

    public void VacationTripPress(int id)
    {
        splashVacationTrip.SetActive(false);
        selectVacationTrip.SetActive(false);
        mainVacationTrip.SetActive(false);

        if (id == 0)
        {
            selectVacationTrip.SetActive(true);
            SetBoolGame();
        }
        else if (id == 1)
        {
            mainVacationTrip.SetActive(true);
            SetBoolGame();
        }
    }

    public void SetBoolGame()
    {
        if (isCheckOker)
        {
            isCheckOker = false;
        }
        else
        {
            isCheckOker = true;
        }
    }

}
