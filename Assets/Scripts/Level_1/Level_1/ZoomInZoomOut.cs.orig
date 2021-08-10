using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomInZoomOut : MonoBehaviour
{
	Camera mainCamera;

	float touchesPrevPosDifference, touchesCurPosDifference, zoomModifier;

	Vector2 firstTouchPrevPos, secondTouchPrevPos;

	[SerializeField]
	float zoomModifierSpeed = 0.1f;

	public float xmenorValor, xmaiorValor, ymenorValor, ymaiorValor;

	private Vector3 Origin;
	private Vector3 Diference;
	private bool Drag = false;

	public bool pickedObject = false;

	public bool trigger = false;

	void Start()
	{
		mainCamera = GetComponent<Camera>();
	}

	void Update()
	{
		if (Input.GetMouseButton(0) && trigger == false)
		{
			Diference = (Camera.main.ScreenToWorldPoint(Input.mousePosition)) - Camera.main.transform.position;
			if (Drag == false)
			{
				Origin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				Drag = true;
			}
		}
		else
		{
			Drag = false;
		}

		if (Drag == true)
		{
			var Dif = mainCamera.orthographicSize - 2f;

			var xMin = xmenorValor + Dif;
			var xMax = xmaiorValor - Dif;

			var yMin = ymenorValor + Dif;
			var yMax = ymaiorValor - Dif;

			Camera.main.transform.position = Origin - Diference;

			transform.position = new Vector3(
			Mathf.Clamp(transform.position.x, xMin, xMax),
			Mathf.Clamp(transform.position.y, yMin, yMax),
			transform.position.z);
		}

		if (Input.touchCount == 2)
		{
			Touch firstTouch = Input.GetTouch(0);
			Touch secondTouch = Input.GetTouch(1);

			firstTouchPrevPos = firstTouch.position - firstTouch.deltaPosition;
			secondTouchPrevPos = secondTouch.position - secondTouch.deltaPosition;

			touchesPrevPosDifference = (firstTouchPrevPos - secondTouchPrevPos).magnitude;
			touchesCurPosDifference = (firstTouch.position - secondTouch.position).magnitude;

			zoomModifier = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * zoomModifierSpeed;

			if (touchesPrevPosDifference > touchesCurPosDifference)
				mainCamera.orthographicSize += zoomModifier;
			if (touchesPrevPosDifference < touchesCurPosDifference)
				mainCamera.orthographicSize -= zoomModifier;
		}

		mainCamera.orthographicSize = Mathf.Clamp(mainCamera.orthographicSize, 2f, 8f);

		Debug.Log(Input.mouseScrollDelta);
	}
}