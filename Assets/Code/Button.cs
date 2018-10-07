using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {
	public Sprite[] States;
	public GameObject Laugh;

	public void OnPointerDown (PointerEventData eventData) {
		this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = States[1];
		Instantiate(Laugh);
	}

	public void OnPointerUp (PointerEventData eventData) {
		this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite = States[0];
	}
}
