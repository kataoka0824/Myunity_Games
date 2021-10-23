using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

// MonoBehaviourではなくMonoBehaviourPunCallbacksを継承して、Photonのコールバックを受け取れるようにする
public class Make_room : MonoBehaviourPunCallbacks
{
    public bool master = false;
    public Vector3 v1;
    public Vector3 v2;
    public Vector3 v_b;
    public int player_re;
    public int block_re;
    public GameObject make_item;
    //public GameObject camera1;
    private void Start()
    {
        // PhotonServerSettingsに設定した内容を使ってマスターサーバーへ接続する
        PhotonNetwork.ConnectUsingSettings();
    }

    // マスターサーバーへの接続が成功した時に呼ばれるコールバック
    public override void OnConnectedToMaster()
    {
        // "room"という名前のルームに参加する（ルームが無ければ作成してから参加する）
        PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions() {
            MaxPlayers = 2
        }, TypedLobby.Default);
    }
    // 部屋を作成した時
    public override void OnCreatedRoom()
    {
        master = true;
        Debug.Log("OnCreatedRoom");
    }
    // マッチングが成功した時に呼ばれるコールバック
    public override void OnJoinedRoom()
    {
        
        if (master)
        {
            // マッチング後、ランダムな位置に自分自身のネットワークオブジェクトを生成する
            v1 = new Vector3(Random.Range(0f,1000f),50f,Random.Range(0f,1000f));
            GameObject player1=PhotonNetwork.Instantiate("GamePlayer1", v1, Quaternion.identity);
            PhotonNetwork.LocalPlayer.NickName = "Player1";
            
            /*GameObject camera1 = Camera.main.gameObject;
            camera1.transform.parent = player1.transform;
            camera1.transform.position = player1.transform.position + Vector3.up * 10 + Vector3.forward * 10;*/
        }
        else
        {
            v2 = new Vector3(Random.Range(0f, 1000f), 50f, Random.Range(0f, 1000f));
            GameObject player2 = PhotonNetwork.Instantiate("GamePlayer2", v2, Quaternion.identity);
            PhotonNetwork.LocalPlayer.NickName = "Player2";
            /*GameObject camera2 = Camera.main.gameObject;
            camera2.transform.parent = player2.transform;
            camera2.transform.position = player2.transform.position + Vector3.up * 10 + Vector3.forward * 10;*/
        }
        
        Debug.Log(PhotonNetwork.CurrentRoom.PlayerCount);
        player_re = PhotonNetwork.CurrentRoom.PlayerCount;
        if (player_re == 2)
        {
            make_item.SetActive(true);
        }
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("OnPlayerEnteredRoom");
        player_re = PhotonNetwork.CurrentRoom.PlayerCount;
        if (player_re == 2)
        {
            make_item.SetActive(true);
        }
    }
}
