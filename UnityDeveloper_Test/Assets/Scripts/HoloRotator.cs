using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HoloRotator : MonoBehaviour
{

    public float rotationSpeed = 70f;
    private bool isVisible=false;
    [SerializeField] GameObject Holo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

       

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                //ToggleVisibility();
                ResetRotation();
                RotateObjectByDirection(Vector3.right);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
           
                //ToggleVisibility();
                ResetRotation();
                RotateObjectByDirection(Vector3.left);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
            
                //ToggleVisibility();
                ResetRotation();
                RotateObjectByDirection(Vector3.forward);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
               //ToggleVisibility();
               ResetRotation();
               RotateObjectByDirection(-Vector3.forward);
            }
        }

        void RotateObjectByDirection(Vector3 direction)
        {
        transform.Rotate(direction * rotationSpeed);
        }

    void ResetRotation()
    {
         transform.rotation = Quaternion.identity;
    }


    void ToggleVisibility()
    {
        isVisible = !isVisible;
        SetVisibility(isVisible);
    }

    void SetVisibility(bool visible)
    {
        Holo.SetActive(visible);
    }
}

