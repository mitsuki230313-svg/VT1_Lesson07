using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [Header("* * * 移動速度＊＊＊")]
    [SerializeField] private 

void Start()
    {
        MoveInputEnabled();
    }

   
    void Update()
    {
        Movement();
    }

    //移動メソッド
    public void Movement()
    {
        //入力値を実際の移動平面に変換
        var inputAxis = new Vecotor3(_inputMoveVector.x, 0, _InputMoveVector.y);

        //カメラの向いている方向を移動ベクトルに
        //1:　↑カメラの正面ベクトルを取得
        var cameraForward = _cameraContoroller.transform.forward;

        //2:入力値と合わせる
        var moveVecotor = (inputAxis.x * _cameraContoroller.transform.right) + (inputAxis)
        moveVector.y = 0;


        //(仮)入力をそのまま移動ベクトルへ
        _verocity = inputAxis;

        Vector3 finalVelocity( _moveSpeed * _verocity *Time.deltatime;)
        transform.Translate(finalVelocity, Space.World);
    }

    //移動入力の登録
    public void MoveInputEnabled()
    {
        if(_playerInput = null)
        {
            Debug.Log("PlayerInput")
                return;
        }
        //移動入力値
        _playerInput.action["Move"].performed += context =>
        {

        };
    }

    private void OnMoveInput(InputAction.CallbackContext context)
    {
        var value = context.ReadValue<Vector2>();//入力値の取得
        _inputMoveVector = value;                //変数に保存
    }

    private void OnMoveCanceled(InputAction.CallbackContext context)
    {
        _inputMoveVector = Vector3.zero; //変数の値をリセット
    }









}
