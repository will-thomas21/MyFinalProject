using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadCanvasImage : MonoBehaviour
{
    //Image Holder is where the new Image will be Loaded
    [SerializeField] private GameObject ImageHolder;

    //Image Name to be loaded, will look in Resources/Images for Image with same name,
    //Images must be stored in folder called Resources to load at runtime (I've also added Image folder inside Resources to keep tidy)
    [SerializeField] public string ImageName;
    
    void Start()
    {
       // LoadImage();
    }

    //Below Loads the Image based on string name supplied in Inspector panel
    public void LoadImage()
    {
        var ImageLoader = ImageHolder.GetComponent<Image>();
        ImageLoader.sprite = Resources.Load<Sprite>("Images/" + ImageName);
        ImageLoader.SetNativeSize();
    }

    //Below Loads the Image based on string name supplied from canvas button
    public void LoadImageToUI(string ImageName)
    {
        var ImageLoader = ImageHolder.GetComponent<Image>();
        ImageLoader.sprite = Resources.Load<Sprite>("Images/" + ImageName);
        ImageLoader.SetNativeSize();
    }
}
