using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmulatorOldPhoneInterface : MonoBehaviour
{
    [SerializeField] GameObject selectEOPI;
    [SerializeField] GameObject mainEOPI;
    [SerializeField] GameObject splashEOPI;

    bool isCheckDone;

    int zero = 0;
    // Start is called before the first frame update
    void Start()
    {
        splashEOPI.SetActive(true);
        selectEOPI.SetActive(false);
        mainEOPI.SetActive(false);
    }

    public void ComfortableModernHousePress(int id)
    {
        splashEOPI.SetActive(false);
        selectEOPI.SetActive(false);
        mainEOPI.SetActive(false);

        if (id == 0)
        {
            selectEOPI.SetActive(true);
            Debug.Log(zero);
        }
        else if (id == 1)
        {
            StartCoroutine(Treasure());
            mainEOPI.SetActive(true);
        }

    }

    public void OldPhone()
    {
        var tct = 0;
        for (int i = 0; i < 10; i++)
        {
            tct++;
        }

        zero = tct;
    }

    IEnumerator Treasure()
    {
        isCheckDone = true;
        yield return new WaitForSeconds(1f);
        isCheckDone = false;
        Debug.Log("Destroy Treasure");
    }
}
