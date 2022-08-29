using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoGreenTrashController : MonoBehaviour
{
    [SerializeField] GameObject selectGGT;
    [SerializeField] GameObject mainGGT;
    [SerializeField] GameObject splashGGT;

    int tempvalue = 1;
    // Start is called before the first frame update
    void Start()
    {
        splashGGT.SetActive(true);
        selectGGT.SetActive(false);
        mainGGT.SetActive(false);
    }

    public void WorldsVoiceFunnyPress(int id)
    {
        splashGGT.SetActive(false);
        selectGGT.SetActive(false);
        mainGGT.SetActive(false);

        if (id == 0)
        {
            selectGGT.SetActive(true);
        }
        else if (id == 1)
        {
            mainGGT.SetActive(true);
        }
    }
}
