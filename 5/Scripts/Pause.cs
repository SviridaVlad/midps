using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
    public GameObject CarMenu;

    // Use this for initialization
    void Start()
    {

    }

    public void GoPause()
    {
        CarMenu.SetActive(true);
    }

    public void BackToGame()
    {
        if (CarMenu.activeSelf)
        {
            CarMenu.SetActive(false);
        }
    }

    public void BackGarage()
    {
        Application.LoadLevel("Garage");
    }

    // Update is called once per frame
    void Update()
    {

    }


}
