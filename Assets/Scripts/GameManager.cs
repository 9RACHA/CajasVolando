using System.Collections;
using System.Collections.Generic; //NECESARIO PARA USAR LIST
using UnityEngine;

public class GameManager : MonoBehaviour {

    /*List Es una clase genérica que proporciona una colección dinámica de elementos del mismo tipo
    Puede crecer o reducirse automáticamente según sea necesario.
    List<int> miLista = new List<int>();
    miLista.Add(10);   // Agrega el valor 10 a la lista

    Count: Proporciona el número de elementos en la lista.
    Remove: Elimina la primera aparición de un elemento específico de la lista.
    Contains: Verifica si un elemento específico está presente en la lista.
    Sort: Ordena los elementos de la lista.

    int cantidadElementos = miLista.Count;   // Obtiene el número de elementos en la lista
    miLista.Remove(3);   // Elimina la primera aparición del valor 3 de la lista
    bool contieneCuatro = miLista.Contains(4);   // Verifica si la lista contiene el valor 4
    miLista.Sort();   // Ordena los elementos de la lista en orden ascendente*/
    public List<GameObject> cajas; //lista de las cajas que hay en la escena.

    void Update() {
        //Al presionar la barra espaciadora aplicará un impulso a todas las cajas que tiene registradas,
        // llamando al correspondiente método de la caja
        if(Input.GetKeyDown(KeyCode.Space)) {
            EmpujarCajas();
            Debug.Log("Empujo");
        }
        //Al presionar la tecla D (por delete) el controlador destruirá una de las cajas seleccionada al azar
        if(Input.GetKeyDown(KeyCode.D)) {
            DestruirCaja();
            Debug.Log("Destruyo");
        }
    }
    /*foreach: se utiliza para iterar sobre elementos de una colección o secuencia, como un array, una lista, un diccionario u otro tipo de datos que sea recorrible
    foreach (tipo elemento in colección){
    // Código para procesar el elemento; }
    tipo es el tipo de datos de los elementos en la colección.
    elemento es una variable que representa cada elemento de la colección en cada iteración.
    colección es la colección o secuencia de elementos a iterar.*/
    private void EmpujarCajas() {
        foreach(GameObject goCaja in cajas) {
            ClaseCaja caja = goCaja.GetComponent<ClaseCaja>(); 
            caja.empujar();
        }
    }

    private void DestruirCaja() {
        //Elegimos al azar el índice de la caja a eliminar;        
        int index = Random.Range(0, cajas.Count); //define como int a index y hace un aleatorio de la lista cajas
        Destroy(cajas[index]); // Destruye las cajas de la lista
        cajas.RemoveAt(index); //Las elimina de la lista
    }
}
