using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmazingMusicController : MonoBehaviour
{
    [SerializeField] GameObject selectAmazingMusic;
    [SerializeField] GameObject mainAmazingMusic;
    [SerializeField] GameObject splashAmazingMusic;

    bool isCheck;

    private Transform player;
    private Vector3 tempPos;

    // Start is called before the first frame update
    void Start()
    {
        splashAmazingMusic.SetActive(true);
        selectAmazingMusic.SetActive(false);
        mainAmazingMusic.SetActive(false);
    }

    public void AmazingMusicPress(int id)
    {
        splashAmazingMusic.SetActive(false);
        selectAmazingMusic.SetActive(false);
        mainAmazingMusic.SetActive(false);

        if (id == 0)
        {
            selectAmazingMusic.SetActive(true);
        }
        else if (id == 1)
        {
            mainAmazingMusic.SetActive(true);
        }

        //FunnyApp();

        Debug.Log(HiHi());
    }

    public void FunnyApp()
    {
        tempPos = transform.position;
        tempPos.x = player.position.x;
        transform.position = tempPos;

        isCheck = isCheck == false ? true : false;
    }


    public bool HiHi()
    {
        if (player == null)
        {
            return false;
        }

        return true;
    }
}