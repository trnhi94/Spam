using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] Transform mainTrans;
    [SerializeField] Transform selectTrans;
    [SerializeField] Transform showTrans;

    private void Start()
    {
        mainTrans.gameObject.SetActive(true);
    }

    public void PressShowRecipe()
    {
        selectTrans.gameObject.SetActive(false);
        showTrans.gameObject.SetActive(true);
    }

    public void PressSelected()
    {
        selectTrans.gameObject.SetActive(true);
        mainTrans.gameObject.SetActive(false);
    }

    public void PressBack()
    {
        selectTrans.gameObject.SetActive(true);
        showTrans.gameObject.SetActive(false);
    }
}
