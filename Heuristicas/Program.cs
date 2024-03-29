﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HeuristicaConstrutiva;
using HeuristicaMelhoria;
using CaixeiroViajante;
using ProblemaQuadroHorarios;
using ProblemaMochila;

namespace Heuristicas
{
    class Program
    {
        static void Main(string[] args)
        {
            /****************************************** Problema Mochila *********************************************/
            OtimizaMochila heuristica = new OtimizaMochila(75);
            heuristica.AddItem(new Item() { Descricao = "Lanterna", Peso = 3, Utilidade = 15 });
            heuristica.AddItem(new Item() { Descricao = "Canivete Suíço", Peso = 1, Utilidade = 10 });
            heuristica.AddItem(new Item() { Descricao = "Jaca", Peso = 30, Utilidade = 3 });
            heuristica.AddItem(new Item() { Descricao = "Panela", Peso = 5, Utilidade = 15 });
            heuristica.AddItem(new Item() { Descricao = "Carne", Peso = 10, Utilidade = 20 });
            heuristica.AddItem(new Item() { Descricao = "Arroz", Peso = 7, Utilidade = 20 });
            heuristica.AddItem(new Item() { Descricao = "Feijão", Peso = 8, Utilidade = 20 });
            heuristica.AddItem(new Item() { Descricao = "Cerveja", Peso = 15, Utilidade = 8 });
            heuristica.AddItem(new Item() { Descricao = "Mapa", Peso = 1, Utilidade = 15 });
            heuristica.AddItem(new Item() { Descricao = "Celular", Peso = 3, Utilidade = 9 });
            heuristica.AddItem(new Item() { Descricao = "Barraca", Peso = 8, Utilidade = 60 });
            heuristica.AddItem(new Item() { Descricao = "Cobertor", Peso = 8, Utilidade = 25 });
            heuristica.AddItem(new Item() { Descricao = "Jornal", Peso = 3, Utilidade = 5 });
            heuristica.AddItem(new Item() { Descricao = "Papel Higiênico", Peso = 2, Utilidade = 14 });
            heuristica.AddItem(new Item() { Descricao = "Carvão", Peso = 8, Utilidade = 15 });
            heuristica.AddItem(new Item() { Descricao = "Repelente", Peso = 2, Utilidade = 5 });
            heuristica.AddItem(new Item() { Descricao = "Vara de Pescar", Peso = 3, Utilidade = 2 });
            heuristica.AddItem(new Item() { Descricao = "Pente", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Espelho", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Sabão", Peso = 2, Utilidade = 7 });
            heuristica.AddItem(new Item() { Descricao = "Xampu", Peso = 4, Utilidade = 5 });
            heuristica.AddItem(new Item() { Descricao = "Luvas", Peso = 1, Utilidade = 2 });
            heuristica.AddItem(new Item() { Descricao = "Violão", Peso = 15, Utilidade = 4 });
            heuristica.AddItem(new Item() { Descricao = "Fósforo", Peso = 1, Utilidade = 7 });
            heuristica.AddItem(new Item() { Descricao = "Isqueiro", Peso = 1, Utilidade = 9 });
            heuristica.AddItem(new Item() { Descricao = "Bússola", Peso = 2, Utilidade = 14 });
            heuristica.AddItem(new Item() { Descricao = "Roupa", Peso = 5, Utilidade = 28 });
            heuristica.AddItem(new Item() { Descricao = "Sapatos", Peso = 3, Utilidade = 11 });
            heuristica.AddItem(new Item() { Descricao = "Protetor Solar", Peso = 2, Utilidade = 6 });
            heuristica.AddItem(new Item() { Descricao = "Pratos", Peso = 5, Utilidade = 12 });
            heuristica.AddItem(new Item() { Descricao = "Colheres", Peso = 1, Utilidade = 8 });
            heuristica.AddItem(new Item() { Descricao = "Facas", Peso = 1, Utilidade = 13 });
            heuristica.AddItem(new Item() { Descricao = "Binóculos", Peso = 5, Utilidade = 3 });
            heuristica.AddItem(new Item() { Descricao = "GPS", Peso = 5, Utilidade = 20 });
            heuristica.AddItem(new Item() { Descricao = "Notebook", Peso = 15, Utilidade = 5 });
            heuristica.AddItem(new Item() { Descricao = "Som", Peso = 16, Utilidade = 8 });
            heuristica.AddItem(new Item() { Descricao = "Livro", Peso = 3, Utilidade = 3 });
            heuristica.AddItem(new Item() { Descricao = "Corda", Peso = 5, Utilidade = 15 });
            heuristica.AddItem(new Item() { Descricao = "Lixa Unha", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Esmalte", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Alicate", Peso = 2, Utilidade = 8 });
            heuristica.AddItem(new Item() { Descricao = "Machado", Peso = 15, Utilidade = 50 });
            heuristica.AddItem(new Item() { Descricao = "Linha", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Agulha", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Band Aid", Peso = 1, Utilidade = 12 });
            heuristica.AddItem(new Item() { Descricao = "Mertiolate", Peso = 1, Utilidade = 11 });
            heuristica.AddItem(new Item() { Descricao = "Gaze", Peso = 1, Utilidade = 13 });
            heuristica.AddItem(new Item() { Descricao = "Perfume", Peso = 1, Utilidade = 1 });
            heuristica.AddItem(new Item() { Descricao = "Leite", Peso = 4, Utilidade = 10 });
            heuristica.AddItem(new Item() { Descricao = "Biscoitos", Peso = 4, Utilidade = 10 });
            heuristica.AddItem(new Item() { Descricao = "Sucrilhos", Peso = 3, Utilidade = 7 });
            heuristica.AddItem(new Item() { Descricao = "Bombons", Peso = 3, Utilidade = 5 });
            heuristica.AddItem(new Item() { Descricao = "Meias", Peso = 1, Utilidade = 2 });
            heuristica.AddItem(new Item() { Descricao = "Chapeu", Peso = 3, Utilidade = 7 });
            heuristica.AddItem(new Item() { Descricao = "Estilingue", Peso = 1, Utilidade = 4 });
            heuristica.AddItem(new Item() { Descricao = "Martelo", Peso = 6, Utilidade = 12 });
            heuristica.AddItem(new Item() { Descricao = "Arame", Peso = 6, Utilidade = 15 });
            

            heuristica.GerarSolucao();

            System.Console.WriteLine("===================+==========Problema da Mochila==============================\n");
            int u = 0;
            foreach (IComponente c in heuristica.Solucao.Componentes)
            {
                Item item = (Item)c;
                u += item.Utilidade;
                System.Console.WriteLine(item.Descricao + " \t\t\tPeso: " + item.Peso + " \t\tUtilidade: " + item.Utilidade);
            }

            System.Console.WriteLine("\n\nPeso da Mochila: " + heuristica.Mochila.CapacidadeAtual);
            System.Console.WriteLine("Utilidade da Mochila: " + heuristica.Solucao.Avaliacao);

            
            

            /****************************************** Problema Caixeiro Viajante *********************************************/
            ConstroiGrafo constroiGrafo = new ConstroiGrafo(8);
            
            Vertice ba = new Vertice("BA");
            Vertice df = new Vertice("DF");
            Vertice es = new Vertice("ES");
            Vertice mg = new Vertice("MG");
            Vertice pr = new Vertice("PR");
            Vertice rj = new Vertice("RJ");
            Vertice sp = new Vertice("SP");
            Vertice se = new Vertice("SE");

            ba.Add(df, 1446);
            ba.Add(es, 1202);
            ba.Add(mg, 1372);
            ba.Add(pr, 2385);
            ba.Add(rj, 1649);
            ba.Add(se, 2682);
            ba.Add(sp, 1962);

            df.Add(es, 1239);
            df.Add(mg, 716);
            df.Add(pr, 1366);
            df.Add(rj, 1148);
            df.Add(se, 1673);
            df.Add(sp, 1015);

            es.Add(mg, 524);
            es.Add(pr, 1300);
            es.Add(rj, 521);
            es.Add(se, 1597);
            es.Add(sp, 882);
            
            mg.Add(pr, 1004);
            mg.Add(rj, 434);
            mg.Add(se, 1301);
            mg.Add(sp, 586);

            pr.Add(rj, 852);
            pr.Add(se, 300);
            pr.Add(sp, 408);

            rj.Add(se, 1144);
            rj.Add(sp, 429);

            se.Add(sp, 705);
           

            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = ba, CidadeDestino = df, Distancia = 1446 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = ba, CidadeDestino = es, Distancia = 1202 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = ba, CidadeDestino = mg, Distancia = 1372 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = ba, CidadeDestino = pr, Distancia = 2385 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = ba, CidadeDestino = rj, Distancia = 1649 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = ba, CidadeDestino = se, Distancia = 2682 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = ba, CidadeDestino = sp, Distancia = 1962 });

            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = df, CidadeDestino = es, Distancia = 1239 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = df, CidadeDestino = mg, Distancia = 716 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = df, CidadeDestino = pr, Distancia = 1366 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = df, CidadeDestino = rj, Distancia = 1148 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = df, CidadeDestino = se, Distancia = 1673 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = df, CidadeDestino = sp, Distancia = 1015 });

            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = es, CidadeDestino = mg, Distancia = 524 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = es, CidadeDestino = pr, Distancia = 1300 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = es, CidadeDestino = rj, Distancia = 521 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = es, CidadeDestino = se, Distancia = 1597 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = es, CidadeDestino = sp, Distancia = 882 });
            
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = mg, CidadeDestino = pr, Distancia = 1004 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = mg, CidadeDestino = rj, Distancia = 434 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = mg, CidadeDestino = se, Distancia = 1301 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = mg, CidadeDestino = sp, Distancia = 586 });

            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = pr, CidadeDestino = rj, Distancia = 852 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = pr, CidadeDestino = se, Distancia = 300 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = pr, CidadeDestino = sp, Distancia = 408 });

            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = rj, CidadeDestino = se, Distancia = 1144 });
            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = rj, CidadeDestino = sp, Distancia = 429 });

            constroiGrafo.Arestas.Add(new Aresta { CidadeOrigem = se, CidadeDestino = sp, Distancia = 705 });
            


            constroiGrafo.CidadeInicial = mg;

            constroiGrafo.GerarSolucao();

            System.Console.WriteLine("\n\n============================Problema Caixeiro Viajante==========================\n");

            int somaDistancias = 0;
            foreach (IComponente a in constroiGrafo.Solucao.Componentes)
            {
                Aresta aresta = (Aresta)a;
                System.Console.WriteLine("\nCidade Origem: " + aresta.CidadeOrigem.Valor + " \t\tCidade Destino: " + aresta.CidadeDestino.Valor + " \t\tDistancia: " + aresta.Distancia);
                somaDistancias += aresta.Distancia;
            }

            System.Console.WriteLine("\n\nDistância total: " + somaDistancias+"\n\n\n\n\n");




            /****************************************** Problema Quadro de Horário *********************************************/
            ConstroiQuadroHorario cqh = new ConstroiQuadroHorario();


            //Horários
            Horario seg12 = new Horario("seg12");
            cqh.Horarios.Add(seg12);

            Horario seg34 = new Horario("seg34");
            cqh.Horarios.Add(seg34);

            Horario ter12 = new Horario("ter12");
            cqh.Horarios.Add(ter12);

            Horario ter34 = new Horario("ter34");
            cqh.Horarios.Add(ter34);

            Horario qua12 = new Horario("qua12");
            cqh.Horarios.Add(qua12);

            Horario qua34 = new Horario("qua34");
            cqh.Horarios.Add(qua34);

            Horario qui12 = new Horario("qui12");
            cqh.Horarios.Add(qui12);

            Horario qui34 = new Horario("qui34");
            cqh.Horarios.Add(qui34);

            Horario sex12 = new Horario("sex12");
            cqh.Horarios.Add(sex12);

            Horario sex34 = new Horario("sex34");
            cqh.Horarios.Add(sex34);


            //Professores
            Professor p1 = new Professor("p1");
            cqh.Professores.Add(p1);

            Professor p2 = new Professor("p2");
            cqh.Professores.Add(p2);
            
            Professor p3 = new Professor("p3");
            cqh.Professores.Add(p3);
            
            Professor p4 = new Professor("p4");
            cqh.Professores.Add(p4);
            
            Professor p5 = new Professor("p5");
            cqh.Professores.Add(p5);



            //Restrições
            cqh.AddRestricao(p1, seg12);
            cqh.AddRestricao(p1, ter12);
            cqh.AddRestricao(p1, qui12);

            cqh.AddRestricao(p2, qui34);
            cqh.AddRestricao(p2, sex34);

            cqh.AddRestricao(p3, ter34);
            cqh.AddRestricao(p3, qua12);
            cqh.AddRestricao(p3, qua34);

            cqh.AddRestricao(p4, qui12); 
            cqh.AddRestricao(p4, sex34);

            cqh.AddRestricao(p5, ter12);
            cqh.AddRestricao(p5, qua12);
            cqh.AddRestricao(p5, qui12);

            cqh.GerarSolucao();

            System.Console.WriteLine("\n\n============================Problema Quadro de Horário==========================\n");
            foreach (IComponente a in cqh.Solucao.Componentes)
            {
                Alocacao alocacao = (Alocacao)a;
                System.Console.WriteLine("\nHorário: " + alocacao.Horario.Id + " \t\tProfessor: " + alocacao.Professor.Nome);
            }
            System.Console.ReadLine();
        }
    }
}
