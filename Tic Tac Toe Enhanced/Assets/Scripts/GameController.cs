using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public int theme = 1;
	public TileController[] tiles;
	public Text bottomText;
	public bool gameover = false;
	private bool playerTurn;
	//0 - circle, 1 - cross
	void Start()
	{
		bottomText.text = "";
		int random = Random.Range(0, 2);
		if (random == 0)
		{
			playerTurn = false;
		}
		else
		{
			playerTurn = true;
		}
	}
	public void restart()
	{
		SceneManager.LoadScene("Main");
	}
	public void changeTheme()
	{
		if (theme == 1)
		{
			theme = 2;
		}
		else if (theme == 2)
		{
			theme = 1;
		}
		else
		{
			theme = 1;
		}
	}
	public void changePlayerTurn()
	{
		if (playerTurn == false)
		{
			playerTurn = true;
		}
		else
		{
			playerTurn = false;
		}
	}
	public bool getPlayerTurn()
	{
		return playerTurn;
	}
	public void checkForGameover()
	{
		if (
			//Victory in horizontal lines
			(tiles[0].Player == 'O' && tiles[1].Player == 'O' && tiles[2].Player == 'O') ||
			(tiles[3].Player == 'O' && tiles[4].Player == 'O' && tiles[5].Player == 'O') ||
			(tiles[6].Player == 'O' && tiles[7].Player == 'O' && tiles[8].Player == 'O') ||
			//Victory in vertical lines
			(tiles[0].Player == 'O' && tiles[3].Player == 'O' && tiles[6].Player == 'O') ||
			(tiles[1].Player == 'O' && tiles[4].Player == 'O' && tiles[7].Player == 'O') ||
			(tiles[2].Player == 'O' && tiles[5].Player == 'O' && tiles[8].Player == 'O') ||
			//Victory in cross lines
			(tiles[0].Player == 'O' && tiles[4].Player == 'O' && tiles[8].Player == 'O') ||
			(tiles[2].Player == 'O' && tiles[4].Player == 'O' && tiles[6].Player == 'O'))
		{
			gameover = true;
			bottomText.text = "Circle wins!";
		}
		else if (
			//Victory in horizontal lines
			(tiles[0].Player == 'X' && tiles[1].Player == 'X' && tiles[2].Player == 'X') ||
			(tiles[3].Player == 'X' && tiles[4].Player == 'X' && tiles[5].Player == 'X') ||
			(tiles[6].Player == 'X' && tiles[7].Player == 'X' && tiles[8].Player == 'X') ||
			//Victory in vertical lines
			(tiles[0].Player == 'X' && tiles[3].Player == 'X' && tiles[6].Player == 'X') ||
			(tiles[1].Player == 'X' && tiles[4].Player == 'X' && tiles[7].Player == 'X') ||
			(tiles[2].Player == 'X' && tiles[5].Player == 'X' && tiles[8].Player == 'X') ||
			//Victory in cross lines
			(tiles[0].Player == 'X' && tiles[4].Player == 'X' && tiles[8].Player == 'X') ||
			(tiles[2].Player == 'X' && tiles[4].Player == 'X' && tiles[6].Player == 'X'))
		{
			gameover = true;
			bottomText.text = "Cross wins!";
		}
		else if (
			(tiles[0].Player != 'E' && tiles[1].Player != 'E' && tiles[2].Player != 'E') &&
			(tiles[3].Player != 'E' && tiles[4].Player != 'E' && tiles[5].Player != 'E') &&
			(tiles[6].Player != 'E' && tiles[7].Player != 'E' && tiles[8].Player != 'E'))
		{
			gameover = true;
			bottomText.text = "It's a draw!";
		}
	}
}
