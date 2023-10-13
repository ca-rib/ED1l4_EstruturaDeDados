using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Atividade-18-09-2023
{
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
}
