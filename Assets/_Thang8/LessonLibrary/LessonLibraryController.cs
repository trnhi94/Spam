using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonLibraryController : MonoBehaviour
{
    [SerializeField] GameObject splashGo;
    [SerializeField] GameObject mainGo;

    // Start is called before the first frame update
    void Start()
    {
        splashGo.SetActive(true);
        mainGo.SetActive(false);
    }

    public void PressMainOutfit()
    {
        splashGo.SetActive(false);
        mainGo.SetActive(true);

    }

    public void PressBackLessonLibrary()
    {
        splashGo.SetActive(true);
        mainGo.SetActive(false);
    }
}
