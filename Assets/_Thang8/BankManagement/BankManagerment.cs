using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankManagerment : MonoBehaviour
{
    [SerializeField] GameObject selectBankManagement;
    [SerializeField] GameObject mainBankManagement;
    [SerializeField] GameObject splashBankManagement;

    void Start()
    {
        splashBankManagement.SetActive(true);
        selectBankManagement.SetActive(false);
        mainBankManagement.SetActive(false);
    }

    public void BankManagementPress(int id)
    {
        splashBankManagement.SetActive(false);
        selectBankManagement.SetActive(false);
        mainBankManagement.SetActive(false);

        if (id == 0)
        {
            selectBankManagement.SetActive(true);
        }
        else if (id == 1)
        {
            mainBankManagement.SetActive(true);
        }

        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters()
    {
        var randomSide = Random.Range(0,3);
        yield return new WaitForSeconds(Random.Range(1, 5));
        int temp = 0;

        // left side
        if (randomSide == 0)
        {
            Debug.Log("Zeroooo");
            temp = 0;
        }
        else
        {
            Debug.Log("Another");
            temp = randomSide;
        }
    }
    
}
