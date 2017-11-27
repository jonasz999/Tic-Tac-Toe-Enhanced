using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BottomTextTheme : MonoBehaviour
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
			GetComponent<Text>().color = colorLight;
		}
		else if (gameController.theme == 2)
		{
			GetComponent<Text>().color = colorDark;
		}
		else
		{
			GetComponent<Text>().color = colorLight;
		}
	}
}
