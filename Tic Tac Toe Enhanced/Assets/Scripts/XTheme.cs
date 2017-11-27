using UnityEngine;
using System.Collections;

public class XTheme : MonoBehaviour
{
	public Sprite crossLight;
	public Sprite crossDark;
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
			GetComponent<SpriteRenderer>().sprite = crossLight;
		}
		else if (gameController.theme == 2)
		{
			GetComponent<SpriteRenderer>().sprite = crossDark;
		}
		else
		{
			GetComponent<SpriteRenderer>().sprite = crossLight;
		}
	}
}
