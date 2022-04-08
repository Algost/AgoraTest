using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private ThirdPersonMouvement _thirdPOV;
    [SerializeField] private FirstPersonMouvement _firstPOV;
    [SerializeField] private GameObject _thirdCam;
    [SerializeField] private GameObject _firstCam;


    private bool _firstPov = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            if (_firstPov == false) //Je go en 1st pov
            {
                _firstPov = true;

                _thirdPOV.enabled = false;
                _thirdCam.SetActive(false);

                _firstCam.SetActive(true);
                _firstPOV.enabled = true;
                
            }
            else // je go en 3rd pov
            {
                _firstPov = false;

                _firstPOV.enabled = false;
                _firstCam.SetActive(false);

                _thirdPOV.enabled = true;
                _thirdCam.SetActive(true);

                
            }
        }
    }
}
