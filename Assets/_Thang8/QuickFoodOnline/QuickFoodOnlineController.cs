using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickFoodOnlineController : MonoBehaviour
{
    [SerializeField] GameObject selectQOC;
    [SerializeField] GameObject mainQOC;
    [SerializeField] GameObject splashQOC;

    int tempvalue = 1;
    // Start is called before the first frame update
    void Start()
    {
        splashQOC.SetActive(true);
        selectQOC.SetActive(false);
        mainQOC.SetActive(false);
    }

    public void QuickFoodOnlinePress(int id)
    {
        splashQOC.SetActive(false);
        selectQOC.SetActive(false);
        mainQOC.SetActive(false);

        if (id == 0)
        {
            selectQOC.SetActive(true);
        }
        else if (id == 1)
        {

            mainQOC.SetActive(true);
        }
    }
}
