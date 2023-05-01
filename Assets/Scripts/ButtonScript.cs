using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
	public static Graphic button;
	public static Color basicColor = Color.black;
	public static Color hoverColor = Color.blue;

	void Start()
	{
		GetComponent<Graphic>().color = basicColor;
	}
	public void OnPointerEnter(PointerEventData button)
	{
		GetComponent<Graphic>().color = hoverColor;

	}

	public void OnPointerExit(PointerEventData button)
	{
		GetComponent<Graphic>().color = basicColor;
	}
}
