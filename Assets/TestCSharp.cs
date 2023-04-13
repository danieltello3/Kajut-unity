using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Tipo
{
   Activo, Inactivo
}

public class TestCSharp : MonoBehaviour
{
   private string nombre;
   public int Edad { get; set; } //propiedad
   public int Peso { get; private set; } //solo de lectura
   public string GetNombre()
   {
      return nombre;
   }

   public void SetNombre(string nombre)
   {
      this.nombre = nombre;
   }
   //se puede heredar pero se vuelve privado en el hijo
   protected void MetodoProtected()
   {
      this.Edad = 10;
      Peso = 70;
   }
   public void MetodoPublico()
   {

   }

   private void Update()
   {
   }

   private void Start()
   {
      int num = 10;
      float peso = 40.5f;
      bool verdad = true;
      string nombre = "Daniel";
      //   string numero = num.ToString(); //NullreferenceException
      //   string numero2 = (string)num; //InvalidCastException
      //   string numero3 = num as string; //numero = null

      Debug.Log($"Hola {nombre}");
   }
}
