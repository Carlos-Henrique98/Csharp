using System;
using System.Collections.Generic;
using ReciclagemLixo.interfaces;

namespace ReciclagemLixo {
    public class GuardaChuva : IAmareloMetal
    {
        public bool AmareloMetal () {
            Console.WriteLine ("METAL - LIXO AMARELO");
            return true;
        }

        public void Adicionar () {
            Console.WriteLine ("ADICIONAR QUANTOS MATERIAIS?");
            int quantidadeMaterial = int.Parse (Console.ReadLine ());

            for (int i = 0; i < quantidadeMaterial; i++) {

                Console.WriteLine ("===========================");
                Console.Write ("Adicionar Material? [S/N]:");
                string pergunta = Console.ReadLine ();
                Console.WriteLine ("===========================");
                if (pergunta == "S" || pergunta == "s") {
                    Console.WriteLine ("     - METAL - ");
                    Console.Write ("ADICIONE O MATERIAL:");
                    string material = Console.ReadLine ();
                    Console.WriteLine ("Material Adicionado: " + material);

                    List<string> vetor = new List<string> ();

                    Console.WriteLine ();
                    Console.WriteLine ("=====================");
                    Console.WriteLine ("    MENU MATERIAL");
                    Console.WriteLine ("=====================");
                    Console.WriteLine ();
                    vetor.Add ("[1] - GARRAFA");
                    vetor.Add ("[2] - GARRAFA PET");
                    vetor.Add ("[3] - GUARDA CHUVA");
                    vetor.Add ("[4] - LATINHA");
                    vetor.Add ("[5] - PAPELÃO");
                    vetor.Add ("[6] - POTE DE MANTEIGA");
                    vetor.Add ("[7] - " + material);

                    foreach (string nome in vetor) {
                        Console.WriteLine (nome);
                    }
                } else {
                    Console.WriteLine ("TENTE NOVAMENTE!");
                }
            }

        }

        public bool AmareMetal()
        {
            throw new NotImplementedException();
        }
    }
}