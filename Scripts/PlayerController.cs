using UnityEngine;

public class playercontroler : MonoBehaviour
{

    public float speed = 5f;
    [Header("Teclas de Movimento")]
    public KeyCode teclaCima = KeyCode.W;
    public KeyCode teclaBaixo = KeyCode.S;
    public KeyCode teclaDireita = KeyCode.D;
    public KeyCode teclaEsquerda = KeyCode.A;


    private Rigidbody rb;

    // variavel privada que vai guardar a referencia do componente
    // rigidbody do objeto. "private" porque nao precisa aparecer
    // no inspector e so uso interno do scriptvoid Start()

    // start() roda UMA UNICA vez, antes do primeiro update()
    // quando o objeto entra em cena. Ideal para preparar referencias.    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()

    {

        Vector3 direcao = Vector3.zero;


        if (Input.GetKey(teclaCima))

            direcao += Vector3.forward;

        if (Input.GetKey(teclaBaixo))

            direcao += Vector3.back;

        if (Input.GetKey(teclaDireita))

            direcao += Vector3.right;

        if (Input.GetKey(teclaEsquerda))

            direcao += Vector3.left;

        rb.AddForce(direcao.normalized * speed);

    }

}