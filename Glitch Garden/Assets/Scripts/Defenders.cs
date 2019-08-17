using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour
{
    [SerializeField] int cost = 100;

    public void CostDisplay(int number)
    {
        FindObjectOfType<CostDisplay>().AddCost(number);
    }

    public int GetCost()
    {
        return cost;
    }


}
