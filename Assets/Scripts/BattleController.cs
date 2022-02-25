using UnityEngine;

public class BattleController : MonoBehaviour
{
    public bool isPlayerMove = true;
    public int[] playerUnitHP, enemyUnitHP;
    private int armySize;
    public int currentUnit;
    void Start()
    {
        armySize = gameObject.GetComponent<IconsController>().armySize;
        playerUnitHP = new int[armySize];
        enemyUnitHP = new int[armySize];
        for(int unit = 0; unit < armySize; unit++)
        {
            if(gameObject.GetComponent<IconsController>().playerUnits[unit] != null) playerUnitHP[unit] = gameObject.GetComponent<IconsController>().playerUnits[unit].GetComponent<Unit>().currentHP;
            if(gameObject.GetComponent<IconsController>().enemyUnits[unit] != null) enemyUnitHP[unit] = gameObject.GetComponent<IconsController>().enemyUnits[unit].GetComponent<Unit>().currentHP;
        }
    }
    public void Interact(int unit)
    {
        if(isPlayerMove)
        {
            gameObject.GetComponent<IconsController>().enemyUnits[unit].GetComponent<Unit>().currentHP -= gameObject.GetComponent<IconsController>().playerUnits[currentUnit].GetComponent<Unit>().attack;
        }
        gameObject.GetComponent<IconsController>().UpdateIcons(gameObject.GetComponent<IconsController>().playerUnits, gameObject.GetComponent<IconsController>().playerIcons);
        gameObject.GetComponent<IconsController>().UpdateIcons(gameObject.GetComponent<IconsController>().enemyUnits, gameObject.GetComponent<IconsController>().enemyIcons);
    }
}
