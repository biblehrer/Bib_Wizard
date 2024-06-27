using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class TitleButtons : MonoBehaviour
{
    public void ClickOnStart() 
    {
        GameManager.Instance.OnClickStart();
    }

    public void ClickNewGame() 
    {        
        GameManager.Instance.OnNewGame();
    }

    public void ClickOnExit() 
    {
        Application.Quit();
    }
}
