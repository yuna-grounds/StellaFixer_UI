using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HellmetControl : MonoBehaviour
{
    public Transform StellaText;
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            print("��Ҵ�");
            StellaText.gameObject.SetActive(true);
            if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch))
            {
                print("���ڶ������ �̵�");
                SceneManager.LoadScene("SpaceScene");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            print("��Ҵ�");
            StellaText.gameObject.SetActive(false);
        }
    }
}
