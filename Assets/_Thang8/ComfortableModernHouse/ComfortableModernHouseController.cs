using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComfortableModernHouseController : MonoBehaviour
{
    [SerializeField] GameObject selectCMH;
    [SerializeField] GameObject mainCMH;
    [SerializeField] GameObject splashCMH;

    // Start is called before the first frame update
    void Start()
    {
        splashCMH.SetActive(true);
        selectCMH.SetActive(false);
        mainCMH.SetActive(false);
    }

    public void ComfortableModernHousePress(int id)
    {
        splashCMH.SetActive(false);
        selectCMH.SetActive(false);
        mainCMH.SetActive(false);

        if (id == 0)
        {
            selectCMH.SetActive(true);
        }
        else if (id == 1)
        {
            mainCMH.SetActive(true);
        }

        Debug.Log(Modern());


        Debug.Log(House());
    }

    public int Modern()
    {
        var demo = 0;

        for (int i = 0; i < 3; i++)
        {
            var random = Random.Range(1, 20);

            demo += random;
        }

        if (demo > 20)
        {
            return demo;
        }

        return 1;
    }

    public bool House()
    {
        if (splashCMH.activeSelf || selectCMH.activeSelf)
        {
            return true;
        }
        return false;
    }
}
