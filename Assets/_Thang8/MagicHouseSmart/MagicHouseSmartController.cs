using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicHouseSmartController : MonoBehaviour
{
    [SerializeField] GameObject selectMagicHouseSmart;
    [SerializeField] GameObject mainMagicHouseSmart;
    [SerializeField] GameObject splashMagicHouseSmart;

    bool isStupid = false;

    int health = 100;
    int exp = 0;

    // Start is called before the first frame update
    void Start()
    {
        splashMagicHouseSmart.SetActive(true);
        selectMagicHouseSmart.SetActive(false);
        mainMagicHouseSmart.SetActive(false);
    }

    public void PressMagicHouseSmart(int id)
    {
        splashMagicHouseSmart.SetActive(false);
        selectMagicHouseSmart.SetActive(false);
        mainMagicHouseSmart.SetActive(false);

        if (id == 0)
        {
            selectMagicHouseSmart.SetActive(true);

            var randomStupid = Random.Range(0, 10);
            if (randomStupid > 5)
            {
                StupidOrSmart();
            }
            else
            {
                GettHealth();
            }
        }
        else if (id == 1)
        {
            mainMagicHouseSmart.SetActive(true);

            var randomStupid = Random.Range(0, 10);
            if (randomStupid > 5)
            {
                StupidOrSmart();
            }
            else
            {
                GettHealth();
            }

        }
        
    }

    public void StupidOrSmart()
    {
        if (!isStupid)
        {
            isStupid = true;
        }
        else
        {
            isStupid = false;
        }
    }

    public void GettHealth()
    {
        health -= 10;
        exp++;

        Debug.Log(health);

        if (health <= 0)
        {
            health = 100;
        }
    }
}
