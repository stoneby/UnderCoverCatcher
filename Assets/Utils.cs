using System;
using UnityEngine;

public class Utils
{
	public static void NetWorkDebug()
	{
		Debug.Log("Network peer type: " + Network.peerType + ", connections: " + Network.connections.Length
		+ "\ntester ip: " + Network.connectionTesterIP + ", tester port: " + Network.connectionTesterPort
		+ "\nis server: " + Network.isServer + ", is client: " + Network.isClient
		+ "\n max connections: " + Network.maxConnections + ", min allocated view ids: " + Network.minimumAllocatableViewIDs
		+ "\n facilitator ip: " + Network.natFacilitatorIP + ", facilitator port: " + Network.natFacilitatorPort
		+ "\nplayer: " + Network.player + ", proxy ip: " + Network.proxyIP + ", proxy passward: " + Network.proxyPassword
		+ "\nsend rate: " + Network.sendRate + ", time: " + Network.time + ", use proxy: " + Network.useProxy);
	}
}

