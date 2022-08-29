using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandyMapWorldController : MonoBehaviour
{
    [SerializeField] GameObject selectHandyMapWorld;
    [SerializeField] GameObject mainHandyMapWorld;
    [SerializeField] GameObject splashHandyMapWorld;

    bool isStupid = false;

    int health = 100;
    int exp = 0;

    // Start is called before the first frame update
    void Start()
    {
        splashHandyMapWorld.SetActive(true);
        selectHandyMapWorld.SetActive(false);
        mainHandyMapWorld.SetActive(false);
    }

    public void PressHandyMapWorld(int id)
    {
        splashHandyMapWorld.SetActive(false);
        selectHandyMapWorld.SetActive(false);
        mainHandyMapWorld.SetActive(false);

        if (id == 0)
        {
            selectHandyMapWorld.SetActive(true); 
            ShowSelectHandyMapWorld();
            StartCoroutine(IEMap());

        }
        else if (id == 1)
        {
            mainHandyMapWorld.SetActive(true);
            ShowMainHandyMapWorld();
            StartCoroutine(IEMap());
        }

    }

    IEnumerator IEMap()
    {
        for (int i = 0; i < 5; i++)
        {
            exp += Random.Range(0, 100);

            yield return new WaitForSeconds(.5f);
        }
        
        for (int i = 0; i < 5; i++)
        {
            health -= Random.Range(0, 10);

            if (health <= 0)
            {
                health = 100;
            }
            yield return new WaitForSeconds(.5f);
        }
    }

    public void ShowSelectHandyMapWorld()
    {
        selectHandyMapWorld.SetActive(true);
    }

    public void ShowSplashHandyMapWorld()
    {
        splashHandyMapWorld.SetActive(true);
    }

    public void ShowMainHandyMapWorld()
    {
        mainHandyMapWorld.SetActive(true);
    }

    public void Hide()
    {
        splashHandyMapWorld.SetActive(false);
        selectHandyMapWorld.SetActive(false);
        mainHandyMapWorld.SetActive(false);
    }
}
