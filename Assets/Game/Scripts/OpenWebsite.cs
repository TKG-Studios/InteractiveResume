using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.InventoryEngine;
public class OpenWebsite : MonoBehaviour
{
    public Inventory[] inventories;
    public void OpenURL()
    {
        Application.OpenURL("https://christopherguyton.com/thanks-for-playing-my-resume/");


        Application.Quit();
       
    }
}
