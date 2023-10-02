using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Classe Guiche
public class Guiche
{
    public int id { get; private set; }
    public Queue<Senha> atendimentos { get; private set; }

    public Guiche()
    {
        id = 0;
        atendimentos = new Queue<Senha>();
    }

    public Guiche(int id)
    {
        this.id = id;
        atendimentos = new Queue<Senha>();
    }

    public bool chamar(Queue<Senha> filaSenhas)
    {
        if (filaSenhas.Count > 0)
        {
            Senha proximaSenha = filaSenhas.Dequeue();
            proximaSenha.dataAtend = DateTime.Now;
            proximaSenha.horaAtend = DateTime.Now;
            atendimentos.Enqueue(proximaSenha);
            return true;
        }
        return false;
    }
}