using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ConnectAndrino : MonoBehaviour
{
    public Material DefaultMaterial;
    public Material RedMaterial;

    public string portName;
    SerialPort arduino;

    // Start is called before the first frame update
    void Start()
    {
        arduino = new SerialPort("COM5", 9600);
        arduino.Open();
    }

    // Update is called once per frame
    void Update()
    {
        if (arduino.IsOpen && arduino.BytesToRead > 0)
        {
            var msg = arduino.ReadLine();
            if (msg == "1")
            {
                print(1);
                gameObject.GetComponent<Renderer>().material = RedMaterial;
            }
            else
            {
                print(0);
                gameObject.GetComponent<Renderer>().material = DefaultMaterial;
            }
        }
    }
}
