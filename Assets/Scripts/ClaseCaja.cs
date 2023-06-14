using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseCaja : MonoBehaviour {
    
    // Lista de materiales entre los que se escoge uno al azar para cada caja
    public List<Material> materiales;
    public float rotationSpeed;
    // Índice del material que actualmente luce la caja
    int indice;

    Vector3 startPosition;
    Quaternion startRotation;

    // Start is called before the first frame update
    void Start() {
        ponerMaterial();
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update() {
 
        if(Input.GetKeyDown(KeyCode.C)) {
            RotarMaterial();
            Debug.Log("Cambio Color");
        }
        if(Input.GetKeyDown(KeyCode.R)) {
            VolverInicio();
            Debug.Log("Posicion Inicial");
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)) {
            Girar(Vector3.up);
        } 
        if(Input.GetKeyDown(KeyCode.RightArrow)) {
            Girar(Vector3.down);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            Girar(Vector3.right);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)) {
            Girar(Vector3.left);
        }
    }

    // Restaura la posición y rotación iniciales de la caja
    private void VolverInicio() {
        // Ponemos la caja en la posición y orientación que tenía inicialmente
        transform.position = startPosition;
        transform.rotation = startRotation;

        // Establecemos a 0 su velocidad lineal
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        // y también la velocidad de rotación
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }

    // Rota el material de la caja al siguiente en la lista
    private void RotarMaterial() {
        //La variable indice se actualiza para apuntar al siguiente índice en la lista de materiales.
        // Se utiliza el operador módulo % para asegurarse de que el índice no exceda los límites de la lista.
        // Si indice llega al final de la lista, se reinicia al principio
        indice = (indice + 1) % materiales.Count;
        GetComponent<MeshRenderer>().material = materiales[indice];
    }

    // Aplica un material aleatorio de la lista a la caja
    private void ponerMaterial() {
        if(materiales == null || materiales.Count == 0) {
            return;
        }

        indice = Random.Range(0, materiales.Count);

        GetComponent<MeshRenderer>().material = materiales[indice];
    }

    // Gira la caja en función del eje de giro especificado
    private void Girar(Vector3 ejeGiro) {
        GetComponent<Rigidbody>().angularVelocity = ejeGiro * rotationSpeed;
    }

    // Aplica una fuerza aleatoria a la caja
    public void empujar() {
        Vector3 fuerza = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100));
        
        GetComponent<Rigidbody>().AddForce(fuerza); 

        Debug.Log(gameObject.name + " fuerza " + fuerza);
    }
}
