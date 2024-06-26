using UnityEngine;


public class Player : MonoBehaviour

{

    Rigidbody2D rig;
   [Range(1,6)] public int Speed = 5;
   [SerializeField] private string nomeDoPlayer;
     public int Jump = 4;
    private bool chao, puloDuplo;
    

    // Start is called before the first frame update

    void Start(){
       rig = GetComponent<Rigidbody2D>();
}

    // Update is called once per frame

    void Update(){

        mover();
        pular();
    }

    void mover(){
        rig.velocity = new Vector2(Input.GetAxis("HorizontalManaSama") * Speed, rig.velocity.y);

    }

    void pular(){
        if (Input.GetButtonDown("Jump")){
         if (chao){
                rig.AddForce(Vector2.up * Jump, ForceMode2D.Impulse);
                chao = false;
                puloDuplo = true;
            } else if (puloDuplo)
            {
                rig.AddForce(Vector2.up * Jump, ForceMode2D.Impulse);
                chao = false;
                puloDuplo = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D colisao)

    {
        if (colisao.gameObject.CompareTag("Plataforma"))
        {
            chao = true;
            puloDuplo = false;

        }
    }

}
