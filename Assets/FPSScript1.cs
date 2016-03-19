
    using UnityEngine;
    using System.Collections;

    /***************************************************************************
    *   This is a demonstration class for the First Person camera controller.
    *
    *   @author  Christopher Stock
    *   @version 0.1
    ***************************************************************************/
    public class FPSScript1 : MonoBehaviour
    {
        public GameObject munition;
    
        /***************************************************************************
        *   This is a demonstration class for the First Person camera controller.
        *
        *   @author  Christopher Stock
        *   @version 0.1
        ***************************************************************************/
        void Update()
        {
            if ( Input.GetMouseButtonDown( 0 ) )
            {
                GameObject newObject = Instantiate(munition);

                newObject.transform.position = transform.position + transform.rotation * Vector3.forward * 2f;
                newObject.GetComponent<Rigidbody>().AddForce( transform.rotation * new Vector3( 0.0f, 0.0f, 1000.0f ) );



        }
	    }
    }
