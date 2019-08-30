using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 3f;
    float lives;
    [SerializeField] int damage = 1;
    TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        livesText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void TakeLives()
    {
        lives -= damage;
        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
        UpdateDisplay();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
