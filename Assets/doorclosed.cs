using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorclosed : MonoBehaviour
{
    [SerializeField] private GameObject doorhinge;
    private Animator DoorAni;
    // Start is called before the first frame update
    void Start()
    {
        DoorAni = doorhinge.GetComponent<Animator>();
    }

    private void OnTriggerExit(Collider other)
    {
        DoorAni.SetTrigger("doorclosed");
    }
}
