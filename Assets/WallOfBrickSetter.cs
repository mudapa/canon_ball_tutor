using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallOfBrickSetter : MonoBehaviour
{
    private void Start()
    {
        GameManager.instance.fallenBrickNeeded += transform.childCount;
        GameManager.instance.SetAmmo();
    }
}
