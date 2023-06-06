using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMove : MonoBehaviour
{
    Transform player; // 主人公のTransformコンポーネント
    TextController t;
    public GameObject Exp;
    public float moveSpeed = 5f; // 敵の移動速度
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
            // 主人公の位置と敵の位置の差分ベクトルを計算
            Vector3 direction = player.position - transform.position;
            direction.Normalize(); // 方向ベクトルを正規化

            // 方向ベクトルを使って敵を移動させる
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
