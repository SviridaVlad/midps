using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour
{
    public GameObject car;
    public float rpm;
    public RectTransform rpm_pointer;
    public GameObject rpm_led;
    public Text GearText;
    public Text speedText;


    // Use this for initialization
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.05f);
        car = GameObject.FindGameObjectWithTag("Player"); //.GetComponent<Car> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (car != null)
        {
            rpm = Mathf.Lerp(rpm, car.GetComponent<AudioSource>().pitch, 0.2f);
            rpm_pointer.localEulerAngles = new Vector3(0, 0, 126 - rpm * 252f);
            //rpm_led.SetActive(car.GetComponent<AudioSource>().pitch >= 0.98f);
        }



        /*/if (Mathf.RoundToInt(car.GetComponent<Car>().Speed) < 10)
        {
            speedText.text = "00" + car.Speed.ToString("F0");
        }
        else
        {
            if (Mathf.RoundToInt(car.Speed) < 100)
            {
                speedText.text = "0" + car.Speed.ToString("F0");
            }
            else
            {
                if (Mathf.RoundToInt(car.Speed) < 999)
                {
                    speedText.text = car.Speed.ToString("F0");
                }
            }
        }


        if (car.GetComponent("R"))
        {
            GearText.text = "R";
        }
        else
        {
            if (!car.GetComponent("Clutch"))
            {
                gearText.text = (car.G + 1).ToString("F0");
            }
            else
            {
                gearText.text = "N";
            }
        }/*/
    }
}
