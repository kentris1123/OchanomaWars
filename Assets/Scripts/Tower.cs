using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

    public int hp = 100;

    /* 敵がぶつかってきたとき */
    void OnTriggerEnter (Collider teki) {
        /* EnemyController コンポーネントを取り出す */
        EnemyController enemyController =
            teki.gameObject.GetComponent<EnemyController>();

        /* 塔にダメージを適用する */
        hp -= enemyController.power;

        /* 敵を消す */
        GameObject.Destroy(enemyController.gameObject);
    }

    void OnGUI () {
        GUI.Box(new Rect(10, 10, 100, 20), "HP: " + hp.ToString());
    }
}