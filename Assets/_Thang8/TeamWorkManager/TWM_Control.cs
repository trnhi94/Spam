using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TWM_Control : MonoBehaviour
{
    [SerializeField] private GameObject _intro;
    [SerializeField] private GameObject _start;
    [SerializeField] private GameObject _main;

    [SerializeField] private Button _btnStart;

    private void Start()
    {
        _intro.SetActive(true);
        _start.SetActive(false);
        _main.SetActive(false);
        StartCoroutine(LoadingScene());
        _btnStart.onClick.AddListener(() =>
        {
            _start.SetActive(false);
            _main.SetActive(true);
        });
    }

    IEnumerator LoadingScene()
    {
        yield return new WaitForSeconds(2.2f);
        _intro.SetActive(false);
        _start.SetActive(true);
    }


}
