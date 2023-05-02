using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doorpopup : MonoBehaviour
{
    public Transform DoorText;
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            print("´ê¾Ò´Ù");
            DoorText.gameObject.SetActive(true);
            if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
            {
                print("½ºÅÚ¶ó¾ÀÀ¸·Î ÀÌµ¿");
                SceneManager.LoadScene("SpaceScene");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            print("´ê¾Ò´Ù");
            DoorText.gameObject.SetActive(false);
        }
    }
}
