using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMover : Config
{
    // �u���b�N�̗���鑬�x���w��(�������ŕ����͔��]���邽�߁A�������𐳂Ƃ���)
    public float BlockSpeedX = 0.1f;

    void Start()
    {
    }
    void FixedUpdate()
    {
        this.gameObject.transform.Translate(-BlockSpeedX, 0, 0);

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