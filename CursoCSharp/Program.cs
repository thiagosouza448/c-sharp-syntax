using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeroPrograma.Executar},
                {"Comentários - fundamentos ",  Comentarios.Executar},
                {" Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {" Inferencia - Fundamentos", Inferencia.Executar },
                {" Interpolação - Fundamentos", Interpolacao.Executar },
                {" Notação ponto - Fundamentos", NotacaoPonto.Executar },
                {" Lendo Dados - Fundamentos", LendoDados.Executar },


            });
            
            central.SelecionarEExecutar();
        }
    }
}