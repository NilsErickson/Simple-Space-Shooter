using UnityEngine;
using System.Collections;

public class BeginningGameMenuScript : MonoBehaviour {

		void OnGUI()
	{
		const int buttonWidth = 120;
		const int buttonHeight = 60;
		
		if (
			GUI.Button(
			// Center in X, 1/3 of the height in Y
			new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(1 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Begin!"
			)
			)
		{
			// Reload the level
			Application.LoadLevel("Level1");
		}
	}
}
