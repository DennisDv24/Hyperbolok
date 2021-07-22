using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidingImageController : MonoBehaviour
{
	Image imageToHide;
	byte vel = 3;
    void OnEnable()
    {
       	imageToHide = GetComponent<Image>();
		var auxColor = imageToHide.color;
		if(auxColor.a > 1) auxColor.a = 1;
		imageToHide.color = auxColor;
    }
		
    void Update()
    {
		var auxColor = imageToHide.color;
		auxColor.a -= 0.05f;
		imageToHide.color = auxColor;
	}
    
}
