using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMove : MonoBehaviour
{
    Transform player; // ��l����Transform�R���|�[�l���g
    TextController t;
    public GameObject Exp;
    public float moveSpeed = 5f; // �G�̈ړ����x
    [SerializeField]
    float HP;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        t = GameObject.FindGameObjectWithTag("EnemyManager").GetComponent<TextController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            // ��l���̈ʒu�ƓG�̈ʒu�̍����x�N�g�����v�Z
            Vector3 direction = player.position - transform.position;
            direction.Normalize(); // �����x�N�g���𐳋K��

            // �����x�N�g�����g���ēG���ړ�������
            transform.position += direction * moveSpeed * Time.deltaTime;
        }

        if(HP <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Whip" || other.gameObject.tag == "Whip_L")
        {
            HP -= 30;
        }

        if(other.gameObject.tag == "Axe" || other.gameObject.tag == "Book")
        {
            HP -= 40;
        }
    }

    private void OnDestroy()
    {
        Instantiate(Exp, this.transform.position, Quaternion.identity);
        t.EnemyCount++;
    }
}
