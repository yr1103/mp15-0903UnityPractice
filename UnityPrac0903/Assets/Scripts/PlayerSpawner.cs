using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject Player;
    public List<GameObject> _players = new();


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            //생성
            GameObject p = Instantiate(Player);
            _players.Add(p);
        }

        //파괴

        if(Input.GetKeyDown(KeyCode.D))
        
        {
            // 리스트에서 잘 빠지고 있는지 확인해야한다
            // 이 두 줄이 중요하다.
            GameObject p = _players[_players.Count -1];
            _players.RemoveAt(_players.Count-1);
            Destroy(p);
            
        }
    }

}
