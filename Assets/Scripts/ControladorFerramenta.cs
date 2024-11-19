using UnityEngine;

public class ControladorFerramenta : MonoBehaviour
{
    public Vector3 posicaoFerramenta;
    public float deslocamentoferramenta;
    public float incrementoVelocidade;

    internal float deslocamentoInicial;
    internal int sentidoV;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sentidoV = 1;
        deslocamentoInicial = deslocamentoferramenta;
    }

    // Update is called once per frame
    void Update()
    {
        posicaoFerramenta.x += deslocamentoferramenta * Time.deltaTime;
        posicaoFerramenta.y += deslocamentoferramenta * Time.deltaTime * sentidoV;

        transform.position = posicaoFerramenta;

        //arrumar sentido vertical:

        if (transform.position.y >= 475 && sentidoV == 1)
            sentidoV = -1;
        if (transform.position.y <= 35 && sentidoV == -1)
            sentidoV = 1;

        deslocamentoferramenta += incrementoVelocidade * Time.deltaTime;
    }
}
