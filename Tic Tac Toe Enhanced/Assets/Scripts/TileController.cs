using UnityEngine;
using System.Collections;
using System;

public class TileController : MonoBehaviour
{
	public GameObject O;
	public GameObject X;
	public Sprite emptyLight;
	public Sprite emptyDark;
	public ParticleSystem particleO;
	public ParticleSystem particleX;
	private GameController gameController;
	[NonSerializedAttribute]
	public char Player = 'E';

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

	void OnMouseDown()
	{
		if (gameController.gameover == false)
		{
			setPlayer(gameController.getPlayerTurn());
		}
	}

	void setPlayer(bool playerTurn)
	{
		if (playerTurn == false && Player == 'E')
		{
			O.SetActive(true);
			X.SetActive(false);
			ParticleSystem psO = (ParticleSystem)Instantiate(particleO);
			psO.transform.position = O.transform.position;
			psO.Play();
			Player = 'O';
			gameController.changePlayerTurn();
		}
		else if (playerTurn == true && Player == 'E')
		{
			O.SetActive(false);
			X.SetActive(true);
			Player = 'X';
			/*particleX.transform.position = O.transform.position;
			particleX.Play();*/
			ParticleSystem psX = (ParticleSystem)Instantiate(particleX);
			psX.transform.position = X.transform.position;
			psX.Play();
			gameController.changePlayerTurn();
		}
		gameController.checkForGameover();
	}

	void Update()
	{
		if (gameController.theme == 1)
		{
			GetComponent<SpriteRenderer>().sprite = emptyLight;
		}
		else if (gameController.theme == 2)
		{
			GetComponent<SpriteRenderer>().sprite = emptyDark;
		}
		else
		{
			GetComponent<SpriteRenderer>().sprite = emptyLight;
		}
	}
}
