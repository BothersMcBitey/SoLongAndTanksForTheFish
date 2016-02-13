using UnityEngine;
using System.Collections;

public class T1M : MonoBehaviour {

    private bool wDown = false;
    private bool sDown = false;
    private bool aDown = false;
    private bool dDown = false;
    private bool qDown = false;
    private bool eDown = false;
    private sbyte rotationSpeed = 0;
    private sbyte movementSpeed = 0;
    private sbyte turretSpeed = 0;
    public byte maxSpeed;

    void Start ()
    {
        
	}

    void Update ()
    {
        {
            GetKeyInput ();
            if (wDown == true)
            {
                if ((aDown == true) || (dDown == true))
                {
                    if (movementSpeed < maxSpeed-30)
                    {
                        movementSpeed += 1;
                    }
                }
                else
                {
                    if (movementSpeed < maxSpeed-20)
                    {
                        movementSpeed += 1;
                    }
                }            
            }
            if (sDown == true)
            {
                if ((aDown == true) || (dDown == true))
                {
                    if (movementSpeed > -maxSpeed+30)
                    {
                        movementSpeed += -1;
                    }
                }
                else
                {
                    if (movementSpeed > -maxSpeed+20)
                    {
                        movementSpeed += -1;
                    }
                }
            }
            if (aDown == true)
            {
             if (wDown == true)
                {
                    if (rotationSpeed > -maxSpeed)
                    {
                        rotationSpeed += -5;
                    }
                }
                else
                {
                    if (sDown == true)
                    {
                        if (rotationSpeed < maxSpeed)
                        {
                            rotationSpeed += 5;
                        }
                    }
                    else
                    {
                        if (rotationSpeed > -maxSpeed)
                        {
                            rotationSpeed += -5;
                        }
                    }
                }            
            }
            if (dDown == true)
            {
                if (wDown == true)
                {
                    if (rotationSpeed < maxSpeed)
                    {
                        rotationSpeed += 5;
                    }
                }
                else
                {
                    if (sDown == true)
                    {
                        if (rotationSpeed > -maxSpeed)
                        {
                            rotationSpeed += -5;
                        }
                    }
                    else
                    {
                        if (rotationSpeed < maxSpeed)
                        {
                            rotationSpeed += 5;
                        }
                    }
                }
            }
            if (qDown == true)
            {
                if (turretSpeed > -maxSpeed)
                {
                    turretSpeed += -5;
                }
            }
            if (eDown == true)
            {
                if (turretSpeed < maxSpeed)
                {
                    turretSpeed += 5;
                }
            }
            if ((sDown == false) & (wDown == false))
            {
                if (movementSpeed > 0)
                {
                    movementSpeed += -1;
                }
                else
                {
                    if (movementSpeed < 0)
                    {
                        movementSpeed += 1;
                    }
                }
            }
            if ((aDown == false) & (dDown == false))
            {
                if (rotationSpeed > 0)
                {
                    rotationSpeed += -5;
                }
                else
                {
                    if (rotationSpeed < 0)
                    {
                        rotationSpeed += 5;
                    }
                }
            }
            if ((qDown == false) & (eDown == false))
            {
                if (turretSpeed > 0)
                {
                turretSpeed += -5;
                }
                else
                {
                    if (turretSpeed < 0)
                    {
                        turretSpeed += 5;
                    }
                }
            }
            
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            Transform.FindObjectOfType<T1T>().T1.transform.Rotate(Vector3.up * turretSpeed * Time.deltaTime);
        }
    }

    void GetKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            wDown = true;
            sDown = false;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            wDown = false;
            if (Input.GetKey(KeyCode.S))
            {
                sDown = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            sDown = true;
            wDown = false;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            sDown = false;
            if (Input.GetKey(KeyCode.W))
            {
                wDown = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            aDown = true;
            dDown = false;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            aDown = false;
            if (Input.GetKey(KeyCode.D))
            {
                dDown = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            dDown = true;
            aDown = false;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            dDown = false;
            if (Input.GetKey(KeyCode.A))
            {
                aDown = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            eDown = true;
            qDown = false;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            eDown = false;
            if (Input.GetKey(KeyCode.Q))
            {
                qDown = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            qDown = true;
            eDown = false;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            qDown = false;
            if (Input.GetKey(KeyCode.E))
            {
                eDown = true;
            }
        }
    }

}
