using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class UnetMa : NetworkManager {

    // Use this for initialization
    void Start () {
		
	}
    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        var player = Instantiate(playerPrefab);
        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
    }
    // Update is called once per frame
    void Update () {

		
	}
}
