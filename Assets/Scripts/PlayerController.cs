using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public enum TargetEnum
{
    TopLeft,
    TopRight,
    Bottomleft,
    BottomRight,
}

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public Transform topLeftTransform;
    public Transform topRightTransform;
    public Transform bottomLeftTransform;
    public Transform bottomRightTransform;

    private TargetEnum nextTarget = TargetEnum.TopLeft; // gan trang thai
    private Transform currentTarget;


    // Start is called before the first frame update
    void Start()
    {
        currentTarget = topLeftTransform;
    }

    // Update is called once per frame
    void Update()
    {
        // Hàm Update được gọi mỗi frame
        Vector3 targetPosition = currentTarget.position;
        Vector3 moveDirection = targetPosition - transform.position;
        float distance = moveDirection.magnitude;//tính khỏang cách giữa hai điểm
        if(distance > 0.1f)
        {
            //khi chua den diem tieo theo van tieo tuc di chuyen
            transform.position = Vector3.MoveTowards(transform.position,currentTarget.position,
                                                       Speed* Time.deltaTime);
        }
        else
        {
            //CHuyển trạng thái target
            setNextTarget(nextTarget);
        }
        //Thay đổi góc quy theo hướng target
        Vector3 direction = currentTarget.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction,Vector3.up);
        transform.rotation = targetRotation;
    }
    void setNextTarget(TargetEnum target)
    {
        switch (target)
        {
            case TargetEnum.TopLeft:
                currentTarget = topLeftTransform;
                nextTarget = TargetEnum.TopRight;
                break;
            case TargetEnum.TopRight:
                currentTarget = topRightTransform;
                nextTarget = TargetEnum.Bottomleft;
                break;
            case TargetEnum.Bottomleft:
                currentTarget = bottomLeftTransform;
                nextTarget = TargetEnum.BottomRight;
                break;
            case TargetEnum.BottomRight:
                currentTarget = bottomRightTransform;
                nextTarget = TargetEnum.TopLeft;
                break;
        }
    }
   
}
