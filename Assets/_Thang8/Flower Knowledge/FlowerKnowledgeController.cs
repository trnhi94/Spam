using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerKnowledgeController : MonoBehaviour
{
    [SerializeField] GameObject splashGo;
    [SerializeField] GameObject selectGo;
    [SerializeField] GameObject mainGo;

    // Start is called before the first frame update
    void Start()
    {
        splashGo.SetActive(true);
        selectGo.SetActive(false);
        mainGo.SetActive(false);
    }

    public void PressMainFlowerKnowledge()
    {
        splashGo.SetActive(false);
    }


    public void Press(int id)
    {
        splashGo.SetActive(false);
        selectGo.SetActive(false);
        mainGo.SetActive(false);

        if (id == 0)
        {
            selectGo.SetActive(true);
        }
        else if(id == 1)
        {
            mainGo.SetActive(true);
        }
    }
}
