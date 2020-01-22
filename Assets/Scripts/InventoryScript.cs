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

    public void OnPointerDown(PointerEventData eventData)
    {
        if (InventoryIsOpen)
        {
            Inventory.SetActive(false);
            InventoryIsOpen = false;
        }
        else
        {
            Inventory.SetActive(true);
            InventoryIsOpen = true;
        }
    }
}
