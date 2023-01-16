using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorclosed : MonoBehaviour
{
    [SerializeField] private GameObject picture;
    private Animator pictureopen;
    // Start is called before the first frame update
    void Start()
    {
        pictureopen = picture.GetComponent<Animator>();
    }

    private void OnTriggerExit(Collider other)
    {
        pictureopen.SetTrigger("picturemove");
    }
}
