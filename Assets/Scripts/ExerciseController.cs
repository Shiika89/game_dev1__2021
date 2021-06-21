using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseController : MonoBehaviour
{
    GameObject m_object;
    GameObject m_object2;
    GameObject[] m_tag;

    void Start()
    {
        m_object = GameObject.Find("RedLeftWall"); // 指定した名前のオブジェクト (GameObject) 検索して取得する
        m_object2 = GameObject.Find("BlueLeftWall");
        m_tag = GameObject.FindGameObjectsWithTag("ActionWallTag");
    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Rigidbody2D rb = m_object.GetComponent<Rigidbody2D>();  // 取得したオブジェクトから Rigidbody2D コンポーネントを取り出す
        //rb.AddForce(3 * Vector2.left, ForceMode2D.Impulse);     // 左に大きさ3の力を加える

        SpriteRenderer sr = m_object2.GetComponent<SpriteRenderer>();
        sr.color = Color.white;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Rigidbody2D rb = m_object.GetComponent<Rigidbody2D>();  // 取得したオブジェクトから Rigidbody2D コンポーネントを取り出す
        //rb.AddForce(3 * Vector2.right, ForceMode2D.Impulse);     // 左に大きさ3の力を加える

        //Rigidbody2D rb2 = m_object2.GetComponent<Rigidbody2D>();
        //rb2.AddForce(3 * Vector2.left, ForceMode2D.Impulse);

        foreach (var item in m_tag)
        {
            SpriteRenderer sr = item.GetComponent<SpriteRenderer>();
            sr.color = Color.white;
        }
    }


}
