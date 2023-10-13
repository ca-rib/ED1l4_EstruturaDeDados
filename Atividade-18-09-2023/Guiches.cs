using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Atividade-18-09-2023
{
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
}
