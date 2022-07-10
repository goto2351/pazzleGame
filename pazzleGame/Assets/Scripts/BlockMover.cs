using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMover : MonoBehaviour
{
    // �u���b�N�̍폜�����ʒu���w��
    public const float DestroyPositionX = -10.0f;
    // �u���b�N�̗���鑬�x���w��(�������ŕ����͔��]���邽�߁A�������𐳂Ƃ���)
    public float BlockSpeedX = 1.0f;

    private Rigidbody2D rb;
    private Vector3 speed;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();  // rigidbody���擾
        speed = new Vector3(-BlockSpeedX, 0.0f, 0.0f);    // ���x��ݒ�
    }
    void FixedUpdate()
    {
        //TODO ���x�m�F�p
        //Debug.Log( this.gameObject.name + rb.velocity.x);
        rb.velocity = speed;    // ���x��^����

        //��ʊO�ɏo�����̏���������
        if (this.gameObject.transform.position.x < DestroyPositionX)
        {
            FlameOut(this.gameObject);
        }

    }

    //�I�u�W�F�N�g����ʊO�ɏo�����̏������K��
    void FlameOut(GameObject gameObject)
    {
        Destroy(gameObject);
    }

}