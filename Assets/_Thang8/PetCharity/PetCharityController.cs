using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetCharityController : MonoBehaviour
{
    [SerializeField] GameObject selectPetCharity;
    [SerializeField] GameObject mainPetCharity;
    [SerializeField] GameObject splashPetCharity;

    // Start is called before the first frame update
    void Start()
    {
        splashPetCharity.SetActive(true);
        selectPetCharity.SetActive(false);
        mainPetCharity.SetActive(false);
    }

    public void PressPetCharity(int id)
    {
        splashPetCharity.SetActive(false);
        selectPetCharity.SetActive(false);
        mainPetCharity.SetActive(false);

        if (id == 0)
        {
            selectPetCharity.SetActive(true);
        }
        else if (id == 1)
        {
            mainPetCharity.SetActive(true);
        }
    }
}
