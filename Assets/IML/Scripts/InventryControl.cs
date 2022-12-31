using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventryControl : MonoBehaviour
{

    [SerializeField] private GameObject MenuScreenOne;
    [SerializeField] private GameObject MenuScreenTwo;

    void Start()
    {
        MenuScreenTwo.SetActive(false);
    }

  

    public void MenuScreenTwoOpen()
    {
        MenuScreenTwo.SetActive(true);
        MenuScreenOne.SetActive(false);
    }

}
