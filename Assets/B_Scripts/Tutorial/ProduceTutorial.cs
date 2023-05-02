using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ProduceTutorial : MonoBehaviour
{
    [SerializeField] private Transform StartPos;
    [SerializeField] private Transform EndPos;
    [SerializeField] private GameObject particle;
    [SerializeField] private GameObject tutorialCamera;
    [SerializeField] private Transform cameraPos;

    private Vector3 moveDirection; // 물체의 이동 방향을 저장할 변수

    // Start is called before the first frame update
    void Start()
    {

        tutorialCamera.transform.position = cameraPos.position;
        tutorialCamera.transform.rotation = Quaternion.LookRotation((StartPos.position - tutorialCamera.transform.position).normalized);

        this.transform.position = StartPos.position;

        // 물체의 이동 방향을 계산합니다.
        this.transform.rotation = Quaternion.LookRotation(EndPos.position - this.transform.position);
    }

    bool flag = false;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            Destroy(this.gameObject);
            return;
        }
        float distance = Vector3.Distance(EndPos.position, this.transform.position);

        if (distance < 5f)
        {
            GameObject copy = Instantiate(particle, this.transform.position, this.transform.rotation);

            Destroy(copy, 1f);
            flag = true;
            return;
        }
        float t = speed * Time.deltaTime;
        t = t > 0.1f ? t : 0.3f * Time.deltaTime;
        Vector3 newPosition = Vector3.Slerp(this.transform.position, EndPos.position, t);
        this.transform.position = newPosition;
    }
}
