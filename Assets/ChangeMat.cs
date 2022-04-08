using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMat : MonoBehaviour
{
    [SerializeField] private MeshRenderer _mr;
    [SerializeField] Material _matToRemplace;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Y))
        {
            _mr.material = _matToRemplace;
        }
    }
}
