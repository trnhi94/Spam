using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IAP_Item_Base : MonoBehaviour
{
    [SerializeField]
    internal int _productID;
    [SerializeField] private TextMeshProUGUI _txtPrice;
    [SerializeField] private TextMeshProUGUI _txtTitle;

    private void OnEnable()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(Buy);
        GetTitle();
        GetPrice();
    }

    [SerializeField]
    IAP_Manager _iapManager;
    //SubcribeManager subManager;

    private void Awake()
    {
        _iapManager = FindObjectOfType<IAP_Manager>();
    }

    private void Buy()
    {

        Debug.Log(IAP_Manager.id[_productID]);
        if (_iapManager != null && !string.IsNullOrEmpty(IAP_Manager.id[_productID]))
        {
            _iapManager.BuyProductID(IAP_Manager.id[_productID], (result) =>
            {
                BuyCallBack(result, IAP_Manager.id[_productID]);
            });
        }
    }

    private void OnDisable()
    {
        GetComponentInChildren<UnityEngine.UI.Button>().onClick.RemoveAllListeners();
    }

    public virtual void BuyCallBack(bool result, string productID)
    {
        return;
        if (!result) return;

        if (productID.Equals(IAP_Manager.id[0]))
        {
            if (IAP_Manager.instance._arrProducts[0].isBuy == false)
            {
            }
        }

        if (productID.Equals(IAP_Manager.id[1]))
        {
            if (IAP_Manager.instance._arrProducts[1].isBuy == false)
            {
            }
        }

        if (productID.Equals(IAP_Manager.id[2]))
        {
            if (IAP_Manager.instance._arrProducts[2].isBuy == false)
            {
            }
        }

        if (productID.Equals(IAP_Manager.id[3]))
        {
            if (IAP_Manager.instance._arrProducts[3].isBuy == false)
            {
            }
        }
        if (productID.Equals(IAP_Manager.id[4]))
        {
            if (IAP_Manager.instance._arrProducts[4].isBuy == false)
            {
            }
        }
        if (productID.Equals(IAP_Manager.id[5]))
        {
            if (IAP_Manager.instance._arrProducts[5].isBuy == false)
            {
            }
        }
        if (productID.Equals(IAP_Manager.id[6]))
        {
            if (IAP_Manager.instance._arrProducts[6].isBuy == false)
            {
            }
        }
        if (productID.Equals(IAP_Manager.id[7]))
        {
            if (IAP_Manager.instance._arrProducts[7].isBuy == false)
            {
            }
        }
        if (productID.Equals(IAP_Manager.id[8]))
        {
            if (IAP_Manager.instance._arrProducts[8].isBuy == false)
            {
            }
        }if (productID.Equals(IAP_Manager.id[9]))
        {
            if (IAP_Manager.instance._arrProducts[9].isBuy == false)
            {
            }
        }if (productID.Equals(IAP_Manager.id[10]))
        {
            if (IAP_Manager.instance._arrProducts[10].isBuy == false)
            {
            }
        }

    }
    //public virtual void GetPrice(string productID)
    //{
    //    for (int i = 0; i < IAP_Manager.id.Count; i++)
    //    {
    //        gameObject.transform.GetComponentInChildren<Text>().text = IAP_Manager.instance.GetLocalizedPrice(IAP_Manager.id[_productID]);

    //    }
    //}

    public virtual void GetTitle()
    {
        _txtTitle.GetComponent<TextMeshProUGUI>().text = IAP_Manager.instance.GetLocalizedTitle(IAP_Manager.id[_productID]);
        if(_txtTitle.GetComponent<TextMeshProUGUI>().text == "Loading...")
        {
            gameObject.SetActive(false);
        }
    }

    public virtual void GetPrice()
    {
        _txtPrice.GetComponent<TextMeshProUGUI>().text = IAP_Manager.instance.GetLocalizedPrice(IAP_Manager.id[_productID]);
    }
}
