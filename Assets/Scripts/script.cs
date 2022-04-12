using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    /* 
     Una flota de taxis tiene una cantidad determinada de unidades. Se calcula que cada unidad recorre unos 90 km por día y que cada litro de combustible permite recorrer 15 km. Se calcula también que los días de lluvia se trabaja más, llegando a un recorrido de 110 km por unidad. Teniendo en cuenta que el litro de combustible cuesta $130, debemos hacer un programa que nos permita calcular el costo del combustible para una flota completa de taxis en un período de días determinado.
    Se requiere el ingreso por Inspector de la cantidad de unidades que tiene la flota, la cantidad total de días y una cantidad de días de lluvia a tener en cuenta.
    El programa debe cumplir los siguientes requerimientos:
    - El programa debe devolver la información calculada mediante un mensaje en el siguiente formato:
    “Una flota de [cantidadDeUnidades] unidades trabajando durante [periodoDeDias] días implicará un gasto de [costoTotalCombustible] pesos en concepto de combustible”.
     - El programa debe devolver un mensaje de error y no realizar ningún cálculo si la cantidad de días total es menor que 5 o si la cantidad de días de lluvia es negativa o mayor que la cantidad total de días. 

    */
    public int autos;
    public int dias_totales;
    public int dias;
    public int dias_lluvia;
    float combustible = 130;
    int litros;
    float litros_lluvia;
    float nafta;
    float nafta_lluvia;
    

    // Start is called before the first frame update
    void Start()
    {

        if (dias_totales <= 5 || dias_lluvia < 0 || dias_lluvia > dias_totales)
        {
            Debug.Log("Error, intente cambiar alguna de estas variables: dias_totales (menor o igual a 5), dias_lluvia (mayor a los dias sin lluvia), dias_lluvia (negativo)");
        }
        else
        {



            dias = dias_totales - dias_lluvia;
            litros = 90 / 15; //en un dia recorre 90 km. Un litro son 15km, por lo tanto hago esta cuenta.
            litros_lluvia = 110 / 15;

            //dia normal
            nafta = (autos * litros) * combustible;
            float coste_nafta = nafta * dias;

            //dia lluvia
            nafta_lluvia = (autos * litros_lluvia) * combustible;
            float coste_nafta_lluvia = nafta * dias;

            combustible = coste_nafta + coste_nafta_lluvia;




            Debug.Log("Una flota de " + autos + " unidades trabajando durante " + dias_totales + " días implicará un gasto de " + combustible + " pesos en concepto de combustible");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
