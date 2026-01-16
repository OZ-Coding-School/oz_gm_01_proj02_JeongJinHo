using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 50.0f;
    [SerializeField] private float rotateAngle = 45.0f;//고개돌릴때
    [SerializeField] private float rotateSpeed = 2.0f;

    private Quaternion targetRotation;

    //캐릭터,포탑,총알 다 마우스보면 추상으로 하는게 좋겠다
    //캐릭터가 마우스방향으로 몸을 트는 애니메이션구하기?
    private void Start()
    {
        targetRotation = transform.rotation;
    }
    private void Update()
    {
        //Move();
        LookMouse();
    }

    private void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector3 moveDir = new Vector3(moveX, 0, 0);
        transform.position += moveDir * moveSpeed * Time.deltaTime;
    }
    private void LookMouse()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePos.z = Vector3.Distance(Camera.main.transform.position, transform.position);
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 lookDir = worldMousePos - transform.position;
        lookDir.y = 0;

        if (lookDir != Vector3.zero)
        {

            Quaternion quaternion = Quaternion.LookRotation(lookDir);

            float angle = Quaternion.Angle(targetRotation, quaternion);

            if (angle > rotateAngle)
            {
                quaternion = Quaternion.RotateTowards(targetRotation, quaternion, rotateAngle);
            }

            transform.rotation = Quaternion.Slerp(transform.rotation, quaternion, rotateSpeed);
            //transform.rotation = Quaternion.LookRotation(lookDir);
        }
    }
}
