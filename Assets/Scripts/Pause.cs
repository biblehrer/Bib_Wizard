using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.pause = this;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickContinue()
    {
        ToggleBreak();
    }

    public void OnToTitle()
    {
        GameManager.Instance.ReturnToTitle();
    }

    public void ToggleBreak()
    {
        gameObject.SetActive(!gameObject.activeSelf);
        if (gameObject.activeSelf)
        {
            GameManager.Instance.state = GameManager.Instance.state = "Break";
            Time.timeScale = 0;
        }
        else
        {
            GameManager.Instance.state = GameManager.Instance.state = "Game";
            Time.timeScale = 1;
        }
        
    }

}
