using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFB_Control : MonoBehaviour
{
    [SerializeField] private GameObject pnlIntro;
    [SerializeField] private GameObject pnl1;
    [SerializeField] private GameObject pnl2;

    private void Start()
    {
        pnlIntro.SetActive(true);
        pnl1.SetActive(false);
        pnl2.SetActive(false);
        StartCoroutine(FinishLoading());
    }

    IEnumerator FinishLoading()
    {
        yield return new WaitForSeconds(2f);
        pnlIntro.SetActive(false);
        pnl1.SetActive(true);
    }
}
