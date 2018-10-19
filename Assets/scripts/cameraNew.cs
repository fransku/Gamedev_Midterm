using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraNew : MonoBehaviour {
    //11 october 2018: better mouse look 
    //clamping vertical look to prevent inverted controls/upside down controls 

   public float cameraSpeed;

    //degrees for looking up and down
    float verticalLook = 0f;

	void Update () {
        //be 0 when mouse isnt moving, this is not moues position
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * cameraSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * cameraSpeed;
        transform.Rotate(0f, mouseX, 0f);

        //better mouse look: 
        //add mouse input to vertical look, then clamp verticallook 
        verticalLook += -mouseY;
        verticalLook = Mathf.Clamp(verticalLook, -50f, 50f);
        //actually apply veritcalook to camera rotation
        Camera.main.transform.localEulerAngles = new Vector3(verticalLook, 0f, 0f);

        if(Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false; 
        }

    }
}
