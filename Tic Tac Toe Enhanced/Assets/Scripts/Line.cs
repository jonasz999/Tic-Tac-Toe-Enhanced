using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour
{
	public GameObject object1;
	public GameObject object2;

	private LineRenderer line;

	void Start()
	{
		// Add a Line Renderer to the GameObject
		line = this.gameObject.AddComponent<LineRenderer>();
		// Set the width of the Line Renderer
		line.startWidth = 0.05f;
		line.endWidth = 0.05f;
		// Set the number of vertex fo the Line Renderer
		line.positionCount = 2;
	}

	void Update()
	{
		// Check if the GameObjects are not null
		if (object1 != null && object2 != null)
		{
			// Update position of the two vertex of the Line Renderer
			line.SetPosition(0, object1.transform.position);
			line.SetPosition(1, object2.transform.position);
		}
	}
}