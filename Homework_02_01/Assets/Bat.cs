using UnityEngine;
using UnityEngine.UI;

public class Bat : MonoBehaviour
{
    public int HP;
    public int ATK;
    public int Heal;
    public Text TextResult;
    public Slime Slime1;

    public void Start()
    {
        HP = 200;
        ATK = 20;
        Heal = 10;
    }
    
    public void Attack()
    {
        Slime1.Hurt(ATK);
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
