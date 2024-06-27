using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public string state = "Start";
    public int score;
    private float Counter;
    public Pause pause;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            score=0;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case "Game":
                Counter += Time.deltaTime;
                if (Counter >= 20)
                {
                    ReturnToTitle();
                    Counter = 0;
                }

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    //pause.GetComponent<Pause()>().ToggleBreak();
                    pause.ToggleBreak();
                }
                break;
            case "Break":
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    pause.ToggleBreak();
                }
                break;
        }
    }

    public void ReturnToTitle()
    {
        SceneManager.LoadScene("StartScreen");
        state = "Start";
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("Game");
        state = "Game";
    }

    public void OnNewGame()
    {
        score = 0;
        Wizard.stats = new PlayerStats();
        SceneManager.LoadScene("Game");
        state = "Game";
    }
}
