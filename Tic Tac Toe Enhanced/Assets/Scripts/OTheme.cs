using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OTheme : MonoBehaviour
{
	public Sprite circleLight;
	public Sprite circleDark;
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
			GetComponent<SpriteRenderer>().sprite = circleLight;
		}
		else if (gameController.theme == 2)
		{
			GetComponent<SpriteRenderer>().sprite = circleDark;
		}
		else
		{
			GetComponent<SpriteRenderer>().sprite = circleLight;
		}
	}
}
