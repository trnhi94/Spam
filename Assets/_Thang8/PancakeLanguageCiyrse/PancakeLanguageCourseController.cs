using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PancakeLanguageCourseController : MonoBehaviour
{
    [SerializeField] GameObject splashPancake;
    [SerializeField] GameObject selectPancake;
    [SerializeField] GameObject mainPancake;

    // Start is called before the first frame update
    void Start()
    {
        splashPancake.SetActive(true);
        selectPancake.SetActive(false);
        mainPancake.SetActive(false);
    }

    public void PressPancake(int id)
    {
        splashPancake.SetActive(false);
        selectPancake.SetActive(false);
        mainPancake.SetActive(false);

        if (id == 0)
        {
            selectPancake.SetActive(true);
        }
        else if (id == 1)
        {
            mainPancake.SetActive(true);
        }
    }
}
