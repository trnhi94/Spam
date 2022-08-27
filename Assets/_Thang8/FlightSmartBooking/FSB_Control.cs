using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FSB_Control : MonoBehaviour
{
    [SerializeField] private GameObject _pnlIntro;
    [SerializeField] private GameObject _pnlStart;
    [SerializeField] private GameObject _pnlMain;
    [SerializeField] private GameObject _icon;


    [SerializeField] private Button _btnStart;

    private void Start()
    {
        _pnlIntro.SetActive(true);
        _pnlStart.SetActive(false);
        _pnlMain.SetActive(false);
        StartCoroutine(LoadingScene());
        _btnStart.onClick.AddListener(() =>
        {
            _pnlStart.SetActive(false);
            _pnlMain.SetActive(true);
        });
        _icon.transform.localScale = Vector3.zero;
        _icon.transform.DOScale(Vector3.one, 1f);
    }

    IEnumerator LoadingScene()
    {
        yield return new WaitForSeconds(1.5f);
        _pnlIntro.SetActive(false);
        _pnlStart.SetActive(true);
    }
}
