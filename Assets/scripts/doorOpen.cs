using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{

    [SerializeField] private GameObject doorhinge;
    private Animator DoorAni;
    // Start is called before the first frame update
    void Start()
    {
        DoorAni = doorhinge.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="key")
        {
            DoorAni.SetTrigger("dooropen");
        }
    }
}
