using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightMusicSoundController : MonoBehaviour
{
    [SerializeField] GameObject selectNMS;
    [SerializeField] GameObject mainNMS;
    [SerializeField] GameObject splashNMS;

    bool isCheckOker = false;

    // Start is called before the first frame update
    void Start()
    {
        splashNMS.SetActive(true);
        selectNMS.SetActive(false);
        mainNMS.SetActive(false);
    }

    public void NightMusicSoundPress(int id)
    {
        splashNMS.SetActive(false);
        selectNMS.SetActive(false);
        mainNMS.SetActive(false);

        if (id == 0)
        {
            selectNMS.SetActive(true);
            SetNMSController();
        }
        else if (id == 1)
        {
            mainNMS.SetActive(true);
            SetNMSController();
        }
    }

    public void SetNMSController()
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
