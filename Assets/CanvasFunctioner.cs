using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasFunctioner : MonoBehaviour
{
    public GameObject lightMcLightFace, mainCam, fpsCam;

    public void ContinueWithCharacter()
    {
        //this.gameObject.SetActive(false);
        //lightMcLightFace.SetActive(false);
        //mainCam.SetActive(false);
        //fpsCam.SetActive(true);

        //go to next scene
        SceneManager.LoadScene(1);
    }

    public void Update()
    {
        if (this.gameObject.activeSelf)
        {
            lightMcLightFace.SetActive(true);
        }
        else
        {
            lightMcLightFace.SetActive(false);
        }
    }
}
