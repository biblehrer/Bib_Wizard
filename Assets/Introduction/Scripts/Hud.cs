using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text healthText;
    public TMP_Text manaText;
    public TMP_Text levelText;
    public static int score = 0;


    public Image healthImage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Wizard w = Wizard.player;
        PlayerStats s = w.stats;
        float maxMana = s.maxMana;
        int maxHP = s.maxHP;
        int displayMana = (int) w.mana;

        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + w.hp + "/" + maxHP;
        manaText.text = "Mana: " + displayMana + "/" + maxMana;
        levelText.text = "Level: " + s.level;

        // Testing
        //gameObject.SetActive(!gameObject.activeSelf);

        float healthPercentage = (float)  w.hp / (float) maxHP;
        healthImage.transform.localScale = new Vector3(healthPercentage, 1,1 );
    }
}
