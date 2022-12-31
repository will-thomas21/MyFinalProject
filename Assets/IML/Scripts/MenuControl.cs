using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{

    [SerializeField] private GameObject MenuScreenOne;
    [SerializeField] private GameObject MenuScreenTwo;
    [SerializeField] private GameObject Inventry;
    [SerializeField] private bool EnableInventry;

    void Start()
    {
        MenuScreenTwo.SetActive(false);
        if (EnableInventry == false) {
            Inventry.SetActive(false);
        }
        else
        {
            Inventry.SetActive(true);
        }

    }


    public void MenuScreenTwoOpen()
    {
        MenuScreenTwo.SetActive(true);
        MenuScreenOne.SetActive(false);
    }

    public void MenuScreenOneOpen()
    {
        MenuScreenTwo.SetActive(false);
        MenuScreenOne.SetActive(true);
    }
}
