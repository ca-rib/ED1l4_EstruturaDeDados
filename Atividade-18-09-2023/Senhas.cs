using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Classe Senhas
public class Senhas
{
    private int proximoAtendimento;
    private Queue<Senha> filaSenhas;

    public Senhas()
    {
        proximoAtendimento = 1;
        filaSenhas = new Queue<Senha>();
    }

    public void gerar()
    {
        Senha novaSenha = new Senha(proximoAtendimento);
        proximoAtendimento++;
        filaSenhas.Enqueue(novaSenha);
    }
}