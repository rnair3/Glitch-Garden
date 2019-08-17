using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
     Defenders defender;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {

        AttemptToPlace(GetSquareClicked());
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clicked = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clicked);
        Vector2 gridPos = SnapToGrid(worldPos);

        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 worldPos)
    {
        float x = Mathf.RoundToInt(worldPos.x);
        float y = Mathf.RoundToInt(worldPos.y);

        return new Vector2(x, y);
    }

    private void SpawnDefender(Vector2 worldPos)
    {
        Defenders defenderObject = Instantiate(defender, worldPos, Quaternion.identity) as Defenders;
    }

    public void SetDefenders(Defenders selectedDefender)
    {
        defender = selectedDefender;
    }

    private void AttemptToPlace(Vector2 pos)
    {
        var costDisplay = FindObjectOfType<CostDisplay>();
        int defenderCost = defender.GetCost();

        if (costDisplay.HaveEnoughCost(defenderCost))
        {
            SpawnDefender(pos);
            costDisplay.SpendCost(defenderCost);
        }
    }
}
