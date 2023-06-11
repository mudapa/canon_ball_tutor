using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CannonAmmo : MonoBehaviour
{
    public TextMeshProUGUI ammoText;

    public int totalAmmo;

    public int currentAmmo;
    
    public int CurrentAmmo
    {
        get { return currentAmmo; }
        set 
        { 
            currentAmmo = value;
            ammoText.text = "Ammo: " + currentAmmo + "/" + totalAmmo;
            print("Current Ammo: " + currentAmmo);
            if(currentAmmo <= 0 && GameManager.instance.fallenBrickAmount < GameManager.instance.fallenBrickNeeded)
            {
                GameManager.level = 1;
                print("You lose!");
                GameManager.instance.RestartGame();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.setAmmo += SetAmmo;    
    }

    private void OnDisable()
    {
        GameManager.instance.setAmmo -= SetAmmo;
    }

    private void SetAmmo()
    {
        totalAmmo = GameManager.instance.fallenBrickNeeded / 3;
        currentAmmo = totalAmmo;
        ammoText.text = "Ammo: " + currentAmmo + "/" + totalAmmo;
    }
}
