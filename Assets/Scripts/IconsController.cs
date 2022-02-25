using UnityEngine;
using TMPro;

public class IconsController : MonoBehaviour
{
    public int armySize;
    public GameObject[] playerUnits, enemyUnits;
    public GameObject[] playerIcons, enemyIcons;
    void Start()
    {
        UpdateIcons(playerUnits, playerIcons);
        UpdateIcons(enemyUnits, enemyIcons);
    }
    public void UpdateIcons(GameObject[] units, GameObject[] icons)
    {
        for(int unit = 0; unit < armySize; unit++)
        {
            if(units[unit] != null)
            {
                TMP_Text[] texts = icons[unit].GetComponentsInChildren<TMP_Text>();
                texts[0].text = units[unit].GetComponent<Unit>().unitName;
                texts[1].text = units[unit].GetComponent<Unit>().currentHP.ToString() + " / " + units[unit].GetComponent<Unit>().maxHP.ToString();
            }
            else
            {
                TMP_Text[] texts = icons[unit].GetComponentsInChildren<TMP_Text>();
                texts[0].text = "";
                texts[1].text = "";
            }
        }
    }
}
