using HoloToolkit.Unity.Buttons;
using UnityEngine;

public class ButtonClickHandler : MonoBehaviour {

	public UnityEngine.UI.Text text;

	private void OnEnable()
	{
		GetComponent<Button>().OnButtonClicked += ButtonClickHandler_OnButtonClicked;
	}

	private void OnDisable()
	{
		GetComponent<Button>().OnButtonClicked -= ButtonClickHandler_OnButtonClicked;
	}

	private void ButtonClickHandler_OnButtonClicked(GameObject obj)
	{
		Debug.LogFormat(this, "Clicked obj={0} current={1} t={2}", obj, Event.current, Time.realtimeSinceStartup);
		text.text += string.Format("\n\n\nClicked obj={0} current={1} t={2}\n{3}", obj, Event.current, Time.realtimeSinceStartup, System.Environment.StackTrace);
	}
}
