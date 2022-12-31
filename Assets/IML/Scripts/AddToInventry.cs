using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToInventry : MonoBehaviour
{

   // [SerializeField] private GameObject Inventry;

    public void AddItem(GameObject Item)
    {
        Item.SetActive(true);
    }

    public void RemoveItem(GameObject Item)
    {
        Item.SetActive(false);
    }
}
