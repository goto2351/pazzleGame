using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]



public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private float jumpForce;

    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �X�y�[�X�L�[�ŃW�����v
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
        }

        // �W�����v��Ԃ��擾���AAnimator�Ɠ�������
        if (gameObject.transform.position.y > 0)
        {
            isJumping = true;
        } else
        {
            isJumping = false;
        }
        animator.SetBool("isJumping", isJumping);
    }

}
