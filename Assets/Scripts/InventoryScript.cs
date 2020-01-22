using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class InventoryScript : MonoBehaviour, IPointerDownHandler
{
    public bool InventoryIsOpen = false;

    [SerializeField]
    private GameObject Inventory;

    [SerializeField]
    private GameObject SubMenuCanvas;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (InventoryIsOpen)
        {
            Inventory.SetActive(false);
            SubMenuCanvas.SetActive(false);
            InventoryIsOpen = false;
            Time.timeScale = 1; 
        }
        else
        {
            Inventory.SetActive(true);
            SubMenuCanvas.SetActive(true);
            InventoryIsOpen = true;
            Time.timeScale = 0; // No more update
        }
    }
}
