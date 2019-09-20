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
                {"Formatando números - Fundamentos ", FormatandoNumero.Executar },
                {"Conversões - Fundamentos ", Conversoes.Executar },
                {"Operadores aritimeticos - Fundamentos ", OperadoresAritimeticos.Executar },
                {"Operadores Relacionais - Fundamentos ", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos ", OperadoresLogicos.Executar },
                {"Operadores Atribuicao - Fundamentos ", OperadoresAtribuicao.Executar }


            });
            
            central.SelecionarEExecutar();
        }
    }
}