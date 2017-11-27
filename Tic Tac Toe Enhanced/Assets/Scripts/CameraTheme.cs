using UnityEngine;
using System.Collections;

public class CameraTheme : MonoBehaviour
{
	public Color colorLight;
	public Color colorDark;
	private GameController gameController;
	void Start()
	{
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent<GameController>();
		}
		if (gameController == null)
		{
			Debug.Log("Could not find 'GameController' script!");
		}
	}
	void Update()
	{
		if (gameController.theme == 1)
		{
			GetComponent<Camera>().backgroundColor = colorLight;
		}
		else if (gameController.theme == 2)
		{
			GetComponent<Camera>().backgroundColor = colorDark;
		}
		else
		{
			GetComponent<Camera>().backgroundColor = colorLight;
		}
	}
}
