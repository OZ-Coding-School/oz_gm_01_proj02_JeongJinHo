using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 50.0f;

    //캐릭터,포탑,총알 다 마우스보면 추상으로 하는게 좋겠다
    //캐릭터가 마우스방향으로 몸을 트는 애니메이션구하기?

    private void Update()
    {
        Move();
        LookMouse();
    }

    private void Move()
    {
        float moveX=Input.GetAxis("Horizontal");
        Vector3 moveDir = new Vector3(moveX, 0, 0);
        transform.position+=moveDir*moveSpeed*Time.deltaTime;
    }
    private void LookMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float distance;

        if(plane.Raycast(ray, out distance))
        {
            Vector3 target = ray.GetPoint(distance);
            Vector3 lookDir = target - transform.position;
            lookDir.y = 0;
            if (lookDir != Vector3.zero)
            {
                transform.rotation=Quaternion.LookRotation(lookDir);
            }
            
        }
    }
    

}
