
    using UnityEngine;
    using System.Collections;

    /***************************************************************************
    *   This is a demonstration class for the camera rig controller.
    *
    *   @author  Christopher Stock
    *   @version 0.1
    ***************************************************************************/
    public class cameraRig1 : MonoBehaviour
    {
        private             float       SPEED               = 0.1f;

        private             float       positionY           = 0.0f;

        private             float       pMouseX             = 0.0f;
        private             float       pMouseY             = 0.0f;
    
        /***************************************************************************
        *   Being used for initialization.
        ***************************************************************************/
        public void Start ()
        {
            Debug.Log( "Start() being invoked!" );    
	    }

        /***************************************************************************
        *   Being invoked once per frame.
        ***************************************************************************/
        public void Update ()
        {
            Debug.Log("Update() being invoked!");

            this.AlterPositionY();

            float mouseDeltaX = Input.mousePosition.x - pMouseX;
            float mouseDeltaY = Input.mousePosition.y - pMouseY;

            if ( Input.GetMouseButton(0) )
            {
                transform.Rotate(0, mouseDeltaX * SPEED, 0);
                transform.GetChild(0).Rotate(mouseDeltaY * SPEED, 0, 0);
            }

            Vector3 rot = transform.GetChild( 0 ).localEulerAngles;
            rot.x = Mathf.Clamp( rot.x, 5.0f, 80.0f );
            transform.GetChild( 0 ).localEulerAngles = rot;

            this.pMouseX = Input.mousePosition.x;
            this.pMouseY = Input.mousePosition.y;
        }

        /***************************************************************************
        *   Applies the sinus transition to the camera.
        ***************************************************************************/
        private void AlterPositionY()
        {
            this.positionY += 0.1f;
            transform.position = new Vector3(0, Mathf.Sin(this.positionY), 0);
        }



    }
