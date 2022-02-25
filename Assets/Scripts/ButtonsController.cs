using UnityEngine;
using UnityEngine.UI;

public class ButtonsController : MonoBehaviour
{
    public GameObject iconsController;
    public GameObject[] palyerButtons, enemyButtons;
    public Color enabledColor, disabledColor, deadColor;
    void Start()
    {
        UpdateButtons("player", iconsController.GetComponent<IconsController>().playerUnits);
        UpdateButtons("enemy", iconsController.GetComponent<IconsController>().enemyUnits);
    }
    public void UpdateButtons(string side, GameObject[] units)
    {
        if (side == "player")
        {
            for(int unit = 0; unit < iconsController.GetComponent<IconsController>().armySize; unit++)
            {
                if(units[unit] == null)
                {
                    palyerButtons[unit].GetComponent<Button>().interactable = false;
                    palyerButtons[unit].GetComponent<Image>().color = disabledColor;
                }
                else if (units[unit].GetComponent<Unit>().currentHP > 0)
                {
                    palyerButtons[unit].GetComponent<Button>().interactable = true;
                    palyerButtons[unit].GetComponent<Image>().color = enabledColor;
                }
                else
                {
                    palyerButtons[unit].GetComponent<Button>().interactable = false;
                    palyerButtons[unit].GetComponent<Image>().color = deadColor;
                }
            }
        }
        else
        {
            for(int unit = 0; unit < iconsController.GetComponent<IconsController>().armySize; unit++)
            {
                if(units[unit] == null)
                {
                    enemyButtons[unit].GetComponent<Button>().interactable = false;
                    enemyButtons[unit].GetComponent<Image>().color = disabledColor;
                }
                else if (units[unit].GetComponent<Unit>().currentHP > 0)
                {
                    enemyButtons[unit].GetComponent<Button>().interactable = true;
                    enemyButtons[unit].GetComponent<Image>().color = enabledColor;
                }
                else
                {
                    enemyButtons[unit].GetComponent<Button>().interactable = false;
                    enemyButtons[unit].GetComponent<Image>().color = deadColor;
                }
            }
        }
    }
    public void EnableSide(string side)
    {
        if(side == "player")
        {
            UpdateButtons("player", iconsController.GetComponent<IconsController>().playerUnits);
            GameObject[] units = iconsController.GetComponent<IconsController>().enemyUnits;
            for(int unit = 0; unit < iconsController.GetComponent<IconsController>().armySize; unit++)
            {
                if(units[unit] == null)
                {
                    enemyButtons[unit].GetComponent<Button>().interactable = false;
                    enemyButtons[unit].GetComponent<Image>().color = disabledColor;
                }
                else if (units[unit].GetComponent<Unit>().currentHP > 0)
                {
                    enemyButtons[unit].GetComponent<Button>().interactable = false;
                    enemyButtons[unit].GetComponent<Image>().color = disabledColor;
                }
                else
                {
                    enemyButtons[unit].GetComponent<Button>().interactable = false;
                    enemyButtons[unit].GetComponent<Image>().color = deadColor;
                }
            } 
            
        }
        else
        {
            UpdateButtons("enemy", iconsController.GetComponent<IconsController>().enemyUnits);
            GameObject[] units = iconsController.GetComponent<IconsController>().playerUnits;
            for(int unit = 0; unit < iconsController.GetComponent<IconsController>().armySize; unit++)
            {
                if(units[unit] == null)
                {
                    palyerButtons[unit].GetComponent<Button>().interactable = false;
                    palyerButtons[unit].GetComponent<Image>().color = disabledColor;
                }
                else if (units[unit].GetComponent<Unit>().currentHP > 0)
                {
                    palyerButtons[unit].GetComponent<Button>().interactable = false;
                    palyerButtons[unit].GetComponent<Image>().color = disabledColor;
                }
                else
                {
                    palyerButtons[unit].GetComponent<Button>().interactable = false;
                    palyerButtons[unit].GetComponent<Image>().color = deadColor;
                }
            }
        }
    }
}
