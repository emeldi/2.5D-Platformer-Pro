using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            ++player.coins;
            Destroy(this.gameObject, 0.125f);
            UIManager.Instance.UpdateCoins = player.coins;
        }
    }
}