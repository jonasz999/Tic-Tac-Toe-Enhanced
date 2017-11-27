using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LogoTheme : MonoBehaviour
{
	public Sprite logoLight;
	public Sprite logoDark;
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
			GetComponent<Image>().sprite = logoLight;
		}
		else if (gameController.theme == 2)
		{
			GetComponent<Image>().sprite = logoDark;
		}
		else
		{
			GetComponent<Image>().sprite = logoLight;
		}
	}
}
