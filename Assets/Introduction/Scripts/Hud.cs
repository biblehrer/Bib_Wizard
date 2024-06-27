using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text healthText;
    public TMP_Text manaText;
    public TMP_Text levelText;



    public Image healthImage;
    public Image manaImage;
    public Image xpImage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Create some Variables that we can use for displaying
        Wizard wizard = Wizard.player;
        PlayerStats stats = Wizard.stats;
        float maxMana = stats.maxMana;
        int maxHP = stats.maxHP;
        int displayMana = (int) wizard.mana;
        int displayHealth = (int) wizard.hp;

        // Adjust the Player Stats Texts 
        int score = GameManager.Instance.score;
        scoreText.text  = "Score " + score;
        healthText.text = "Health: " + displayHealth + "/" + maxHP;
        manaText.text   = "Mana:   " + displayMana + "/" + maxMana;
        levelText.text  = "Level:  " + stats.level;

        // Adjust Healthbars
        float healthPercentage = (float)  wizard.hp / (float) maxHP;
        healthImage.transform.localScale = new Vector3(healthPercentage, 1,1 );

        float manaPercentage = (float)  wizard.mana / (float) maxMana;
        manaImage.transform.localScale = new Vector3(manaPercentage, 1,1 );

        float xpPercentage = (float)  stats.xp / (float) (stats.level*3f);
        xpImage.transform.localScale = new Vector3(xpPercentage, 1,1 );

    }
}
