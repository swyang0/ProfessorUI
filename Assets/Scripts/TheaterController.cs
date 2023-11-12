using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TheaterController : MonoBehaviour
{
    public GameObject theaterOptionUI;
    public GameObject firstLevelUI;
    public GameObject startTheaterBtn;
    public GameObject stopTheaterBtn;

    private int selected = -1;

    public void enableObject(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void disableObject(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void enterTheaterMode()
    {
        // disable theater button
        disableObject(firstLevelUI);

        // enable theater option ui
        enableObject(theaterOptionUI);
    }

    public void selectTheaterMode()
    {
        // if any skybox material is selected,
        // triggers the code for 360 theater
        if (selected != -1)
        {
            // TODO: replace the print statement with 360 theater code
            print(selected);

            // replace startTheaterBtn with StopTheaterBtn
            disableObject(startTheaterBtn);
            enableObject(stopTheaterBtn);

            // change the button text
            TextMeshProUGUI stopTheaterBtnText = stopTheaterBtn.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>();
            stopTheaterBtnText.text = "Stop Theater Mode: " + selected.ToString(); 

        }

        // disable theater option ui
        disableObject(theaterOptionUI);

        // enable first level UI
        enableObject(firstLevelUI);

        // reset selected index
        selected = -1;

    }

    public void stopTheaterMode()
    {
        selected = -1;

        // replace the stopTheaterBtn with startTheaterBtn
        disableObject(stopTheaterBtn);
        enableObject(startTheaterBtn);

        // TODO: add code here to go from theater mode to regular mode
        print("exiting theater mode: " + selected.ToString());
    }

    // listener for the first skybox material button
    public void selectFirst()
    {
        selected = 1;
        selectTheaterMode();
    }
    // listener for the second skybox material button
    public void selectSecond()
    {
        selected = 2;
        selectTheaterMode();
    }
    // listener for the third skybox material button
    public void selectThird()
    {
        selected = 3;
        selectTheaterMode();
    }
    // listener for the go back button
    public void goBack()
    {
        selectTheaterMode();
    }



}
