using UnityEngine;
using System.Collections;

public class T2M : MonoBehaviour
{

    private bool uDown = false;
    private bool jDown = false;
    private bool hDown = false;
    private bool kDown = false;
    private bool yDown = false;
    private bool iDown = false;
    private sbyte rotationSpeed = 0;
    private sbyte movementSpeed = 0;
    private sbyte turretSpeed = 0;
    public byte maxSpeed;

    void Start()
    {

    }

    void Update()
    {
        {
            GetKeyInput();
            if (uDown == true)
            {
                if ((hDown == true) || (kDown == true))
                {
                    if (movementSpeed < maxSpeed - 30)
                    {
                        movementSpeed += 1;
                    }
                }
                else
                {
                    if (movementSpeed < maxSpeed - 20)
                    {
                        movementSpeed += 1;
                    }
                }
            }
            if (jDown == true)
            {
                if ((hDown == true) || (kDown == true))
                {
                    if (movementSpeed > -maxSpeed + 30)
                    {
                        movementSpeed += -1;
                    }
                }
                else
                {
                    if (movementSpeed > -maxSpeed + 20)
                    {
                        movementSpeed += -1;
                    }
                }
            }
            if (hDown == true)
            {
                if (uDown == true)
                {
                    if (rotationSpeed > -maxSpeed)
                    {
                        rotationSpeed += -5;
                    }
                }
                else
                {
                    if (jDown == true)
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
            if (kDown == true)
            {
                if (uDown == true)
                {
                    if (rotationSpeed < maxSpeed)
                    {
                        rotationSpeed += 5;
                    }
                }
                else
                {
                    if (jDown == true)
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
            if (yDown == true)
            {
                if (turretSpeed > -maxSpeed)
                {
                    turretSpeed += -5;
                }
            }
            if (iDown == true)
            {
                if (turretSpeed < maxSpeed)
                {
                    turretSpeed += 5;
                }
            }
            if ((jDown == false) & (uDown == false))
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
            if ((hDown == false) & (kDown == false))
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
            if ((yDown == false) & (iDown == false))
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
            Transform.FindObjectOfType<T2T>().T2.transform.Rotate(Vector3.up * turretSpeed * Time.deltaTime);
        }
    }

    void GetKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            uDown = true;
            jDown = false;
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            uDown = false;
            if (Input.GetKey(KeyCode.J))
            {
                jDown = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            jDown = true;
            uDown = false;
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            jDown = false;
            if (Input.GetKey(KeyCode.U))
            {
                uDown = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            hDown = true;
            kDown = false;
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            hDown = false;
            if (Input.GetKey(KeyCode.K))
            {
                kDown = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            kDown = true;
            hDown = false;
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            kDown = false;
            if (Input.GetKey(KeyCode.H))
            {
                hDown = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            iDown = true;
            yDown = false;
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            iDown = false;
            if (Input.GetKey(KeyCode.Y))
            {
                yDown = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            yDown = true;
            iDown = false;
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            yDown = false;
            if (Input.GetKey(KeyCode.I))
            {
                iDown = true;
            }
        }
    }

}
