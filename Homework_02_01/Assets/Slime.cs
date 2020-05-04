using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{
    public int HP;
    public int ATK;
    public int Heal;
    public Text TextResult;
    public Bat Bat1;

    public void Start()
    {
        HP = 100;
        ATK = 10;
        Heal = 30;
    }

    public void Attack()
    {
        Bat1.Hurt(ATK);
    }

    public void Hurt(int EnemyATK)
    {
        HP -= EnemyATK;
        TextResult.text = gameObject.name + " - 受到傷害： " + EnemyATK + "\n" + gameObject.name + " - 血量剩下：" + HP;
    }

    public void Healing()
    {
        HP += Heal;
        TextResult.text = gameObject.name + " - 受到治癒： " + Heal + "\n" + gameObject.name + " - 血量剩下：" + HP;
    }
}
