using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIA_control : MonoBehaviour
{
    [SerializeField] private GameObject pnlIntro;
    [SerializeField] private GameObject pnl1;
    [SerializeField] private GameObject pnl2;

    private void Start()
    {
        pnlIntro.SetActive(true);
        pnl1.SetActive(false);
        pnl2.SetActive(false);
        StartCoroutine(Finish());
    }

    IEnumerator Finish()
    {
        yield return new WaitForSeconds(2.1f);
        pnlIntro.SetActive(false);
        pnl1.SetActive(true);
    }
}
