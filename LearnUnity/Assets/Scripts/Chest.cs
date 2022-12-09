using UnityEngine;

public class Chest : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        //base.OnCollide(coll);
        Debug.Log("Grant Pesos");
    }
}
