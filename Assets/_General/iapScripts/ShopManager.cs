using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    [SerializeField] GameObject Content;
    [SerializeField] GameObject panel;

    public string ScenePlay;

    public void Show()
    {
        Content.SetActive(true);
        panel.SetActive(true);
    }

    public void Hide()
    {
        Content.SetActive(false);
        panel.SetActive(false);
    }

    public void PlayBtn()
    {
        SceneManager.LoadScene(ScenePlay);
    }
}
