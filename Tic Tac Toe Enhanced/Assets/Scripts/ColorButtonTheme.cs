using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorButtonTheme : MonoBehaviour
{
	public Sprite colorButtonLight;
	public Sprite colorButtonDark;
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
			GetComponent<Image>().sprite = colorButtonLight;
		}
		else if (gameController.theme == 2)
		{
			GetComponent<Image>().sprite = colorButtonDark;
		}
		else
		{
			GetComponent<Image>().sprite = colorButtonLight;
		}
	}
}
