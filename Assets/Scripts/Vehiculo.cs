using UnityEngine;

public class Vehiculo : MonoBehaviour
{
    //Atributos
    public string modelo;
    public string color;
    private float _cantidadGasolina = 1000;
    private float _velocidadActual = 0;

    //Metodos
    private void Update()
    {
        ControlarGasolina();
        Acelerar(1);
    }
    
    
    public void Acelerar(float velocidad)
    {
        _velocidadActual += velocidad;
        print("El coche es de color" + color + " Tiene una velocidad actual: " + _velocidadActual);
        _cantidadGasolina--;
    }

    private void ControlarGasolina()
    {
        if (_cantidadGasolina < 0) {
        }
        Parar();
    }
    public void Parar()
    {

    }
    public void Arrancar()
    {

    }
}
