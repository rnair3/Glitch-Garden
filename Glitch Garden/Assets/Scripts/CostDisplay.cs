using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CostDisplay : MonoBehaviour
{
    [SerializeField] int cost = 100;
    TextMeshProUGUI costText;


    // Start is called before the first frame update
    void Start()
    {
        costText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateDisplay()
    {
        costText.text = cost.ToString();
    }

    public void AddCost(int number)
    {
        cost += number;
        UpdateDisplay();
    }

    public void SpendCost(int number)
    {
        if(HaveEnoughCost(number))
        {
            cost -= number;
        }
        
        UpdateDisplay();
    }

    public bool HaveEnoughCost(int amount)
    {
        if(cost >= amount)
        {
            return true;
        }
        return false;
    }
}
