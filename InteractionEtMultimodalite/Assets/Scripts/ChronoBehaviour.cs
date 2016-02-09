using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChronoBehaviour : MonoBehaviour
{
    private bool chronoIsOn = false;
    private float chronoStart;

    [SerializeField]
    private Text chronoText;
    [SerializeField]
    private Text startText;
    [SerializeField]
    private ResetPosition[] cylinders;

	void Update()
    {
	    if(chronoIsOn)
        {
            int timeSinceStart = (int)(Time.time - chronoStart);
            int chronoSeconds = timeSinceStart % 60;
            int chronoMinutes = timeSinceStart / 60;
            chronoText.text = string.Format("{0:00}:{1:00}", chronoMinutes, chronoSeconds);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            OnClick_Start();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            OnClick_Reset();
        }
	}

    public void OnClick_Start()
    {
        chronoIsOn = !chronoIsOn;
        if (chronoIsOn)
        {
            startText.text = "Stop";
            chronoStart = Time.time;
            for (int i = 0; i < cylinders.Length; i++)
            {
                cylinders[i].reset();
            }
        }
        else
        {
            startText.text = "Start";
        }
    }

    public void OnClick_Reset()
    {
        chronoIsOn = false;
        chronoText.text = "00:00";
        startText.text = "Start";
        for (int i = 0; i < cylinders.Length; i++)
        {
            cylinders[i].reset();
        }
    }
}
