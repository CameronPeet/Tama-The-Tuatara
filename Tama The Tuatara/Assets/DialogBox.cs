using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogBox : MonoBehaviour {

    //Title and Description TextUI
    private Text ItemTitle;
    private Text ItemDescription;

    //Next Slide Button / Exit Button
    private Text NextButton;
    bool NextIsExit;

    //Current Dialog Text
    private DialogDescription CurrentDialog;
    private int SlideNumber;

	// Use this for initialization
	void Start () {
        ItemTitle = transform.FindChild("ItemTitle").GetComponent<Text>();
        ItemDescription = transform.FindChild("ItemDescription").GetComponent<Text>();
        NextButton = transform.FindChild("NextButton").GetComponent<Button>().GetComponentInChildren<Text>();
        SlideNumber = 0;
        gameObject.SetActive(false);
	}
	
    public void SetDialog(DialogDescription dialog)
    {
        gameObject.SetActive(true);
        SlideNumber = 0;
        CurrentDialog = dialog;
        ItemTitle.text = dialog.Title;
        ItemDescription.text = dialog.Description[SlideNumber];

        if(dialog.NumberOfSlides == 1)
        {
            NextIsExit = true;
            NextButton.text = "Exit";
        }
        else
        {
            NextIsExit = false;
            NextButton.text = "Next";
        }
    }

    public void NextSlide()
    {
        SlideNumber++;

        if(SlideNumber < CurrentDialog.NumberOfSlides)
        {
            ItemDescription.text = CurrentDialog.Description[SlideNumber];
            NextButton.text = "Next";
        }
        else
        {
            gameObject.SetActive(false);
        }
        if(SlideNumber + 1 == CurrentDialog.NumberOfSlides)
        {
            NextButton.text = "Exit";
        }
        
    }
}
