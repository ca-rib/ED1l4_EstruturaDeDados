using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Classe Senha
public class Senha
{
    public int id { get; private set; }
    public DateTime dataGerac { get; private set; }
    public DateTime horaGerac { get; private set; }
    public DateTime dataAtend { get; private set; }
    public DateTime horaAtend { get; private set; }

    public Senha(int id)
    {
        this.id = id;
        this.dataGerac = DateTime.Now;
        this.horaGerac = DateTime.Now;
    }

    public string dadosParciais()
    {
        return $"{id}-{dataGerac}-{horaGerac}";
    }

    public string dadosCompletos()
    {
        return $"{id}-{dataGerac}-{horaGerac}-{dataAtend}-{horaAtend}";
    }
}

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

// Classe Guiches
public class Guiches
{
    public List<Guiche> listaGuiches { get; private set; }

    public Guiches()
    {
        listaGuiches = new List<Guiche>();
    }

    public void adicionar(Guiche guiche)
    {
        listaGuiches.Add(guiche);
    }
}
