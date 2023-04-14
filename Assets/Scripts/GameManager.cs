using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Pregunta
{
   public string Texto;
   public List<string> Opciones;
   public int IndexCorrecta;

   public Pregunta()
   {
      Opciones = new List<string>();
   }
}

public class GameManager : MonoBehaviour
{
   public TextMeshProUGUI TextoPregunta;
   public TextMeshProUGUI TextoTimer;
   public Button butOpcion1;
   public Button butOpcion2;
   public Button butOpcion3;
   public Button butOpcion4;

   private List<Pregunta> listaPreguntas;
   private int index = 0;

   private void Start()
   {
      CrearPreguntas();
      CargarPregunta(0);
   }

   private void CrearPreguntas()
   {
      Pregunta p1 = new Pregunta() { Texto = "¿Esta es la pregunta 1?", IndexCorrecta = 1 };
      p1.Opciones.Add("OPCION 1");
      p1.Opciones.Add("OPCION 2");
      p1.Opciones.Add("OPCION 3");
      p1.Opciones.Add("OPCION 4");

      Pregunta p2 = new Pregunta();
      p2.Texto = "¿Esta es la pregunta 2?";
      p2.Opciones.Add("OPCION 1");
      p2.Opciones.Add("OPCION 2");
      p2.Opciones.Add("OPCION 3");
      p2.Opciones.Add("OPCION 4");
      p2.IndexCorrecta = 2;

      listaPreguntas = new List<Pregunta>() { p1,p2};
   }

   private void CargarPregunta(int index)
   {
      Pregunta pregunta = listaPreguntas[index];
      Console.WriteLine(pregunta);
      TextoPregunta.text = pregunta.Texto;

      TextMeshProUGUI textOpt1 = butOpcion1.transform.Find("Text").GetComponent<TextMeshProUGUI>();
      textOpt1.text = pregunta.Opciones[0];

      TextMeshProUGUI textOpt2 = butOpcion2.transform.Find("Text").GetComponent<TextMeshProUGUI>();
      textOpt2.text = pregunta.Opciones[1];

      TextMeshProUGUI textOpt3 = butOpcion3.transform.Find("Text").GetComponent<TextMeshProUGUI>();
      textOpt3.text = pregunta.Opciones[2];

      TextMeshProUGUI textOpt4 = butOpcion4.transform.Find("Text").GetComponent<TextMeshProUGUI>();
      textOpt4.text = pregunta.Opciones[3];
   }


   private void Update()
   {

   }
}
