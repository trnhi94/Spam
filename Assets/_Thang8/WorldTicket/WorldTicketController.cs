using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTicketController : MonoBehaviour
{
    [SerializeField] GameObject selectWorldTicket;
    [SerializeField] GameObject mainWorldTicket;

    // Start is called before the first frame update
    void Start()
    {
        selectWorldTicket.SetActive(true);
        mainWorldTicket.SetActive(false);
    }

    public void PressWorldTicket(int id)
    {
        selectWorldTicket.SetActive(false);
        mainWorldTicket.SetActive(false);

        if (id == 0)
        {
            selectWorldTicket.SetActive(true);
        }
        else if (id == 1)
        {
            mainWorldTicket.SetActive(true);
        }
    }
}
