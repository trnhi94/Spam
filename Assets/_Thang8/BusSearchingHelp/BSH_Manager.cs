using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSH_Manager : MonoBehaviour
{
    [SerializeField] private GameObject loadingScene;
    [SerializeField] private GameObject mainScene;

    private void Start()
    {
        loadingScene.SetActive(true);
        mainScene.SetActive(false);
        StartCoroutine(FinishLoading());
    }

    IEnumerator FinishLoading()
    {
        yield return new WaitForSeconds(2f);
        loadingScene.SetActive(false);
        mainScene.SetActive(true);
    }    
}
