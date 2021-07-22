using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowingImageController : MonoBehaviour
{

	Image imageToShow;
	byte i = 0;
    void OnEnable()
    {
       	imageToShow = GetComponent<Image>();
		var auxColor = imageToShow.color;
		if(auxColor.a < 0) auxColor.a = 0;
		imageToShow.color = auxColor;
    }
		
    void Update()
    {
    	//imageToShow.color = new Color32(255,255,255, i); 
		//if(i != 255) i += 3;
		
		var auxColor = imageToShow.color;
		auxColor.a += 0.05f;
		imageToShow.color = auxColor;
	}

}
